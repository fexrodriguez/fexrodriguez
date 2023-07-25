using FactoryPlatform.Areas.Administrator.Models;
using FactoryPlatform.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPlatform.Library
{
    public class LAdministrator : ListObjects
    {
        public LAdministrator(LKQMXFPAPPContext fpContext)
        {
            _fpContext = fpContext;
        }

        public List<SelectListItem> GetProductionDepartments()
        {
            List<SelectListItem> _selectLists = new List<SelectListItem>();
            var productionDepartments = _fpContext.ProductionDepartments.Where(PD => PD.Status.Equals(true)).Select(PD => new
            {
                PD.IdDepartamento,
                Departamento = ("(" + PD.Clave + ") " + PD.Departamento)
            }).AsNoTracking().ToList();
            productionDepartments.ForEach(item =>
            {
                _selectLists.Add(new SelectListItem
                {
                    Value = item.IdDepartamento.ToString(),
                    Text = item.Departamento.ToUpper()
                });
            });
            return _selectLists;
        }

        public List<SelectListItem> GetDepartments()
        {
            List<SelectListItem> _selectList = new List<SelectListItem>();
            var departments = _fpContext.Departments.Where(D => D.Status.Equals(true)).Select(D => new
            {
                D.IdDepartamento,
                D.Departamento
            }).AsNoTracking().ToList();
            departments.ForEach(item =>
            {
                _selectList.Add(new SelectListItem
                {
                    Value = item.IdDepartamento.ToString(),
                    Text = item.Departamento.ToUpper()
                });
            });

            return _selectList;
        }

        public List<SelectListItem> GetUsersJobs()
        {
            List<SelectListItem> _selectList = new List<SelectListItem>();
            var userJobs = _fpContext.UsersJobs.Select(UJ => new { UJ.IdPuestoTrabajo, UJ.Descripcion }).OrderBy(UJ => UJ.Descripcion).AsNoTracking().ToList();
            userJobs.ForEach(item =>
            {
                _selectList.Add(new SelectListItem
                {
                    Value = item.IdPuestoTrabajo.ToString(),
                    Text = item.Descripcion.ToUpper()
                });
            });
            return _selectList;
        }


        //Pasar todo esto a un store
        public List<UsersModel> GetUsers(int status, int producDepart)
        {
            var personalList = new List<UsersModel>();

            if (status == 0 && producDepart == 0)
            {
                var userData = (from user in _fpContext.Users
                                join Dep in _fpContext.Departments on user.DepartamentoId equals Dep.IdDepartamento
                                join ProdDep in _fpContext.ProductionDepartments.Where(PD => PD.Status == true) on user.DepartamentoProduccionId equals ProdDep.IdDepartamento
                                join UJ in _fpContext.UsersJobs.Where(UJ => UJ.Status == true) on user.PuestoId equals UJ.IdPuestoTrabajo
                                select new
                                {
                                    user.IdUsuario,
                                    user.Usuario,
                                    user.Nombres,
                                    user.ApellidoPaterno,
                                    user.ApellidoMaterno,
                                    user.NoEmpleado,
                                    user.Correo,
                                    user.Imagen,
                                    user.Status,
                                    user.DepartamentoId,
                                    Dep.Departamento,
                                    user.PuestoId,
                                    UJ.Descripcion,
                                }).AsNoTracking().ToList();
                if (!userData.Count.Equals(0))
                {
                    foreach (var item in userData)
                    {
                        personalList.Add(new UsersModel
                        {
                            IdUsuario = item.IdUsuario,
                            Usuario = item.Usuario,
                            NoEmpleado = item.NoEmpleado,
                            Nombres = item.Nombres,
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            Correo = item.Correo,
                            DepartamentoId = item.DepartamentoId,
                            Departamento = item.Departamento,
                            PuestoId = item.PuestoId,
                            Descripcion = item.Descripcion,
                            Status = item.Status,
                            Image = item.Imagen
                        });
                    }
                }
            }
            
            else if (status == 1 && producDepart == 0)
            {
                var userData = (from user in _fpContext.Users.Where(U => U.Status == true)
                                join Dep in _fpContext.Departments on user.DepartamentoId equals Dep.IdDepartamento
                                join ProdDep in _fpContext.ProductionDepartments.Where(PD => PD.Status == true) on user.DepartamentoProduccionId equals ProdDep.IdDepartamento
                                join UJ in _fpContext.UsersJobs.Where(UJ => UJ.Status == true) on user.PuestoId equals UJ.IdPuestoTrabajo
                                select new
                                {
                                    user.IdUsuario,
                                    user.Usuario,
                                    user.Nombres,
                                    user.ApellidoPaterno,
                                    user.ApellidoMaterno,
                                    user.NoEmpleado,
                                    user.Correo,
                                    user.Imagen,
                                    user.Status,
                                    user.DepartamentoId,
                                    Dep.Departamento,
                                    user.PuestoId,
                                    UJ.Descripcion,
                                }).AsNoTracking().ToList();
                if (!userData.Count.Equals(0))
                {
                    foreach (var item in userData)
                    {
                        personalList.Add(new UsersModel
                        {
                            IdUsuario = item.IdUsuario,
                            Usuario = item.Usuario,
                            NoEmpleado = item.NoEmpleado,
                            Nombres = item.Nombres,
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            Correo = item.Correo,
                            DepartamentoId = item.DepartamentoId,
                            Departamento = item.Departamento,
                            PuestoId = item.PuestoId,
                            Descripcion = item.Descripcion,
                            Status = item.Status,
                            Image = item.Imagen
                        });
                    }
                }
            }
            else if (status == 1 && producDepart > 0)
            {
                var userData = (from user in _fpContext.Users.Where(U => U.Status == true)
                                join Dep in _fpContext.Departments on user.DepartamentoId equals Dep.IdDepartamento
                                join ProdDep in _fpContext.ProductionDepartments.Where(PD => PD.Status == true && PD.IdDepartamento == producDepart) on user.DepartamentoProduccionId equals ProdDep.IdDepartamento
                                join UJ in _fpContext.UsersJobs.Where(UJ => UJ.Status == true) on user.PuestoId equals UJ.IdPuestoTrabajo
                                select new
                                {
                                    user.IdUsuario,
                                    user.Usuario,
                                    user.Nombres,
                                    user.ApellidoPaterno,
                                    user.ApellidoMaterno,
                                    user.NoEmpleado,
                                    user.Correo,
                                    user.Imagen,
                                    user.Status,
                                    user.DepartamentoId,
                                    Dep.Departamento,
                                    user.PuestoId,
                                    UJ.Descripcion,
                                }).AsNoTracking().ToList();
                if (!userData.Count.Equals(0))
                {
                    foreach (var item in userData)
                    {
                        personalList.Add(new UsersModel
                        {
                            IdUsuario = item.IdUsuario,
                            Usuario = item.Usuario,
                            NoEmpleado = item.NoEmpleado,
                            Nombres = item.Nombres,
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            Correo = item.Correo,
                            DepartamentoId = item.DepartamentoId,
                            Departamento = item.Departamento,
                            PuestoId = item.PuestoId,
                            Descripcion = item.Descripcion,
                            Status = item.Status,
                            Image = item.Imagen
                        });
                    }
                }
            }
            else if (status == 2 && producDepart != 0)
            {
                var userData = (from user in _fpContext.Users.Where(U => U.Status == false)
                                join Dep in _fpContext.Departments on user.DepartamentoId equals Dep.IdDepartamento
                                join ProdDep in _fpContext.ProductionDepartments.Where(PD => PD.Status == true && PD.IdDepartamento == producDepart) on user.DepartamentoProduccionId equals ProdDep.IdDepartamento
                                join UJ in _fpContext.UsersJobs on user.PuestoId equals UJ.IdPuestoTrabajo
                                select new
                                {
                                    user.IdUsuario,
                                    user.Usuario,
                                    user.Nombres,
                                    user.ApellidoPaterno,
                                    user.ApellidoMaterno,
                                    user.NoEmpleado,
                                    user.Correo,
                                    user.Imagen,
                                    user.Status,
                                    user.DepartamentoId,
                                    Dep.Departamento,
                                    user.PuestoId,
                                    UJ.Descripcion,
                                }).AsNoTracking().ToList();

                if (!userData.Count.Equals(0))
                {
                    foreach (var item in userData)
                    {
                        personalList.Add(new UsersModel
                        {
                            IdUsuario = item.IdUsuario,
                            Usuario = item.Usuario,
                            NoEmpleado = item.NoEmpleado,
                            Nombres = item.Nombres,
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            Correo = item.Correo,
                            DepartamentoId = item.DepartamentoId,
                            Departamento = item.Departamento,
                            PuestoId = item.PuestoId,
                            Descripcion = item.Descripcion,
                            Status = item.Status,
                            Image = item.Imagen
                        });
                    }
                }
            }
            else if (status == 2 && producDepart == 0)
            {
                var userData = (from user in _fpContext.Users.Where(U => U.Status == false)
                                join Dep in _fpContext.Departments on user.DepartamentoId equals Dep.IdDepartamento
                                join ProdDep in _fpContext.ProductionDepartments.Where(PD => PD.Status == true) on user.DepartamentoProduccionId equals ProdDep.IdDepartamento
                                join UJ in _fpContext.UsersJobs on user.PuestoId equals UJ.IdPuestoTrabajo
                                select new
                                {
                                    user.IdUsuario,
                                    user.Usuario,
                                    user.Nombres,
                                    user.ApellidoPaterno,
                                    user.ApellidoMaterno,
                                    user.NoEmpleado,
                                    user.Correo,
                                    user.Imagen,
                                    user.Status,
                                    user.DepartamentoId,
                                    Dep.Departamento,
                                    user.PuestoId,
                                    UJ.Descripcion,
                                }).AsNoTracking().ToList();

                if (!userData.Count.Equals(0))
                {
                    foreach (var item in userData)
                    {
                        personalList.Add(new UsersModel
                        {
                            IdUsuario = item.IdUsuario,
                            Usuario = item.Usuario,
                            NoEmpleado = item.NoEmpleado,
                            Nombres = item.Nombres,
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            Correo = item.Correo,
                            DepartamentoId = item.DepartamentoId,
                            Departamento = item.Departamento,
                            PuestoId = item.PuestoId,
                            Descripcion = item.Descripcion,
                            Status = item.Status,
                            Image = item.Imagen
                        });
                    }
                }
            }
            else if (status == 0 && producDepart > 0)
            {
                var userData = (from user in _fpContext.Users
                                join Dep in _fpContext.Departments on user.DepartamentoId equals Dep.IdDepartamento
                                join ProdDep in _fpContext.ProductionDepartments.Where(PD => PD.Status == true && PD.IdDepartamento == producDepart) on user.DepartamentoProduccionId equals ProdDep.IdDepartamento
                                join UJ in _fpContext.UsersJobs on user.PuestoId equals UJ.IdPuestoTrabajo
                                select new
                                {
                                    user.IdUsuario,
                                    user.Usuario,
                                    user.Nombres,
                                    user.ApellidoPaterno,
                                    user.ApellidoMaterno,
                                    user.NoEmpleado,
                                    user.Correo,
                                    user.Imagen,
                                    user.Status,
                                    user.DepartamentoId,
                                    Dep.Departamento,
                                    user.PuestoId,
                                    UJ.Descripcion,
                                }).AsNoTracking().ToList();

                if (!userData.Count.Equals(0))
                {
                    foreach (var item in userData)
                    {
                        personalList.Add(new UsersModel
                        {
                            IdUsuario = item.IdUsuario,
                            Usuario = item.Usuario,
                            NoEmpleado = item.NoEmpleado,
                            Nombres = item.Nombres,
                            ApellidoPaterno = item.ApellidoPaterno,
                            ApellidoMaterno = item.ApellidoMaterno,
                            Correo = item.Correo,
                            DepartamentoId = item.DepartamentoId,
                            Departamento = item.Departamento,
                            PuestoId = item.PuestoId,
                            Descripcion = item.Descripcion,
                            Status = item.Status,
                            Image = item.Imagen
                        });
                    }
                }
            }

            return personalList;
        }

    }
}
