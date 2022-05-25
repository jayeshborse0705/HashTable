using  System;
namespace HashTableProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hash Table project");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be"); 
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("0", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:"+hash5);
            string hash2=hash.Get("2");
            Console.WriteLine("2 th index value:"+hash2);

        }

    }
}