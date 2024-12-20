using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuApp.Entities
{
    public class UserSession
    {
        public static long Id { get; set; }
        public static string? KullaniciAdi { get; set; }
        public static string? KimlikNo { get; set; }
        public static string? Adi { get; set; }
        public static string? Soyadi { get; set; }
        public static string? EPosta { get; set; }
        public static string? GSM { get; set; }
    }
}
