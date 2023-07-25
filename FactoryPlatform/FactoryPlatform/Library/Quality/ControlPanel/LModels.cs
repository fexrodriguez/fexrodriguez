using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using FactoryPlatform.Data;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FactoryPlatform.Library.Quality.ControlPanel
{
    public class LModels : ListObjects
    {
        public LModels(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        //======================================== Control Panel - Models ===============================================================
        public CP_ModelsModelView ModelsInf(int UserID, int PlantaID)
        { 
           var model = new CP_ModelsModelView();


           var cells  = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 1),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (cells.Any())
            {
                cells.ForEach(item =>
                {
                    model.Production_Cells.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }

            model.CP_Family = _SpContext.CP_ModelsFamily.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 2),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();


            //========================= Combos  new model ===============================================

            var status = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 3),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (status.Any())
            {
                status.ForEach(item =>
                {
                    model.Status.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }

           var component = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 4),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (component.Any())
            {
                component.ForEach(item =>
                {
                    model.Component.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }

           var proof = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 5),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (proof.Any())
            {
                proof.ForEach(item =>
                {
                    model.Proof.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }

           var packaging = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 6),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (packaging.Any())
            {
                packaging.ForEach(item =>
                {
                    model.Packaging.Add(new SelectListItem
                    {
                        Value = item.Valor.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }

           var huacal = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 7),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (huacal.Any())
            {
                huacal.ForEach(item =>
                {
                    model.Huacal.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }
            
            var plasticTub = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 8),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (plasticTub.Any())
            {
                plasticTub.ForEach(item =>
                {
                    model.TUBPlastic.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }
            
            var woodTub = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 9),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (woodTub.Any())
            {
                woodTub.ForEach(item =>
                {
                    model.TUBWood.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }
            
           var lidTub = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 10),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (lidTub.Any())
            {
                lidTub.ForEach(item =>
                {
                    model.TUBLid.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }
            
            var baseTub = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
           "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
           new object[]
           {
                new SqlParameter("Operacion", 1),
                new SqlParameter("Opcion", 11),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
           }).AsNoTracking().ToList();

            if (baseTub.Any())
            {
                baseTub.ForEach(item =>
                {
                    model.TUBBase.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }

            return model;
        }

    }
}
