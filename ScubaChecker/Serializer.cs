using System;
using System.Collections.Generic;
using System.Text;
using MamasChecker.Abstract;
using System.Xml.Serialization;
using System.IO;

namespace ScubaChecker
{
    public class Serializer<T> : ISerializer<T>
    {
        Stream ISerializer<T>.Serialize(T[] testsToSerialize)
        {
            string path = @"C:\Users\thelittlecitizen16\source\repos\ScubaChecker\ScubaChecker\TestsXML.xml";

            XmlSerializer writer = new XmlSerializer(testsToSerialize.GetType());
            StreamWriter fileWrite = new StreamWriter(path);
            writer.Serialize(fileWrite, testsToSerialize);
            fileWrite.Close();

            FileStream fileStream = File.OpenRead(path);

            return fileStream;
        }
    }
}
