using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic3
{
    public class LongOperation<T>
    {
        private Func<T,T> _input;

        public Func<T, T> Value
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }

        }

        public Func<T, T> RememberedValue
        {
            get
            {
                return Value;
            }
        }
    }
}
