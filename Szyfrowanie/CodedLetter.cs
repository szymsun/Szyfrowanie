using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie
{
    public class CodedLetter
    {
        public char Letter;
        public int LetterIndex;
        public CodedLetter(char _Letter, int _LetterIndex)
        {
            Letter = _Letter;
            LetterIndex = _LetterIndex;
        }
    }
}
