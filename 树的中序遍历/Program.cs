using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 树的中序遍历
{
    //根的中序遍历1  递归实现 
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = GetTree();
            Inorder(tree);
            Console.ReadKey();

        }
        //创建树
        public  static Tree GetTree ()
        {
            Tree tree = new Tree()
            {
                Value = "A",

                Left = new Tree()
                {
                    Value = "B" ,
                    Left =new Tree { Value="D",Left=new Tree { Value="F"} },
                    Right=new Tree { Value="E"}
                },
               

                Right = new Tree() { Value = "C" }
            };
            return tree;

        }

        //终须遍历 递归实现
        public static void Inorder(Tree tree)
        {
            Tree node = tree;
            if(node == null)
            {
                return ;
            }
            Inorder(tree.Left);
            Console.WriteLine(tree.Value);
            Inorder(tree.Right);

        }


    }

    public class Tree
    {
        public string Value;
        public Tree Left;
        public Tree Right;
    }
         
}
