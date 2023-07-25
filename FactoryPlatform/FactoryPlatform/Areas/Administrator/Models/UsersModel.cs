namespace FactoryPlatform.Areas.Administrator.Models
{
    public class UsersModel
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string NoEmpleado { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public int DepartamentoId { get; set; }
        public string Departamento { get; set; }
        public int? PuestoId { get; set; }
        public string Descripcion { get; set; }
        public bool? Status { get; set; }
        public string Image { get; set; }
    }
}
