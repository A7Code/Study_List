﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class a7List
    {
        ListValue _fitst = new ListValue();
        int _count;

        public a7List()
        {
            _count = 0;
        }

        public void add(object _inputAdd)
        {
            _fitst.add(_count++, _inputAdd);
        }

        public object this[int _inputIndex]
        {
            get
            {
                if (_inputIndex > _count - 1)
                    return null;
                return _fitst.get(_inputIndex);
            }
            set
            {
                _fitst.set(_inputIndex, value);
            }
        }

        public override string ToString()
        {
            string returnString = "Count : " + _count + "\n";
            returnString += "Data : \n" + _fitst.ToString(_count);

            return returnString;
        }
    }
}