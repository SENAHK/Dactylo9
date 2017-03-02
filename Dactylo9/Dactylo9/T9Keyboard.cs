using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dactylo9
{
    public class T9Keyboard
    {
        private List<T9Key> keys = new List<T9Key>();

        public List<T9Key> Keys
        {
            get { return keys; }
            set { keys = value; }
        }

        public T9Keyboard()
        {
            string[] values = { ",.?!1", "ABC2", "DEF3", "GHI4", "JKL5", "MNO6", "PQRS7", "TUV8", "WXYZ9", "_" };

            foreach (var item in values)
            {
                this.keys.Add(new T9Key(item));
            }
        }
    }
}
