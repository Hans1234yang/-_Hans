using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace 树的中序遍历2
{
    /// <summary>
    /// 树的中序遍历2   非递归   运用到栈的技术
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = GetTree();
            InOrderNoDiGui(tree);
            Console.ReadKey();
        }

        //获取树
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
                        Left = new Tree()
                        {
                            Value = "F"
                        }
                    },
                    Right = new Tree()
                    {
                        Value = "F"
                    }

                },

                Right = new Tree()
                {
                    Value = "C"
                }
            };
            
            return tree;
        }


        //中序遍历，非递归的实现
        public static void InOrderNoDiGui(Tree tree)
        {
             Tree node = tree;
            Stack<Tree> stack = new Stack<Tree>();

            while(node!=null||stack.Any())
            {
                if(node!=null)
                {
                    stack.Push(node);
                    node = node.Left;
                }

                else
                {
                    var item = stack.Pop();
                    Console.WriteLine(item.Value);
                    node = item.Right;
                }

            }
        }
    }

    public class Tree
    {
        public string Value;
        public Tree Left;
        public Tree Right;
    }
}
