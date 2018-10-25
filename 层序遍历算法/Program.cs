using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 层序遍历算法
{
    class Program
    {
        ///层序遍历   //层序遍历涉及到队列   其他的涉及到栈
        static void Main(string[] args)
        {
            Tree tree = GetTree();
          
        

            LevelOrder(tree);
            Console.ReadKey();

        }
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
                        Value = "E"
                    },

                },
                Right = new Tree()
                {
                    Value = "C",
                }

            };
            return tree;
        }


        //排序
        static void LevelOrder(Tree tree)
        {
            if(tree==null)
            {
                return;
            }
            Queue<Tree> Queue = new Queue<Tree>();
            Queue.Enqueue(tree);     ///根节点先进队列

            while(Queue.Any())
            {
                var item = Queue.Dequeue();   //根节点先 出队
                Console.WriteLine(item.Value);

                if(item.Left!=null)
                {
                    Queue.Enqueue(item.Left);
                    Console.WriteLine("Hi");
                }
                if(item.Right!=null)
                {
                    Queue.Enqueue(item.Right);
                    Console.WriteLine("hello");
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
