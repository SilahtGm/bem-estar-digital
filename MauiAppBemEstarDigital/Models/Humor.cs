using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBemEstarDigital.Models
{
    public class Humor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int U_Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Data_humor { get; set; }

        public string Emoji { get; set; }
    }
}
