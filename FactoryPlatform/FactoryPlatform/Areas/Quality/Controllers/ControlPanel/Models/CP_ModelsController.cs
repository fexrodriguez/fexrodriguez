using FactoryPlatform.Data.AppDbContext;
using FactoryPlatform.Data;
using FactoryPlatform.Library;
using Microsoft.AspNetCore.Mvc;
using FactoryPlatform.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using FactoryPlatform.Library.Quality.ControlPanel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using FactoryPlatform.Filter;
using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;

namespace FactoryPlatform.Areas.Quality.Controllers.ControlPanel.Models
{
    [Area("Quality")]
    [ServiceFilter(typeof(AuthorizeActionFilter), Order = 1)]
    public class CP_ModelsController : Controller
    {
        private LKQMXFPAPPContext _fpContext;
        private StoresProceduresDbContext _SpContext;
        private readonly LUsers _lUsers;
        private readonly LModels _lModels;

        public CP_ModelsController(LKQMXFPAPPContext fpContext, StoresProceduresDbContext spContext, ApplicationDbContext appContext)
        {
            _fpContext = fpContext;
            _SpContext = spContext;
            _lUsers = new LUsers(appContext);
            _lModels = new LModels(spContext);
        }

        //==================================================================================================================================
        //================================================ FAMILIES =====================================================
        //==================================================================================================================================
        public class ReturnInsert
        {
            public string Result { get; set; }
            public List<SelectListItem> ComboCells { get; set; } = new List<SelectListItem>();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveNewFamily(string Family, int CellId, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var model = new ReturnInsert();
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@StrFamilia = @StrFamilia, @CellID = @CellID ",
               new object[]
               {
                    new SqlParameter("Operacion", 2),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("StrFamilia", Family),
                    new SqlParameter("CellID", CellId)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    model.Result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                    model.ComboCells = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId).Production_Cells;

                    Json = JsonConvert.SerializeObject(model);
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult UpdateNewFamily(int FamilyId, string Family, int CellId,  int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var model = new ReturnInsert();
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@StrFamilia = @StrFamilia, @CellID = @CellID, @FamiliaID=@FamiliaID ",
               new object[]
               {
                    new SqlParameter("Operacion", 2),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("StrFamilia", Family),
                    new SqlParameter("CellID", CellId),
                    new SqlParameter("FamiliaID", FamilyId),
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    model.Result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                    model.ComboCells = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId).Production_Cells;

                    Json = JsonConvert.SerializeObject(model);
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult UpdateCellFamily(int FamilyId, int CellId, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var model = new ReturnInsert();
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@CellID = @CellID, @FamiliaID=@FamiliaID ",
               new object[]
               {
                    new SqlParameter("Operacion", 2),
                    new SqlParameter("Opcion", 3),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("CellID", CellId),
                    new SqlParameter("FamiliaID", FamilyId),
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    model.Result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Error";
                    model.ComboCells = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId).Production_Cells;

                    Json = JsonConvert.SerializeObject(model);
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteFamily(int FamilyId, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var model = new ReturnInsert();
            var query = new List<ExecuteStores>();

            try
            {
               query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@FamiliaID=@FamiliaID ",
               new object[]
               {
                    new SqlParameter("Operacion", 2),
                    new SqlParameter("Opcion", 4),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("FamiliaID", FamilyId),
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    model.Result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Error";
                    model.ComboCells = _lModels.ModelsInf(UserInfo.Id_Usuario, UserInfo.PlantaId).Production_Cells;

                    Json = JsonConvert.SerializeObject(model);
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


        //=========================================================END FAMILIES =============================================================


        //==================================================================================================================================
        //=========================================================START CELLS =============================================================
        //==================================================================================================================================
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveNewCell(string Cell, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@StrCell = @StrCell ",
               new object[]
               {
                    new SqlParameter("Operacion", 3),
                    new SqlParameter("Opcion", 1),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("StrCell", Cell)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult UpdateCell(string Cell, int CellId, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@StrCell = @StrCell, @CellID= @CellID ",
               new object[]
               {
                    new SqlParameter("Operacion", 3),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("StrCell", Cell),
                    new SqlParameter("CellID", CellId)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Result = query.First().Resultado == "Success" ? query.First().ID.ToString() : "Exists";
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteCell(int CellId, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@CellID= @CellID ",
               new object[]
               {
                    new SqlParameter("Operacion", 3),
                    new SqlParameter("Opcion", 3),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("CellID", CellId)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Result = query.First().Resultado;
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);
        }

        //=================================================END CELLS=================================================================================


        //==================================================================================================================================
        //=========================================================START MODELS=============================================================
        //==================================================================================================================================
        [ValidateAntiForgeryToken]
		[HttpPost]
		public IActionResult saveNewModel(string ModalModel, string ModalVegecode, string ModalDescription,
        int ModalFamily,string ModalCell,int ModalStatus, int NewQTYTemporal, string? NewDescripcionTemporal, 
        string? NewDescripcionCancelado, int Component, int Proof, int Packaging, int Huacal, int Inserto, 
        int InsertoMadera, int Tapa, int Base)
		{
			var UserInfo = _lUsers.getIdUser(User).First();

			var Result = "";
			var error = "";
			var query = new List<ExecuteStores>();

			try
			{
				query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
			   "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
			   "@Modelo=@Modelo,@Descripcion=@Descripcion,@VegeCode=@VegeCode,@FamiliaID=@FamiliaID,@ComponenteID=@ComponenteID, " +
			   "@HuacalID=@HuacalID,@PruebaID=@PruebaID,@EmbalajeID=@EmbalajeID,@TUBInsertoID=@TUBInsertoID,@TUBInsertoMaderaID=@TUBInsertoMaderaID, " +
			   "@TUBTapaID=@TUBTapaID,@TUBBaseID=@TUBBaseID,@QtyTemporal=@QtyTemporal,@DescDesaprobado=@DescDesaprobado,@DescTemporal=@DescTemporal,@Status=@Status ",
			   new object[]
			   {
					new SqlParameter("Operacion", 4),
					new SqlParameter("Opcion", 1),
					new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
					new SqlParameter("PlantaID", UserInfo.PlantaId),
					new SqlParameter("Modelo", ModalModel),
					new SqlParameter("Descripcion", ModalDescription),
					new SqlParameter("VegeCode", ModalVegecode),
					new SqlParameter("FamiliaID", ModalFamily),
					new SqlParameter("ComponenteID", Component),
					new SqlParameter("HuacalID", Huacal),
					new SqlParameter("PruebaID", Proof),
					new SqlParameter("EmbalajeID", Packaging),
					new SqlParameter("TUBInsertoID", Inserto),
					new SqlParameter("TUBInsertoMaderaID", InsertoMadera),
					new SqlParameter("TUBTapaID", Tapa),
					new SqlParameter("TUBBaseID", Base),
					new SqlParameter("QtyTemporal", NewQTYTemporal),
					new SqlParameter("DescDesaprobado", NewDescripcionCancelado==null?"-":NewDescripcionCancelado),
					new SqlParameter("DescTemporal", NewDescripcionTemporal==null?"-":NewDescripcionTemporal),
					new SqlParameter("Status", ModalStatus)

			   }).AsNoTracking().ToList();
			}
			catch (Exception ex)
			{
				error = ex.Message;
			}

			if (error == "")
			{
				if (query.Any())
				{
					Result = query.First().Resultado;
				}
			}
			else
			{
				Result = "Error";
			}

			return Ok(Result);
		}

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult UpdateModel(int ModeloID, string Model, string ModalVegecode, string ModalDescription,
        int ModalFamily, string ModalCell, int ModalStatus, int NewQTYTemporal, string? NewDescripcionTemporal,
        string? NewDescripcionCancelado, int Component, int Proof, int Packaging, int Huacal, int Inserto,
        int InsertoMadera, int Tapa, int Base)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@ModeloID=@ModeloID, " +
               "@Modelo=@Modelo, " +
               "@Descripcion=@Descripcion," +
               "@VegeCode=@VegeCode, " +
               "@FamiliaID=@FamiliaID, " +
               "@ComponenteID=@ComponenteID, " +
               "@HuacalID=@HuacalID, " +
               "@PruebaID=@PruebaID, " +
               "@EmbalajeID=@EmbalajeID, " +
               "@TUBInsertoID=@TUBInsertoID, " +
               "@TUBInsertoMaderaID=@TUBInsertoMaderaID, " +
               "@TUBTapaID=@TUBTapaID, " +
               "@TUBBaseID=@TUBBaseID, " +
               "@QtyTemporal=@QtyTemporal, " +
               "@DescDesaprobado=@DescDesaprobado, " +
               "@DescTemporal=@DescTemporal, " +
               "@Status=@Status ",
               new object[]
               {
                    new SqlParameter("Operacion", 4),
                    new SqlParameter("Opcion", 2),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("ModeloID", ModeloID),
                    new SqlParameter("Modelo", Model),
                    new SqlParameter("Descripcion", ModalDescription),
                    new SqlParameter("VegeCode", ModalVegecode == null ? "-" : ModalVegecode),
                    new SqlParameter("FamiliaID", ModalFamily),
                    new SqlParameter("ComponenteID", Component),
                    new SqlParameter("HuacalID", Huacal),
                    new SqlParameter("PruebaID", Proof),
                    new SqlParameter("EmbalajeID", Packaging),
                    new SqlParameter("TUBInsertoID", Inserto),
                    new SqlParameter("TUBInsertoMaderaID", InsertoMadera),
                    new SqlParameter("TUBTapaID", Tapa),
                    new SqlParameter("TUBBaseID", Base),
                    new SqlParameter("QtyTemporal", NewQTYTemporal),
                    new SqlParameter("DescDesaprobado", NewDescripcionCancelado==null?"-":NewDescripcionCancelado),
                    new SqlParameter("DescTemporal", NewDescripcionTemporal==null?"-":NewDescripcionTemporal),
                    new SqlParameter("Status", ModalStatus)

               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Result = query.First().Resultado;
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult DeleteModel(int ModelId, int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Result = "";
            var error = "";
            var query = new List<ExecuteStores>();

            try
            {
                query = _SpContext.ExecStores.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, @Opcion=@Opcion, " +
               "@ModeloID= @ModeloID ",
               new object[]
               {
                    new SqlParameter("Operacion", 4),
                    new SqlParameter("Opcion", 3),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("ModeloID", ModelId)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Result = query.First().Resultado;
                }
            }
            else
            {
                Result = "Error";
            }

            return Ok(Result);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult ReportModel(int IdFamily, string? Modelo,int Type , int IdSeccion)
        {
            var UserInfo = _lUsers.getIdUser(User).First();

            var Json = "";
            var error = "";
            var query = new List<CP_ReportModels>();

            try
            {
                var Operacion = 0;
                if(Type == 1)
                {
                    Operacion = 5;
                } else{
                    Operacion = 6;
                }
                query = _SpContext.CP_ReportModels.FromSqlRaw("EXEC spFPAPP_Quality_Models " +
               "@Operacion=@Operacion, @UsuarioID=@UsuarioID, @PlantaID=@PlantaID, " +
               "@FamiliaID = @FamiliaID, @Modelo = @Modelo ",
               new object[]
               {
                    new SqlParameter("Operacion", Operacion),
                    new SqlParameter("UsuarioID", UserInfo.Id_Usuario),
                    new SqlParameter("PlantaID", UserInfo.PlantaId),
                    new SqlParameter("FamiliaID", IdFamily),
                    new SqlParameter("Modelo", Modelo == null ? "-" :  Modelo)
               }).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
            {
                if (query.Any())
                {
                    Json = JsonConvert.SerializeObject(query);
                }
                else
                {
                    Json = "NoData";
                }
            }
            else
            {
                Json = "Error";
            }

            return Ok(Json);
        }


    }
}
