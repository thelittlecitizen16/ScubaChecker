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
            XmlSerializer writer = new XmlSerializer(testsToSerialize.GetType());
            StreamWriter fileWrite = new StreamWriter(@"C:\Users\thelittlecitizen16\source\repos\ScubaChecker\ScubaChecker\TestsXML.xml");
            writer.Serialize(fileWrite, testsToSerialize);

            return fileWrite.BaseStream;
        }
    }
}
