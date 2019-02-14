using System.IO;
using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("What would you like to name your document?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the content of your document:");
            string content = Console.ReadLine();
            try
            {
                StreamWriter Doc = new StreamWriter (string.Format("{0}.txt",name));
                Doc.WriteLine(name + "\n" + content);
                Doc.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("\n{0} has been saved.\nThe document contains {1} characters.", name, content.Length);
            }
        }
    }
}
