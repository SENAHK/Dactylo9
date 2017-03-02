using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dactylo9
{
    public class T9Key
    {
        private string content;
        private int taps = 0;

        public int Taps
        {
            get { return taps; }
            set
            {
                if (value > this.content.Length - 1)
                {
                    value = 0;
                }

                taps = value;
            }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public T9Key(string values)
        {
                content = values;
        }
        public string Tap()
        {
            this.Taps += 1;
            return this.Content[this.Taps].ToString();
        }
    }
}
