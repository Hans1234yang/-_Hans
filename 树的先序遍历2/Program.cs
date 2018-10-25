using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace 树的先序遍历2
{
    //树的先序遍历，非递归实现  运用到了 栈的知识
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = CreateTree();
            ProNoDiGui(tree);
            Console.ReadKey();
        }

        /// <summary>
        /// 创建树
        /// </summary>
        /// <returns></returns>
        public static Tree CreateTree()
        {
            Tree tree = new Tree()
            {
                Value = "A",
                Left=new Tree()
                {
                    Value="B",
                    Left=new Tree { Value="D",Left=new Tree { Value="F"} },
                    Right=new Tree { Value="E"}
                    
                },
                Right=new Tree() {Value="C" }
                
            };
            return tree;
        }

        public static void ProNoDiGui(Tree tree)
        {
            Tree node = tree;
            Stack<Tree> stack = new Stack<Tree>();

            while(node!=null||stack.Any())
            {
                if(node!=null)
                {
                    stack.Push(node);                    //节点进栈
                    Console.WriteLine(node.Value);       //输出该节点
                    node = node.Left;                     //节点移动到 左孩子
                }
                else   //node节点为空
                {
                    var item = stack.Pop();
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
