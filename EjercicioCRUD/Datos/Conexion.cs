using System.Data.SqlClient;
namespace EjercicioCRUD.Datos
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;
        public Conexion() {
            //obtener cadena de conexion de appsettings la cual fue declarada al inicio del proyecto
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }
        public string getCadenaSQL()
        {
            return cadenaSQL;
        }
    }
}
