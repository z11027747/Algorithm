using System;

namespace Algorithm._1BinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>() {Data = data};
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node<T> currNode = Root;

                while (true)
                {
                    if (data.CompareTo(currNode.Data) >= 0) //右边
                    {
                        if (currNode.Right == null)
                        {
                            currNode.Right = newNode;
                            newNode.Parent = currNode;
                            break;
                        }
                        else
                        {
                            currNode = currNode.Right;
                        }
                    }
                    else //左边
                    {
                        if (currNode.Left == null)
                        {
                            currNode.Left = newNode;
                            newNode.Parent = currNode;
                            break;
                        }
                        else
                        {
                            currNode = currNode.Left;
                        }
                    }
                }
            }
        }

        public void MiddleTraversal(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            MiddleTraversal(node.Left);
            Console.WriteLine(node.Data + " ");
            MiddleTraversal(node.Right);
        }

        public bool Find(T data)
        {
            Node<T> currNode = Root;

            while (true)
            {
                if (currNode == null)
                {
                    return false;
                }

                if (currNode.Data.CompareTo(data) == 0)
                {
                    return true;
                }

                if (currNode.Data.CompareTo(data) > 0)
                {
                    currNode = currNode.Left;
                }
                else
                {
                    currNode = currNode.Right;
                }
            }
        }

        public bool Find(T data, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Data.CompareTo(data) == 0)
            {
                return true;
            }

            if (node.Data.CompareTo(data) > 0)
            {
                return Find(data, node.Left);
            }
            else
            {
                return Find(data, node.Right);
            }
        }

        public bool Delete(T data)
        {
            Node<T> currNode = Root;

            while (true)
            {
                if (currNode == null)
                {
                    return false;
                }

                if (currNode.Data.CompareTo(data) == 0)
                {
                    Delete(currNode);
                    return true;
                }

                if (currNode.Data.CompareTo(data) > 0)
                {
                    currNode = currNode.Left;
                }
                else
                {
                    currNode = currNode.Right;
                }
            }
        }

        public void Delete(Node<T> node)
        {
            if (node.Left == null && node.Right == null)
            {
                if (node.Parent == null)
                {
                    Root = null;
                    return;
                }

                if (node.Data.CompareTo(node.Parent.Data) > 0)
                {
                    node.Parent.Right = null;
                }
                else
                {
                    node.Parent.Left = null;
                }
                return;
            }

            if (node.Left == null)
            {
                if (node.Parent == null)
                {
                    Root = node.Right;
                    return;
                }

                if (node.Data.CompareTo(node.Parent.Data) > 0)
                {
                    node.Parent.Right = node.Right;
                }
                else
                {
                    node.Parent.Left = node.Right;
                }
                node.Right.Parent = node.Parent;
                return;
            }

            if (node.Right == null)
            {
                if (node.Parent == null)
                {
                    Root = node.Left;
                    return;
                }

                if (node.Data.CompareTo(node.Parent.Data) > 0)
                {
                    node.Parent.Right = node.Left;
                }
                else
                {
                    node.Parent.Left = node.Left;
                }
                node.Left.Parent = node.Left;
            }

            Node<T> minNode = FinMin(node.Right);

            if (minNode.Parent != node)
            {
                minNode.Parent.Left = null;
                minNode.Right = node.Right;
            }

            if (node.Parent == null || node.Data.CompareTo(node.Parent.Data) >= 0)
            {
                minNode.Parent = node.Parent;
                if (node.Parent != null)
                {
                    node.Parent.Right = minNode;
                }
            }
            else
            {
                minNode.Parent = node.Parent;
                node.Parent.Left = minNode;
            }

            minNode.Left = node.Left;
            node.Left.Parent = minNode;

            if (node.Parent == null)
            {
                Root = minNode;
            }
        }

        public Node<T> FinMin(Node<T> node)
        {
            Node<T> currNode = node;

            while (true)
            {
                if (currNode.Left == null)
                {
                    return currNode;
                }

                currNode = node.Left;
            }
        }
    }
}