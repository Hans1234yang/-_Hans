using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 树的先序遍历
{
    /// <summary>
    /// 树的先序遍历1  递归实现
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = CreateTree();
            ProOrder(tree);
            Console.ReadKey();
        }


        ///树的创建
        public static  Tree CreateTree()
        {
            Tree tree = new Tree()
            {
                Value = "A"
            };
            tree.Left = new Tree()
            {
                Value = "B",
                Left=new Tree() { Value="D",Left=new Tree {Value="F" } },
                Right=new Tree() { Value="E"}
            };

            tree.Right = new Tree()
            {
                Value = "C"
            };

            return tree;
        }

        //递归实现
        public static void ProOrder(Tree tree)
        {
            if(tree==null)
            {
                return;
            }
            Console.WriteLine(tree.Value);
            ProOrder(tree.Left);
            ProOrder(tree.Right);

        }
    }

    public class Tree
    {
        public string Value;
        public Tree Left;
        public Tree Right;
    }
}
