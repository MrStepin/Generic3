using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic3
{
    public class LongOperation<T>
    {
        private T _input;
        private T _rememberValue;

        public bool HasValue { get; set; }
        public T Value
        {
            get
            {
                if (!HasValue)
                {
                    HasValue = true;
                    _rememberValue = _input;
                }
                return _rememberValue;
            }
            set
            {
                _input = value;
                HasValue = true;
            }
        }
    }
}
