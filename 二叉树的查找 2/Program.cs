using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树的查找_2
{
    class Program
    {
        //二叉查找树的 循环实现

        static void Main(string[] args)
        {
            Tree tree = GetTree();
            bool result = Find(9,tree);
            if(result==true)
            {
                Console.WriteLine("树中存在这个数值");
            }
            else
            {
                Console.WriteLine("树中不存在该数值 Sorry ");
            }
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

        public static bool Find(int Value,Tree tree)
        {
            while(tree!=null)
            {
                if(Value>tree.Value)
                {
                    tree = tree.Right;
                }
                else if(Value<tree.Value)
                {
                    tree = tree.Left;
                }
                else if(Value==tree.Value)
                {
                return true;
                }
            }
            return false;
        }
    }
    public  class Tree
    {
       public int Value;
       public  Tree Left;
        public Tree Right;
    }

}
