using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class ListBase
    {
        internal ListBase _previous, _next;

        public ListBase() { }
        public ListBase(ListBase _inputPrevious)
        {
            _previous = _inputPrevious;
        }
        ~ListBase()
        {

        }

        public virtual void add(object _input)
        {
            if (_next == null)
                _next = new ListValue(this);
            _next.add(_input);
        }

        public virtual object get(int _inputIndex)
        {
            return null;
        }
        public virtual void set(int _inputIndex, object _input)
        {

        }

        public virtual int removeAt(int _inputIndex)
        {
            return _next.removeAt(_inputIndex);
        }

        public virtual int remove(int _inputCount, object _input)
        {
            return _next.remove(_inputCount, _input);
        }

        internal void removeData()
        {
            if (_previous != null)
                _previous._next = _next;
            else
                _next = _next._next;
        }

        public virtual string ToString(int _inputIndex, int _inputFC)
        {
            return _next.ToString(_inputIndex, _inputFC);
        }
    }
}
