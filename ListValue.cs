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
        ListValue _next = new ListValue();
        int _index;

        public ListValue() { }

        public void add(int _inputIndex, int _inputCheck, object _inputObj)
        {
            if (_inputCheck == 0)
            {
                _index = _inputIndex;
                _value = _inputObj;
            }
            else
            {
                _next.add(_inputIndex, --_inputCheck, _inputObj);
            }
        }
    }
}
