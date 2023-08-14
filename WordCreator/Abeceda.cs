using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCreator
{
    internal class Abeceda
    {

        string vybranepismena;

        public int PocetPismen
        {
            get; set;
        }


        public Abeceda(int pocetpismen)
        {
            PocetPismen = pocetpismen;
        }

        

        public string Vybranepismena()
        {
            char[] Abc = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

            Random random = new Random();


            for (int i = 0; i < PocetPismen; i++)
            {
                //zaujimave ze tu to nepadne, vybranepismena je null pri prvom calle
                vybranepismena += Abc[random.Next(Abc.Length)]; 
            }
            // skor vracaj vybranepismena, posielaj ich do generatora niekde v hlavnej metode
            Generator generator = new Generator();

            return generator.Input(vybranepismena) ;
        }

        
    }

}













