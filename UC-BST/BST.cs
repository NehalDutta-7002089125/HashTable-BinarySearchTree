using System;
using System.Collections.Generic;
using System.Text;

namespace UC_BST
{
    internal class BST<T> where T : IComparable
    {
        public T data;
        public BST<T> leftNode;
        public BST<T> rightNode;
        public BST(T data)
        {
            this.data = data;
        }
       // int Leftcount=0, Rightcount=0;
         bool result=false;
        public void add(T element)
        {
            T a= this.data;
            if(a.CompareTo(element) > 0 )
            {
                if(leftNode==null)
                {
                    leftNode = new BST<T>(element);
                }
                else
                {
                    leftNode.add(element);
                }
            }
            else
            {
                if(rightNode==null)
                {
                    rightNode= new BST<T>(element);
                }
                else
                {
                    rightNode.add(element);
                }
            }
        }
        public void show()
        {
            if(leftNode!=null)
            {
                leftNode.show();
            }
            Console.WriteLine(data.ToString());
            if(rightNode!=null)
            {
                rightNode.show();
            }
        }
        public bool ifexists(T element, BST<T>node)
        {
            if(node==null)
            {
                return false;
            }
            if(node.data.Equals(element))
            {
                Console.WriteLine("we found the element :"+node.data);
                result=true;
            }
                     
            if (element.CompareTo(node.data) <0)
            {
                ifexists(element, node.leftNode);
            }
            else
           
            {
                ifexists(element, node.rightNode);
            }
            return result;
        }

    }
}
