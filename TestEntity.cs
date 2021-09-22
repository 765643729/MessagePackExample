using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePackExample
{
    [MessagePackObject]
    public class TestEntity
    {
        [Key(0)]
        public int IntTest { get; set; }

        [Key(1)]
        public string StringTest { get; set; }

        [Key(2)]
        public float FloatTest { get; set; }

        [Key(3)]
        public double DoubleTest { get; set; }

        [Key(4)]
        public bool BoolTest { get; set; }

        [Key(5)]
        public int[] IntArrayTest { get; set; }

        [IgnoreMember]
        public string IgnoreMemberTest { get; set; }
    }
}
