using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Mota
    {
        string marca; string modelo; string cor; 
        string numChassis; string estilo; string kms; string matricula; string cilindrada;
        string preco; string estado;


        private static int autoID;
        protected int ID;

        //1ª coluna
        public int ValorID
        {
            get { return ID; }
        }

        //2ª coluna
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        //3ª coluna
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        //4ª coluna
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Kms
        {
            get { return kms; }
            set { kms = value; }
        }

        public string CC
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Chassis
        {
            get { return numChassis; }
            set { numChassis = value; }
        }


        public Mota(string _marca, string _modelo, string _estilo, 
            string _kms, string _matricula, string _cilindrada, 
            string _preco, string _estado, string _cor, string _numchassis)
        {
            ID = ++autoID;

            marca = _marca;
            modelo = _modelo;
            estilo = _estilo;
            kms = _kms;
            matricula = _matricula;
            cilindrada = _cilindrada;
            preco = _preco;
            estado = _estado;
            cor = _cor;
            numChassis = _numchassis;
        }

        public static List<string> marcaMota = new List<string>()
        {
            "Honda",
            "BWM",
            "Yamaha",
            "Ducati",
            "Aprilia",
            "Kawasaki",
            "Harley",
            "Keeway",
            "Benelli",
            "Suzuki",
            "KTM",
            "Indian"
        };

        public static List<string> estadoMota = new List<string>()
        {
            "Nova",
            "Usada",
            "Sucata"
        };

        public static List<string> corMota = new List<string>()
        {
            "Vermelho",
            "Azul",
            "Preto",
            "Branco",
            "Verde",
            "Laranja",
            "Amarelo"
        };

        public static List<string> estiloMota = new List<string>()
        {
            "Big Trail",
            "Enduro",
            "Cross",
            "Naked",
            "Pista",
            "Café Racer",
            "Voyager",
        };

        public static List<string> combustivelMota = new List<string>()
        {
            "Gasolina",
            "Elétrico",
            "Diesel",
        };
    }
}
