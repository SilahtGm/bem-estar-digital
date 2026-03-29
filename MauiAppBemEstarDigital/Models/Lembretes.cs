using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBemEstarDigital.Models
{
    public class Lembrete
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int U_Id { get; set; }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public TimeSpan Horario { get; set; }
        public bool Ativo { get; set; }
    }

}
