using MamasChecker.Abstract;
using System;
using System.Runtime.Serialization;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase testCase1 = new TestCase("test1",1);
            TestCase testCase2 = new TestCase("test2", 2);

            SerializerFactory serializerFactory = new SerializerFactory();
            var serializable = serializerFactory.CreateSerializer<TestCase>();
            var deserializer  = serializerFactory.CreateDeserializer<TestCase>();

            var stream = serializable.Serialize(new[] { testCase1 , testCase2 } );
            var afterDeserialize = deserializer.Deserialize(stream);
        }
    }
}
