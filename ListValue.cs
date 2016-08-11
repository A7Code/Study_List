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

        public ListValue() { }
        public ListValue(ListValue _inputPrevious)
            :base(_inputPrevious)
        {
            
        }
        ~ListValue()
        {
            _value = null;
        }

        public override void add(object _inputObj)
        {
            if (_next == null)
            {
                _value = _inputObj;
                _next = new ListValue(this);
            }
            else
                _next.add(_inputObj);
        }

        public object get(int _inputIndex)
        {
            if (_inputIndex == 0)
                return _value;
            return _next.get(
                --_inputIndex);
        }

        public void set(int _inputIndex, object _input)
        {
            if (_inputIndex == 0)
                _value = _input;
            else
                _next.set(--_inputIndex, _input);
        }

        public override int removeAt(int _inputIndex)
        {
            if (_inputIndex == 0)
            {
                removeData();
                return 1;
            }
            else
                return _next.removeAt(--_inputIndex);
        }

        public override int remove(int _inputCount, object _input)
        {
            int returnInt = 0;
            if (_input.Equals(_value))
            {
                removeData();
                returnInt++;
            }
            if (_inputCount != 1)
                returnInt += _next.remove(--_inputCount, _input);
            return returnInt;
        }

        public override string ToString(int _inputCount, int _inputFC)
        {
            string returnString = _inputCount++ + "\t";
            if (_value != null)
                returnString += _value.GetType();
            returnString += "\t" + _value + "\n";

            if (_inputCount != _inputFC)
                returnString += _next.ToString(_inputCount, _inputFC);

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
