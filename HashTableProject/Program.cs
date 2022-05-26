using HashTable;
using  System;
namespace HashTableProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hash Table project");
            MyMapNode<string,int> hash = new MyMapNode<string,int>(5);
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr1 = phrase.Split(' ');
            // LinkedList<string> checkDuplication = new LinkedList<string>();
            foreach (string element in arr1)
            {
                int value=hash.Get(element);
                if (value==default)
                {
                    value=1;
                }
                else value +=1;
                hash.Add(element,value);
            }
            int frequency = hash.Get("paranoid");
            Console.WriteLine(frequency);
        }

    }
}