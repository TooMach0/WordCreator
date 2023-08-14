using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCreator
{
    internal class ZoznamSlov
    {

        //toto cele mohlo byt static, aj DatabazaSlov, ale tu sa asi budu tahat z db?
        public List<string> Slova()
        {
            List<string> DatabazaSlov = new List<string> { "auto", "plzen" };

            return DatabazaSlov;
        }
    }
}
