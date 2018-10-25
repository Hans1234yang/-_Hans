using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_求最小值
{
    class Program
    {
        //二叉查找树的 最小值
        static void Main(string[] args)
        {
            Tree tree = GetTree();
            FindSmall(tree);
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

        public static void FindSmall(Tree tree)
        {
            while(tree!=null)
            {
                if(tree.Left!=null)
                {
                    tree = tree.Left;
                }

                //没有左子树的时候，这个节点就是最小的啦
                else
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
