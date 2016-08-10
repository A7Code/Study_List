using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class ListBase
    {
        ListValue _fitst = new ListValue();
        int _count;

        public ListBase()
        {
            _count = 0;
        }

        public void add(object _inputAdd)
        {
            _fitst.add(_count++, _inputAdd);
        }

        public override string ToString()
        {
            string returnString = "Count : " + _count + "\n";
            returnString += "Data : \n" + _fitst.ToString();

            return returnString;
        }
    }
}
