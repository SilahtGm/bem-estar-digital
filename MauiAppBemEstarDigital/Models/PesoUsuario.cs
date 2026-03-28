using SQLite;
using System;

namespace MauiAppBemEstarDigital.Models
{
    public class PesoUsuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

       
        public int U_Id { get; set; }

       
        public double Peso { get; set; }

       
        public double IMC { get; set; }

   
        public DateTime Data { get; set; }
    }
}