using System.Security.Cryptography;


namespace variables.Models
{
    public class ClientesModel
    {
        public int Id { get; set; }
        public string Cedula_Ruc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //propiedades opcionales
        public int? Edad { get; set; }
        public bool Genero { get; set; } = false;
        public DateOnly? Fecha_Nacimiento { get; set; } 

        //DateTime=> 2025/02/17
        //Date => 2025-02-17
        //Time 

    }
}
/*
 * 
 * Abstracion=> 
 * herencia => hereda propiedades y metodos de una clase padre hereda con :
 * Polimorfismo=> Sobre carga de metodos
 * 
 * Cuanto una clase se transforma en objeto
 * cuando se crea una instancia
  */