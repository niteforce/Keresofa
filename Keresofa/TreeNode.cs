using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresofa
{
    class TreeNode
    {

        public TreeNode(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }
        public TreeNode Parent { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

    }
}
