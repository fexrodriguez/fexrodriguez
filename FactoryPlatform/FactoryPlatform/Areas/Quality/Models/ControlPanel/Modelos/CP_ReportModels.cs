using FactoryPlatform.Data;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos
{
    public class CP_ReportModels
    {

        [Key]
        public int? ID_Modelo { get; set; }
        public string? Modelo { get; set; }
        public string? Descripcion  {get; set;}
        public string? VegeCode  {get; set;}
        public string? FechaRegistro    {get; set;}
        public string? UsuarioRegistro  {get; set;}
        public string? FechaUltimaActualizacion     {get; set;}
        public string? UsuarioUltimaActualizacion  {get; set;}
        public string? Familia  {get; set;}
        public string? DescripcionComponente  {get; set;}
        public string? Prueba   {get; set;}
        public string? Status  {get; set;}
        public string? PackagingType    {get; set;}
        public string? Linea  {get; set;}
        public string? Celda    {get; set;}
        public string? Huacal  {get; set;}
        public string? Tub_Insert   {get; set;}
        public string? Tub_Insert_Wood  {get; set;}
        public string? Tub_Base     {get; set;}
        public string? Tub_Tapa {get; set;}

        //public int? ID_Modelo {get; set;}
        //public string? Modelo    {get; set;}
        //public string? Descripcion {get; set;}
        //public string? FamiliaID    {get; set;}
        //public string? Linea {get; set;}
        //public string? ComponenteID    {get; set;}
        //public string? PruebaID {get; set;}
        //public string? Status    {get; set;}
        //public string? VegeCode {get; set;}
        //public string? PlantaID    {get; set;}
        //public string? FechaRegistro {get; set;}
        //public string? UsuarioRegistroID    {get; set;}
        //public string? FechaUltimaActualizacion {get; set;}
        //public string? UsuarioUltimaActualizacionID    {get; set;}
        //public string? EmbalajeID {get; set;}
        //public string? HuacalID    {get; set;}
        //public string? TUBInsertoID {get; set;}
        //public string? TUBInsertoMaderaID    {get; set;}
        //public string? TUBTapaID {get; set;}
        //public string? TUBBaseID    {get; set;}
        //public string? CargaSyteLine {get; set;}
        //public string? UsuarioRegistro    {get; set;}
        //public string? UsuarioUltimaActualizacion {get; set;}
        //public string? Prueba    {get; set;}
        //public string? PackagingType {get; set;}
        //public string? Familia    {get; set;}
        //public string? Celda {get; set;}
        //public string? DescripcionComponente    {get; set;}
        //public string? Huacal {get; set;}
        //public string? Tub_Insert    {get; set;}
        //public string? Tub_Insert_Wood {get; set;}
        //public string? Tub_Base    {get; set;}

        //public string? Tub_Tapa {get; set;}
        //public int? Status { get; set; }





    }
}
