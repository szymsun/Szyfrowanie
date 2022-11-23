using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie
{
    public class Coder
    {
        public string Word;

        public Coder(string _Word, int key)
        {
            Word = _Word;

            char[] chars = _Word.ToCharArray();

        }
    }
}
