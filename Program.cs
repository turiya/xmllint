using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace xmllint
{
    class Program
    {
        static String fileName = "";

        static void Main(string[] args)
        {
            initialize(args);
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);

                XmlTextWriter writer = new XmlTextWriter(Console.Out);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                doc.WriteContentTo(writer);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e);
            }
        }

        private static void initialize(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter a filename");
                Environment.Exit(-1);
            }
            fileName = args[0];
        }
    }
}

