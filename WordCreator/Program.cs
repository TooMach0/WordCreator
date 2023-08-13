using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCreator;

namespace WordCreator
{
    class Program
    {

        static void Main(string[] args)
        {

            Abeceda Abeceda = new Abeceda(4);
            Generator Generator = new Generator();

            Generator.Input(Abeceda.Vybranepismena());
            

        }
    }
}