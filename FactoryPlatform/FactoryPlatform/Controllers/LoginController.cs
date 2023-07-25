using FactoryPlatform.Library;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FactoryPlatform.Helper;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using FactoryPlatform.Data;

namespace FactoryPlatform.Controllers
{
    public class LoginController : Controller
    {
        private readonly LValidationLogin _lValidationLogin;
        private string scheme;
        public LoginController(ApplicationDbContext context)
        {
            _lValidationLogin = new LValidationLogin(context);

        }

        public async Task<IActionResult> Index()
        {
            var user = User.Identity.Name;
            var idCockieActive = Request.Headers.Values;

            if (User.Identity.IsAuthenticated)
            {
                var sessionHash = CookieHelper.GetSessionHash(User);
                var sessionOld = _lValidationLogin.checkSessionBySessionIdOld(sessionHash);
                var empyTable = _lValidationLogin.checkAllSession();

                var usuario = CookieHelper.GetUsuario(User);
                var dataUser1 = _lValidationLogin.infoUserByCorreo(user);
                var dataUser2 = _lValidationLogin.infoUserIdentify(usuario);
                var dataUserDisable = _lValidationLogin.infoUserDisableByCorreo(user);
                var dataUserDisableLocal = _lValidationLogin.infoUserDisableIdentify(usuario);

                if (user.Contains("@") && dataUser1.Count == 0)
                {
                    var sessionDisable = _lValidationLogin.checkSession(dataUserDisable.First().Usuario);

                    if (sessionDisable.Count > 0)
                    {
                        await _lValidationLogin.closeSession(sessionDisable);
                    }
                    await HttpContext.SignOutAsync();
                    return Redirect("/FactoryPlatform");
                }
                else if (dataUser2.Count == 0 && dataUser1.Count == 0)
                {
                    var sessionDisable = _lValidationLogin.checkSession(dataUserDisableLocal.First().Usuario);

                    if (!sessionDisable.Count.Equals(0))
                    {
                        await _lValidationLogin.closeSession(sessionDisable);
                    }
                    await HttpContext.SignOutAsync();
                    return Redirect("/FactoryPlatform");
                }

                var existSession = user.Contains("@") ? _lValidationLogin.checkSession(dataUser1.First().Usuario)
                : _lValidationLogin.checkSession(dataUser2.First().Usuario);

                if (existSession.Count > 0)
                {
                    if (sessionHash == existSession.First().IDSesion)
                    {
                        return Redirect("/FactoryPlatform/Home/SystemHost");
                    }
                    else if (user.Contains("@"))
                    {
                        if (sessionOld.Count > 0)
                        {
                            if (sessionHash == sessionOld.First().IDSesion && sessionOld.First().Status.Equals(false))
                            {
                                await HttpContext.SignOutAsync();
                                return Redirect("/FactoryPlatform");
                            }
                        }
                        else
                        {
                            await _lValidationLogin.closeSession(existSession);
                            await _lValidationLogin.saveSession(_lValidationLogin.infoUserByCorreo(user), sessionHash, 2, true);
                            return Redirect("/FactoryPlatform/Home/SystemHost");
                        }
                    }
                    else
                    {
                        await HttpContext.SignOutAsync();
                        return Redirect("/FactoryPlatform");
                    }
                }
                else
                {
                    if (user.Contains("@"))
                    {
                        if (sessionOld.Count > 0)
                        {
                            if (sessionHash == sessionOld.First().IDSesion && sessionOld.First().Status.Equals(false))
                            {
                                await HttpContext.SignOutAsync();
                                return Redirect("/FactoryPlatform");
                            }
                        }
                        else
                        {
                            if (empyTable.Count > 0)
                            {
                                await _lValidationLogin.saveSession(_lValidationLogin.infoUserByCorreo(user), sessionHash, 2, true);
                                return Redirect("/FactoryPlatform/Home/SystemHost");
                            }
                            else
                            {
                                if (idCockieActive.Count > 15)
                                {
                                    await _lValidationLogin.saveSession(_lValidationLogin.infoUserByCorreo(user), sessionHash, 2, true);
                                    return Redirect("/FactoryPlatform/Home/SystemHost");
                                }
                                else
                                {
                                    await HttpContext.SignOutAsync();
                                    return Redirect("/FactoryPlatform");
                                }
                            }
                        }
                    }
                    else
                    {
                        await HttpContext.SignOutAsync();
                        return Redirect("/FactoryPlatform");
                    }
                }

            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Index([Bind("Usuario, PasswordHash")] LoginViewModel model)
        {
            var result = _lValidationLogin.validateUserPassword(model);

            if (result == null)
            {
                var existSession = _lValidationLogin.checkSession(model.Usuario);

                if (existSession.Count.Equals(0))
                {
                    var correctCookie = await createCookie(model);

                    if (correctCookie == null)
                    {
                        return Redirect("/FactoryPlatform/Home/SystemHost");
                    }
                    else
                    {
                        ViewBag.Error = correctCookie;
                        return View();
                    }
                }
                else
                {
                    var correcClose = await _lValidationLogin.closeSession(existSession);

                    var correctCookie = await createCookie(model);

                    if (correctCookie == null && correctCookie == null)
                    {
                        return Redirect("/FactoryPlatform/Home/SystemHost");
                    }
                    else
                    {
                        ViewBag.Error = correcClose != null ? correctCookie : correcClose;
                        return View();
                    }
                }
            }
            else
            {
                ViewBag.Error = "Please check the information.";
            }
            return View();
        }

        //save session
        public async Task<string> createCookie(LoginViewModel model)
        {
            string Result = null;
            var IdSession = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

            //Create the cookie
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            identity.AddClaim(new Claim("uti", IdSession));
            identity.AddClaim(new Claim("Usuario", model.Usuario));
            identity.AddClaim(new Claim(ClaimTypes.Name, ""));

            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
            new AuthenticationProperties { ExpiresUtc = DateTime.Now.AddHours(10), IsPersistent = true });
            //------------------------------------------------------------------------------------------------------------------------

            //Save the session in the DataBase
            Result = await _lValidationLogin.saveSession(_lValidationLogin.infoUserIdentify(model.Usuario), IdSession, 1, true);

            return Result;
        }


        [Authorize]
        public async Task<IActionResult> Logout()
        {
            var user = User.Identity.Name;
            var sessionId = CookieHelper.GetSessionHash(User);
            var existSession = _lValidationLogin.checkSessionBySessionId(sessionId);

            if (!existSession.Count.Equals(0))
            {
                await _lValidationLogin.closeSession(existSession);
            }

            await HttpContext.SignOutAsync();

            if (user.Contains("@"))
            {
                return SignOut(
                new AuthenticationProperties
                {
                    RedirectUri = "/FactoryPlatform",
                },
                CookieAuthenticationDefaults.AuthenticationScheme, scheme ??= OpenIdConnectDefaults.AuthenticationScheme);
            }

            return Redirect("/FactoryPlatform");
        }

    }
}
