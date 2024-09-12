using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// La vérification des parenthèse fermante peut se faire à chaque ouverture d'une même parenthèse. La vérification se fait pour un charactere , proposant un autre caractere.
// Le type de variable me semblant idéal est "ch".
namespace Serie_IV
{
    public static class BracketsControl
    {
        public static bool BracketsControls(string sentence)
        {
            int cptpar = 0;
            int cptbra = 0;
            int cptacc = 0;
            foreach (char ch in sentence)
            {
                switch (ch)
                {
                    case "(":
                        cptpar += 1;
                        break;
                    case ")":
                        cptpar -= 1;
                        break;
                    case "{":
                        cptacc += 1;
                        break;
                    case "}":
                        cptacc -= 1;
                        break;
                    case "[":
                        cptbra += 1;
                        break;
                    case "]":
                        cptbra -= 1;
                        break;
                    default:
                        break;
                }
            }
            if (cptacc < 0 || cptbra < 0 || cptacc < 0)
            {
                Console.WriteLine("Il y'a un problème de parenthèse fermé , jamais ouverte");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
