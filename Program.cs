using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> initialData = new List<object> { 10, "Hello", new MyClass(1, "John"), new MyClass(2, "Jane"), new MyClass(3, "Praveen"), new MyClass(4, "Shyam"), new MyClass(5, "Alice"), 20, "World" };
            var largeDataCollection = new LargeDataCollection(initialData);
            largeDataCollection.Add(42);
            largeDataCollection.Remove("Hello");
            largeDataCollection.Remove(20);
            Console.WriteLine("All elements in the LargeDataCollection:");
            for (int i = 0; i < initialData.Count; i++)
            {
                var element = largeDataCollection.GetElement(i);
                Console.WriteLine(element);
            }
            largeDataCollection.Dispose();
        }
    }
}
