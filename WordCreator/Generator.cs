using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCreator
{
    internal class Generator
    {
        public string Input(string pismena)
        {
            ZoznamSlov zoznamSlov = new ZoznamSlov();

            
            List<string> SlovaVDlzkePismen = new List<string> ();

            //keby zoznamSlov.Slova() bola narocna metoda, abo by isla do db, taketo opatovne volanie je zle, mal by si ju zavolat raz a ulozit si jej vystup niekde, zbytocne ju volat zakazdym
            for (int i = 0; i < zoznamSlov.Slova().Count; i++)
            {
                if (zoznamSlov.Slova()[i].Length.Equals(pismena.Length))
                {
                    SlovaVDlzkePismen.Add(zoznamSlov.Slova()[i]);
                }
            }



            return null;
        }
    }
}
