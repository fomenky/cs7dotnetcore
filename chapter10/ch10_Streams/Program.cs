using static System.Console;
using System.IO;
using System.Xml;
using System.IO.Compression;


namespace ch10_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            // define an array of strings
            string[] callsigns = new string[] { "Husker", "Starbuck", "Apollo", "Boomer", "Bulldog", "Athena", "Helo", "Racetrack" };

            // define a file to write to using a text writer helper
            // string textFile = @"/Users/AceGod/Documents/repos/cs7dotnetcore/chapter10/ch10_streams.txt"; // Linux
            string textFile = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_streams.txt";
            StreamWriter text = File.CreateText(textFile);

            // Enumerate the strings writing each one to the stream 
            foreach (string item in callsigns)
            {
                text.WriteLine(item);
            }
            text.Dispose(); // close the stream

            // output all the contents of the file to the Console
            WriteLine($"{textFile} contains {new FileInfo(textFile).Length} bytes");
            WriteLine(File.ReadAllText(textFile));

            // define a file to write to using the XML writer helper
            string xmlFile = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_streams.xml";
            FileStream xmlFileStream = File.Create(xmlFile);
            XmlWriter xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings{ Indent = true });

            // write the XML declaration 
            xml.WriteStartDocument();

            // write a root element
            xml.WriteStartElement("callSigns");

            // Enumerate the strings writing each one to the stream
            foreach (var item in callsigns)
            {
                xml.WriteElementString("callSign", item);
            }
            // write the close root element 
            xml.WriteEndElement(); 
            xml.Dispose(); 
            xmlFileStream.Dispose(); 
        
            // output all the contents of the file to the Console 
            WriteLine($"{xmlFile} contains {new FileInfo(xmlFile).Length} bytes."); 
            WriteLine(File.ReadAllText(xmlFile));

            // Compressing Streams
            // compress the XML output
            string gzipFilePath = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_streams.gzip";
            FileStream gzipFile = File.Create(gzipFilePath); 
            GZipStream compressor = new GZipStream(gzipFile, CompressionMode.Compress); 
            XmlWriter xmlGzip = XmlWriter.Create(compressor); 

            xmlGzip.WriteStartDocument(); 
            xmlGzip.WriteStartElement("callsigns"); 
            foreach (string item in callsigns) 
            { 
                xmlGzip.WriteElementString("callsign", item); 
            } 
            xmlGzip.Dispose(); 
            compressor.Dispose(); // also closes the underlying stream 
        
            // output all the contents of the compressed file to the Console 
            WriteLine($"{gzipFilePath} contains {new FileInfo(gzipFilePath).Length} bytes."); 
            WriteLine(File.ReadAllText(gzipFilePath));  
        
            // read a compressed file 
            WriteLine("Reading the compressed XML file:"); 
            gzipFile = File.Open(gzipFilePath, FileMode.Open); 
            GZipStream decompressor = new GZipStream(gzipFile, CompressionMode.Decompress); 
            XmlReader reader = XmlReader.Create(decompressor); 
            while (reader.Read()) 
            { 
                // check if we are currently on an element node named callsign 
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "callsign")) 
                { 
                    reader.Read(); // move to the Text node inside the element 
                    WriteLine($"{reader.Value}"); // read its value 
                } 
            } 
            reader.Dispose(); 
            decompressor.Dispose(); 
        }
    }
}