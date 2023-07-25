using FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using FactoryPlatform.Data.AppDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using System.Net;
using Azure.Core;
using FactoryPlatform.Models;

namespace FactoryPlatform.Library.Quality.ControlPanel
{
	public class LModelFeature_CP : ListObjects
	{
        public LModelFeature_CP(StoresProceduresDbContext spContext)
        {
            _SpContext = spContext;
        }

        public CP_ModelFeaturesViewModel ModelFeaturesInf(int UserID, int PlantaID)
        {
            var model = new CP_ModelFeaturesViewModel();


            var stations = _SpContext.SelectOptionsModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
            "@Operacion=@Operacion, @Opcion =@Opcion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID ",
            new object[]
            {
                new SqlParameter("Operacion", 1),   
                new SqlParameter("Opcion", 12),
                new SqlParameter("UsuarioID", UserID),
                new SqlParameter("PlantaID", PlantaID),
            }).AsNoTracking().ToList();

            if (stations.Any())
            {
                stations.ForEach(item =>
                {
                    model.Quality_Workstations.Add(new SelectListItem
                    {
                        Value = item.ID.ToString(),
                        Text = item.Descripcion.ToString()
                    });
                });
            }


            return model;
        }

        public List<CP_Q_ModelFeature> SearchModel(string modelo, int estacion, int UserID, int PlantaID)
        {
            var error = "";
            var query = new List<CP_Q_ModelFeature>();

            try
            {
                query = _SpContext.CP_Q_ModelFeature.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@EstacionID = @EstacionID, @Modelo = @Modelo ",
               new object[]
               {
                    new SqlParameter("Operacion", 7),
                    new SqlParameter("UsuarioID", UserID),
                    new SqlParameter("PlantaID", PlantaID),
                    new SqlParameter("EstacionID", estacion),
                    new SqlParameter("Modelo", modelo)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

           

            return query;
        }

        public List<CP_Q_ModelFeature> InsertFeature(int UserID, int PlantaID,
        string modelo, int estacion, string Title, string Description)
        {
            var error = "";
            var query = new List<CP_Q_ModelFeature>();

            try
            {
                 query = _SpContext.CP_Q_ModelFeature.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
                 "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
                 "@Opcion= @Opcion, @Modelo=@Modelo, " +
                 "@EstacionID=@EstacionID, @Titulo=@Titulo, @Descripcion=@Descripcion, ",
                 new object[]
                 {
                        new SqlParameter("Operacion", 8),
                        new SqlParameter("Opcion", 1),
                        new SqlParameter("UsuarioID", UserID),
                        new SqlParameter("PlantaID", PlantaID),
                        new SqlParameter("Modelo", modelo),
                        new SqlParameter("EstacionID", estacion),
                        new SqlParameter("Titulo", Title),
                        new SqlParameter("Descripcion", Description),
                 }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return query;
        }


       



    }
}
