using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class a7List
    {
        ListBase _head = new ListBase();
        int _count;

        public a7List()
        {
            _count = 0;
        }

        public void add(object _inputAdd)
        {
            _head.add(_inputAdd);
            _count++;
        }

        public object this[int _inputIndex]
        {
            get
            {
                if (_inputIndex > _count - 1)
                    return null;
                return _head._next.get(_inputIndex);
            }
            set
            {
                _head._next.set(_inputIndex, value);
            }
        }

        public void removeAt(int _inputIndex)
        {
            _count -= _head.removeAt(_inputIndex);
        }

        public void remove(object _input)
        {
            _count -= _head.remove(_count, _input);
        }

        public override string ToString()
        {
            string returnString = "Count : " + _count + "\n";
            returnString += "Data : \n" + _head.ToString(0, _count);

            return returnString;
        }
    }
}
