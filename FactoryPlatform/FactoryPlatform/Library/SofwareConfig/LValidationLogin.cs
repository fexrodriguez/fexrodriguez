using FactoryPlatform.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPlatform.Library
{
    public class LValidationLogin : ListObjects
    {
        public LValidationLogin(Data.ApplicationDbContext context)
        {
            _appContext = context;
        }

        //--------------------Hasheo of password, decifrade and check password + salt ---------------------------------------
        public class HashedPassword
        {
            public string Password { get; set; }
            public string Salt { get; set; }
        }

        public HashedPassword Hash(string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return new HashedPassword() { Password = hashed, Salt = Convert.ToBase64String(salt) };
        }

        public bool CheckHash(string attemptedPassword, string hash, string salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                 password: attemptedPassword,
                 salt: Convert.FromBase64String(salt),
                 prf: KeyDerivationPrf.HMACSHA256,
                 iterationCount: 10000,
                 numBytesRequested: 256 / 8));
            return hash == hashed;
        }

        public byte[] GetHash(string password, string salt)
        {
            byte[] unhashedBytes = Encoding.Unicode.GetBytes(string.Concat(salt, password));
            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashedBytes = sha256.ComputeHash(unhashedBytes);
            return hashedBytes;
        }

        //------------------------------------------------------------------------------------------------------
        public string validateUserPassword(LoginViewModel model)
        {
            string Result = null;

            var existUser = _appContext.Users.Select(u => new Models.Users
            {
                Usuario = u.Usuario,
                PasswordHash = u.PasswordHash,
                Salt = u.Salt,
                Status = u.Status
            }).Where(u => u.Usuario.Equals(model.Usuario) && u.Status.Equals(true)).AsNoTracking().ToList();

            if (existUser.Count.Equals(0))
            {
                Result = "You can't sing in please check the information!";
            }
            else
            {
                Result = CheckHash(model.PasswordHash, existUser.First().PasswordHash, existUser.First().Salt) ? Result = null : "User or Password Incorrect contact the administrator!";
            }

            return Result;
        }

        //------------------------Check is exist a session saved on the data base ----------------------------------------

        //Select if the table is empty
        public List<Users_ValidationSession> checkAllSession()
        {
            var session = new List<Users_ValidationSession>();
            session = _appContext.Users_ValidationSession.AsNoTracking().ToList();

            return session;
        }

        //select if the user have open session
        public List<Users_ValidationSession> checkSession(string Usuario)
        {
            var session = new List<Users_ValidationSession>();
            session = _appContext.Users_ValidationSession.Where(u => u.Usuario.Equals(Usuario) && u.Status.Equals(true)).AsNoTracking().ToList();

            return session;
        }

        //select if the cookie have been in the database
        public List<Users_ValidationSession> checkSessionBySessionIdOld(string sessionId)
        {
            var session = new List<Users_ValidationSession>();
            session = _appContext.Users_ValidationSession.Where(S => S.IDSesion.Equals(sessionId)).AsNoTracking().ToList();

            return session;
        }

        //select the session with the sessionId that has the cookie
        public List<Users_ValidationSession> checkSessionBySessionId(string sessionId)
        {
            var session = new List<Users_ValidationSession>();
            session = _appContext.Users_ValidationSession.Where(S => S.IDSesion.Equals(sessionId) && S.Status.Equals(true)).AsNoTracking().ToList();

            return session;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------


        public List<Users> infoUserIdentify(string Usuario)
        {
            var userInf = _appContext.Users.Where(u => u.Usuario.Equals(Usuario) && u.Status.Equals(true)).Select(u => new Users
            {
                Id_Usuario = u.Id_Usuario,
                Usuario = u.Usuario,
            }).AsNoTracking().ToList();

            return userInf;
        }

        public List<Users> infoUserByCorreo(string Correo)
        {
            var userInf = _appContext.Users.Where(u => u.Correo.Equals(Correo) && u.Status.Equals(true)).Select(u => new Users
            {
                Id_Usuario = u.Id_Usuario,
                Usuario = u.Usuario,
            }).AsNoTracking().ToList();

            return userInf;
        }

        public List<Users> infoUserDisableIdentify(string Usuario)
        {
            var userInf = _appContext.Users.Where(u => u.Usuario.Equals(Usuario)).Select(u => new Users
            {
                Id_Usuario = u.Id_Usuario,
                Usuario = u.Usuario,
            }).AsNoTracking().ToList();

            return userInf;
        }

        public List<Users> infoUserDisableByCorreo(string Correo)
        {
            var userInf = _appContext.Users.Where(u => u.Correo.Equals(Correo)).Select(u => new Users
            {
                Id_Usuario = u.Id_Usuario,
                Usuario = u.Usuario,
            }).AsNoTracking().ToList();

            return userInf;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------
        public async Task<string> saveSession(List<Users> userInf, string IdSession, int tipoCuenta, bool status)
        {
            string Result = null;

            var insert = _appContext.Database.CreateExecutionStrategy();
            await insert.ExecuteAsync(async () =>
            {
                using (var transaction = _appContext.Database.BeginTransaction())
                {
                    try
                    {
                        var dataUser = new Users();
                        if (!userInf.Count.Equals(0))
                        {
                            dataUser.Id_Usuario = userInf.First().Id_Usuario;
                            dataUser.Usuario = userInf.First().Usuario;
                        }

                        var userSesion = new Users_ValidationSession
                        {
                            IDSesion = IdSession,
                            UsuarioId = dataUser.Id_Usuario,
                            Usuario = dataUser.Usuario,
                            TipoSesion = tipoCuenta,
                            FechaReg = DateTime.Now,
                            Status = status,
                        };
                        await _appContext.AddAsync(userSesion);
                        _appContext.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Result = "An error occurred on the server, please try again later or contac the admin.";
                        transaction.Rollback();
                    }
                }
            });
            return Result;
        }

        public async Task<string> closeSession(List<Users_ValidationSession> userSession)
        {
            string Result = null;

            foreach (var item in userSession)
            {
                var update = _appContext.Database.CreateExecutionStrategy();
                await update.ExecuteAsync(async () =>
                {
                    using (var transaction = _appContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var dataSession = item;
                            dataSession.Status = false;
                            dataSession.FechaCierreSesion = DateTime.Now;

                            _appContext.Update(dataSession);
                            _appContext.SaveChanges();

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            Result = "An error occurred on the server, please try again later or contac the admin.";
                            transaction.Rollback();
                        }
                    }
                });
            }
            return (Result);

        }
    }
}
