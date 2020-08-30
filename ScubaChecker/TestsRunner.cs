using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class TestsRunner<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            var a = (List<T>)serializer.Deserialize(stream);


            return a.ToArray();
        }
    }
}
