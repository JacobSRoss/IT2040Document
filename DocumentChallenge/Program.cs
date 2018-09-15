using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocumentChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            String documentName;
            String documentContent;
            int characterCount = 0;

            Console.WriteLine("Document");
            Console.WriteLine("");
            Console.WriteLine("Name of the document?: ");
            documentName = Console.ReadLine();
            Console.WriteLine("Contents of the document?: ");
            documentContent = Console.ReadLine();

            try{
                documentName += ".txt";
                using (StreamWriter sw = new StreamWriter(documentName))
                {
                    sw.WriteLine(documentContent);
                }
            } catch (Exception e){
                Console.WriteLine("Exception has occured");
                //Environment.Exit;
            }
            characterCount = documentContent.Length;
            Console.WriteLine(documentName +" was successfully saved. The document contains " + characterCount + " characters.");
            Console.ReadLine();
        }
    }
}
