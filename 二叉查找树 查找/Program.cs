using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉查找树_查找1
{
    class Program
    {
        //二叉查找树的 查找
        static void Main(string[] args)
        {
            Tree tree = GetTree();
          bool result= Find(8,tree);

            if(result==true)
            {
                Console.WriteLine("该树中存在该值");
            }
            else
            {
                Console.WriteLine("该树不存在这个值");
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

        /// <summary>
        /// 递归实现了 二叉树的查找。 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static bool Find (int Value, Tree tree)
        {
            if(tree==null)
            {
                return false; //查找失败 
            }

            if(Value > tree.Value)
            {
               return  Find(Value, tree.Right);
            }
            else if(Value < tree.Value)
            {
               return  Find(Value, tree.Left);
            }
            else 
           
            return true;
          
        }
             
    }

    public class Tree
    {
        public int Value;
        public Tree Left;
        public Tree Right;
    }

   
}
