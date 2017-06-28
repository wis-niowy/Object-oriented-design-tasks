using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2.CustomCollections
{
    class BinaryTreeNode
    {
        internal double Value { get; }
        internal BinaryTreeNode LeftChild { get; set; }
        internal BinaryTreeNode RightChild { get; set; }

        internal BinaryTreeNode (double value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
