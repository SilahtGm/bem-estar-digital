using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBemEstarDigital.Models
{
    internal class Humor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int U_Id { get; set; }

        public int nivel_humor { get; set; } // De 1 a 5, onde 1 é muito ruim e 5 é muito bom

        public string descricao { get; set; }

        public DateTime data_humor { get; set; }

        public string emoji { get; set; }
    }
}
