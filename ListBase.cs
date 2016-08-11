using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class ListBase
    {
        internal ListValue _previous, _next;

        public ListBase() { }
        public ListBase(ListValue _inputPrevious)
        {
            _previous = _inputPrevious;
        }
        ~ListBase()
        {

        }

        public virtual void add(object _input)
        {
            if (_next == null)
                _next = new ListValue();
            _next.add(_input);
        }

        public virtual int removeAt(int _inputIndex)
        {
            return _next.removeAt(_inputIndex);
        }

        public virtual string ToString(int _inputIndex, int _inputFC)
        {
            return _next.ToString(_inputIndex, _inputFC);
        }
    }
}
