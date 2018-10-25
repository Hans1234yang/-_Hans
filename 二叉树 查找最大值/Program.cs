using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_查找最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = GetTree();
            FindBig(tree);
            Console.ReadKey();
        }
        //创建树
        public static Tree GetTree()
        {
            Tree tree = new Tree()
            {
                Value = 5,
                Left = new Tree()
                {
                    Value = 3,
                    Left = new Tree()
                    {
                        Value = 2,
                        Left = new Tree() { Value = 1 }
                    },
                    Right = new Tree() { Value = 4 }

                },
                Right = new Tree() { Value = 6 }

            };
            return tree;

        }

        public static void  FindBig(Tree tree)
        {
            while(tree!=null)
            {
                //有右孩子，就将右孩子 的赋值给给tree
                if(tree.Right!=null)
                {
                    tree = tree.Right;
                }
                else  //没有右孩子，这个节点的值最大 
                {
                    Console.WriteLine(tree.Value);
                    return;
                }
            }

        }
    }
    public class Tree
    {
        public int Value;
        public Tree Left;
        public Tree Right;
    }
}
