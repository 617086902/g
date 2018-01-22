using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct Node
    {
        internal int node;

    }

    public class TreeNode
    {
        public TreeNode()
        {
            Children = new List<TreeNode>();
            Level = 0;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ChildNum { get { return Children.Count(); } }
        public List<TreeNode> Children { get; set; }
    }

    public class MultiTree
    {
        private static TreeNode SearchNode(TreeNode node, int id)
        {
            TreeNode treeNode = null;
            if (node != null)
            {
                if (node.Id.Equals(id)) treeNode = node;
                else
                {
                    for (int i = 0; i < node.ChildNum && treeNode == null; i++)
                    {
                        treeNode = SearchNode(node.Children[i], id);
                    }
                }
            }
            return treeNode;
        }

        public static void Add(ref TreeNode head, int parentId, int id, string name)
        {
            TreeNode temp = null;
            if (head == null)
            {
                temp = head = new TreeNode();
                temp.Name = name;
                temp.Id = id;
            }
            else
            {
                temp = SearchNode(head, parentId);
                temp.Children.Add(new TreeNode
                {
                    Id = id,
                    Name = name
                });
            }
        }
    }
}
