using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02_06
{
    internal class reverseString
    {
        public string _inputString;
        public string _outputString;

        public reverseString() { }
        public reverseString(string inputString) {
            _inputString = inputString;
        }

        public string getOutputString() { return _outputString; }
        public void reverseInputString  ()
        {
            char[] arr = new char[_inputString.Length];
            arr = _inputString.Reverse().ToArray();
            _outputString = new string(arr );
        }


    }
}
