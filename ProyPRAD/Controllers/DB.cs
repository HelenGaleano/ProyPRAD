using System;
using System.Collections.Generic;
using System.Text;
using ProyPRAD.Models;
using ProyPRAD.Controllers;
using SQLite;
using System.Threading.Tasks;

namespace ProyPRAD.Controllers
{
    public static class DB
    {
        public static SQLiteAsyncConnection dbconexion;

        //Procedimiento Estatico
        public static void conexion(string dbpat)
        {
            dbconexion = new SQLiteAsyncConnection(dbpat);

            //Procedemos a crear las tablas de la base de datos
            dbconexion.CreateTableAsync<Contactos>();
        }
            
    }
}
