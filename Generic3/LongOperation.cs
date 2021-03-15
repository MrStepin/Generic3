using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic3
{
    public class LongOperation<T>
    {

        public T _rememberValue;

        public LongOperation(T download)
        {
            Value = download;
        }

        public bool HasValue { get; set; }
        public T Value
        {
            get
            {
                if (!HasValue)
                {
                    HasValue = true;
                }
                return _rememberValue;
            }
            set
            {
                _rememberValue = value;
                HasValue = true;
            }
        }
    }
}
