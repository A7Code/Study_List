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

    }
}
