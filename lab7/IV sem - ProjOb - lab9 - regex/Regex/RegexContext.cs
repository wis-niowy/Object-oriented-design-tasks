using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex
{
    class RegexContext : IEnumerable<string>
    {
        private List<string> streams = new List<string>();

        /// <summary>
        /// Creates RegexContext without any stream
        /// </summary>
        public RegexContext()
        {
        }

        /// <summary>
        /// Create RegexContext with one initial stream
        /// </summary>
        /// <param name="initial_stream"> </param>
        public RegexContext(string initial_stream)
        {
            streams.Add(initial_stream);
        }

        public void Add(string stream)
        {
            streams.Add(stream);
        }

        public void AddAll(RegexContext other)
        {
            foreach (var stream in other)
                this.Add(stream);
        }

        public bool IsEmpty()
        {
            return this.streams.Count == 0;
        }

        /// <summary>
        /// Checks if the context was matched by the regex.
        /// </summary>
        /// <returns> True if context was matched by a regex, false otherwise  </returns>
        public bool Matches()
        {
            foreach (var stream in streams)
                if (stream == "")
                    return true;
            return false;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new RegexContextEnumerator(streams);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new RegexContextEnumerator(streams);
        }
    }
}
