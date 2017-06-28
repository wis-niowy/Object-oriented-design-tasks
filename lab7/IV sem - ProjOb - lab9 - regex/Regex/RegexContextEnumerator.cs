using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex
{
    class RegexContextEnumerator : IEnumerator<string>
    {
        private List<string> states;
        private int current_index;

        public RegexContextEnumerator(List<string> states)
        {
            this.states = states;
            this.current_index = -1;
        }

        public string Current
        {
            get
            {
                return states[current_index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return states[current_index];
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            current_index++;

            return (current_index < states.Count);
        }

        public void Reset()
        {
            current_index = -1;
        }
    }
}
