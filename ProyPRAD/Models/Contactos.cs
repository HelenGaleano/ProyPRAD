using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyPRAD.Models
{
    internal class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }

        [MaxLength(15)]
        public string telefono { get; set; }

        public DateTime fechanac { get; set; }
        public string parentesco { get; set; }
        public byte[] foto { get; set; }

        [MaxLength(100)]
        public string pais { get; set; }
    }
}
