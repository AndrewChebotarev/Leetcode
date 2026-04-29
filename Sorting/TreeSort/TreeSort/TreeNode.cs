using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSort
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
}
