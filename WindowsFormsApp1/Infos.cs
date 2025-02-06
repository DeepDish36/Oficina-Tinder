using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Infos
    {
        public static BindingList<Mota> ListaMotas = new BindingList<Mota>();

        public static string nomeApp ="Oficina Tinder"; 
        public static string versApp="Vers. 1.0";
        
        static Infos()
        {
            ListaMotas.Add(new Mota("Honda", "CBR-650", "Naked", "2500", "09-LL-92", "650", "7600", "Usada", "Preto", "02AC"));
            ListaMotas.Add(new Mota("Yamaha", "MT-07", "Naked", "3000", "12-XY-34", "689", "12000", "Usada", "Azul", "19YZ"));
            ListaMotas.Add(new Mota("Suzuki", "GSX-R750", "Sport", "4500", "34-AB-56", "750", "18000", "Nova", "Vermelho", "34SU"));
            ListaMotas.Add(new Mota("Kawasaki", "Ninja 400", "Sport", "3200", "78-CD-90", "399", "5000", "Usada", "Verde", "40KA"));
        }
    }
}
