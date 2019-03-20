using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();

            foreach (Element element  in myCollection)
            {
                Console.WriteLine($"Name: {element.Name}  Field1: {element.Field1}  Field2: {element.Field2}");
            }

            //myCollection.Reset();

            Console.WriteLine(new string('-', 29) + "\n");

            foreach (Element element in myCollection)
            {
                Console.WriteLine($"Name: {element.Name}  Field1: {element.Field1}  Field2: {element.Field2}");
            }

            Console.WriteLine(new string('-', 29) + "\n");


            UserCollection myElementsCollection = new UserCollection();

            IEnumerable enumerable = myElementsCollection as IEnumerable;

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;

                Console.WriteLine($"Name: {element.Name}  Field1: {element.Field1}  Field2: {element.Field2}");
            }

            enumerator.Reset();

            Console.ReadKey();
        }
    }
}