using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class ListValue : ListBase
    {
        object _value;
        ListValue _previous, _next;
        int _index;

        public ListValue() { }
        public ListValue(ListValue _inputPrevious)
        {
            _previous = _inputPrevious;
        }

        public void add(int _inputIndex, object _inputObj)
        {
            if (_next == null)
            {
                _index = _inputIndex;
                _value = _inputObj;
                _next = new ListValue(this);
            }
            else
                _next.add(_inputIndex, _inputObj);
        }

        public object get(int _inputIndex)
        {
            if (_index == _inputIndex)
                return _value;
            return _next.get(_inputIndex);
        }

        public void set(int _inputIndex, object _input)
        {
            if (_index == _inputIndex)
                _value = _input;
            else
                _next.set(_inputIndex, _input);
        }

        public int removeAt(int _inputIndex)
        {
            if (_index == _inputIndex)
            {

            }

            return 0;
        }

        public string ToString(int _inputCount)
        {
            string returnString = _index + "\t";
            returnString += _value + "\n";

            if (_index != _inputCount - 1)
                returnString += _next.ToString(_inputCount);

            return returnString;
        }

        public override string ToString()
        {
            if (_value == null)
                return "null";
            return _value.ToString();
        }
    }
}
