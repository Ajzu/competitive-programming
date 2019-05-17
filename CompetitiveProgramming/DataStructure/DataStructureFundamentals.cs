using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.DataStructure
{
    public class DataStructureFundamentals
    {
        #region LinkedListFeatures

        /// <summary>
        /// GFG reference - https://www.geeksforgeeks.org/c-sharp-linkedlist-class/
        ///Geeks for Geeks - definition : LinkedList<T> Class is present in System.Collections.Generic namespace. This generic type allows fast inserting and removing of elements. It implements a classic linked list. Each object is separately allocated. In the LinkedList, certain operations do not require the whole collection to be copied. But in many common cases LinkedList hinders performance.
        ///Characteristics of LinkedList Class:
        ///LinkedList<T> is a general-purpose linked list. It supports enumerators.
        ///Insertion and removal are O(1) operations.
        ///You can remove nodes and reinsert them, either in the same list or in another list, which results in no additional objects allocated on the heap.
        ///Because the list also maintains an internal count, getting the Count property is an O(1) operation..
        ///Each node in a LinkedList<T> object is of the type LinkedListNode<T>.
        ///The LinkedList class does not support chaining, splitting, cycles, or other features that can leave the list in an inconsistent state.
        ///If the LinkedList is empty, the First and Last properties contain null.
        ///The LinkedList is doubly linked, therefore, each node points forward to the Next node and backward to the Previous node.
        ///Constructor() - LinkedList() : Initializes a new instance of the LinkedList class that is empty.
        ///Constructor() - LinkedList(IEnumerable) : Initializes a new instance of the LinkedList class that contains elements copied from the specified IEnumerable and has sufficient capacity to accommodate the number of elements copied.
        ///Constructor() - LinkedList(SerializationInfo, StreamingContext) : Initializes a new instance of the LinkedList class that is serializable with the specified SerializationInfo and StreamingContext.
        ///----Dotnet Pearls reference - https://www.dotnetperls.com/linkedlist
        ///LinkedList. The LinkedList type is a class. It is allocated on the managed heap when you invoke the new operator and then call the LinkedList instance constructor.
        ///
        /// </summary>
        public void BasicsOfLinkedList()
        {
            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddLast("Geeks");
            myLinkedList.AddLast("for");
            myLinkedList.AddLast("DataStructures");
            myLinkedList.AddLast("Noida");

            if (myLinkedList.Count > 0)
            {
                Console.WriteLine("LinkedList is not empty, contains following values:");
                foreach (string item in myLinkedList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("LinkedList is empty.");
            }
        }

        #endregion LinkedListFeatures

        #region Queues

        //basics of queues
        public void BasicsOfQueues()
        {
            Queue<string> qt = new Queue<string>();
            qt.Enqueue("one");
            qt.Enqueue("two");
            qt.Enqueue("three");
            qt.Enqueue("four");
            qt.Enqueue("five");

            //let's review all the items present in the queue
            Console.Write("let's review all the items present in the queue.");
            foreach (string item in qt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First item in the queue is : " + qt.Peek());

            //let's remove one item from queue and then review the whole queue
            Console.Write("\nlet's review all the items present in the queue after learning Dequeue functionality or removing item from queue.\nDequeue removes the first item present in the queue Hence FIFO - First In First Out\n\"one\" is the first item that came inside the queue and hence \"one\" is also the first to go out of the queue.\n");
            qt.Dequeue();
            foreach (string item in qt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First item in the queue is : " + qt.Peek());
            qt.Dequeue();
            Console.WriteLine("First item in the queue is : " + qt.Peek());


            //CircularQueue 
        }

        #endregion Queues
    }
}
