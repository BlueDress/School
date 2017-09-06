using System;
using System.Text;

namespace Collection_Hierarchy
{
    public class Startup
    {
        public static void Main()
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var elements = Console.ReadLine().Split();

            var addCollectionSB = new StringBuilder();
            var addRemoveCollectionSB = new StringBuilder();
            var myListSB = new StringBuilder();

            for (int i = 0; i < elements.Length; i++)
            {
                addCollectionSB.Append(addCollection.Add(elements[i]) + " ");
                addRemoveCollectionSB.Append(addRemoveCollection.Add(elements[i]) + " ");
                myListSB.Append(myList.Add(elements[i]) + " ");
            }

            Console.WriteLine(addCollectionSB.ToString().Trim());
            Console.WriteLine(addRemoveCollectionSB.ToString().Trim());
            Console.WriteLine(myListSB.ToString().Trim());
            
            addRemoveCollectionSB.Clear();
            myListSB.Clear();

            var numberOfRemoveOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRemoveOperations; i++)
            {
                addRemoveCollectionSB.Append(addRemoveCollection.Remove() + " ");
                myListSB.Append(myList.Remove() + " ");
            }

            Console.WriteLine(addRemoveCollectionSB.ToString().Trim());
            Console.WriteLine(myListSB.ToString().Trim());
        }
    }
}
