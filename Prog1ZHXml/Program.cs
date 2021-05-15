using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Prog1ZHXml
{
    class Program
    {
        List<Book> Books;
        static void Main(string[] args)
        {
            var _currPath = Directory.GetCurrentDirectory();
            var _filePath = Path.Combine(_currPath, "books.xml");
            var _program = new Program();
            CreateXML(_program, _filePath);
        }
        static void CreateXML(Program prg,string fileName)
        {
            prg.Books = new List<Book>();
            var booksXml = XElement.Load(fileName);


        }
    }
}
