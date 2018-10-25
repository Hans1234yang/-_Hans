using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 树的后续遍历1
{
    class Program
    {
        //树的后续遍历算法 递归1
        static void Main(string[] args)
        {
            Tree tree = GetTree();
            PostOrder(tree);
            Console.ReadKey();
        }

        ///获取树
        public static Tree GetTree()
        {
            Tree tree = new Tree()
            {
                Value = "A",
                Left = new Tree()
                {
                    Value = "B",
                    Left = new Tree()
                    {
                        Value = "D",
                        Left = new Tree { Value = "F" }

                    },
                    Right = new Tree()
                    {
                        Value = "E",
                    }

                },
                Right = new Tree() { Value = "C" }



            };

            return tree;
        }

        //
        public static void PostOrder(Tree tree)
        {
            Tree node = tree;
            if(node==null)
            {
                return;
            }
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Value);


        }
    }

    public class Tree
    {
        public string Value;
        public Tree Left;
        public Tree Right;
    }
}
