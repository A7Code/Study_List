using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class ListValue
    {
        object _value;
        ListValue _next;
        int _index;

        public ListValue(int _inputIndex)
        {
            _index = _inputIndex;
        }

    }
}
