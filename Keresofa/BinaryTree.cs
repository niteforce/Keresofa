using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresofa
{
    class BinaryTree
    {
        public BinaryTree() { }

        public BinaryTree(int[] values)
        {
            foreach (int value in values)
            {
                this.Insert(value);
                                            
            }
        }

        public TreeNode Root { get; private set; }


        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                TreeNode current = Root;

                while (current != null)
                {
                    if (current.Value > value)
                    {
                        if (current.Left == null)
                        {
                            current.Left = new TreeNode(value);
                            current.Left.Parent = current;
                            return;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                    else if (current.Value < value)
                    {
                        if (current.Right == null)
                        {
                            current.Right = new TreeNode(value);
                            current.Right.Parent = current;
                            return;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                    else return;
                }
            }
        }
        
    }
    

}
