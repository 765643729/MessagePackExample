using MessagePack;
using System;

namespace MessagePackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var entity = new TestEntity()
            {
                BoolTest = true,
                DoubleTest = 123.003,
                FloatTest = 564.36f,
                IntArrayTest = new int[3] { 3, 2, 4 },
                IntTest = 99,
                StringTest = "测试StringTest",
                IgnoreMemberTest = "测试IgnoreMemberTest",
            };

            var json = MessagePackSerializer.SerializeToJson(entity);
            var data = MessagePackSerializer.Serialize(entity);
            Console.WriteLine(json);
            Console.WriteLine(data);

            TestEntity entityFromBlob = MessagePackSerializer.Deserialize<TestEntity>(data);


            Console.Read();
        }
    }
}
