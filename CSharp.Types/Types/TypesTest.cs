using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Types.Types
{
    [TestClass]
    public class TypesTest
    {
        [TestMethod]
        public void GetAllDataTypes()
        {
            var dataTypes = DataTypes();

            FormatOutput();
            foreach (var dataType in dataTypes)
                Console.WriteLine("{0,-10} {1,-20} {2,-50} {3,-5}", dataType.Type, dataType.CLRType, dataType.Range,
                    dataType.DefaultValue);
        }

        [TestMethod]
        public void Type_Integer()
        {
            var dataTypeValue = 5;
            Assert.AreEqual("Int32", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_String()
        {
            var dataTypeValue = "Captain America";
            Assert.AreEqual("String", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_Char()
        {
            var dataTypeValue = '\u2500';
            Assert.AreEqual("Char", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_Decimal()
        {
            var dataTypeValue = 3.55M;
            Assert.AreEqual("Decimal", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_Double()
        {
            var dataTypeValue = 3.55D;
            Assert.AreEqual("Double", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_Single()
        {
            var dataTypeValue = 3.55F;
            Assert.AreEqual("Single", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_Boolean()
        {
            var dataTypeValue = true;
            Assert.AreEqual("Boolean", dataTypeValue.GetType().Name);
        }

        [TestMethod]
        public void Type_Byte()
        {
            var dataTypeValue = Convert.ToByte(255);
            Assert.AreEqual("Byte", dataTypeValue.GetType().Name);
        }

        private static List<DataType> DataTypes()
        {
            sbyte eightBitSignedInteger = 0;
            short sixteenBitSignedInteger = 0;
            int thirtytwoBitSignedInteger = 0;
            long sixtyfourBitsignedInteger = 0L;
            byte eightBitunsignedInteger = 0;
            ushort sixteenBitUnsignedInteger = 0;
            uint thirtytwoBitUnsignedInteger = 0;
            ulong sixtyfourBitUnsignedInteger = 0;
            char UTFSixteenCodeUnitCharacter = '\0';
            float singlepreciationPointfloatingNumber = 0.0F;
            double doublepreciationPointfloatingNumber = 0.0D;
            decimal decimalNumber = 0.0M;
            bool boolean = false;


            return new List<DataType>
            {
                new DataType
                {
                    Type = "sbyte",
                    CLRType = eightBitSignedInteger.GetType().FullName,
                    DefaultValue = eightBitSignedInteger.ToString(),
                    Range = $"{sbyte.MinValue} to {sbyte.MaxValue}"
                },
                new DataType
                {
                    Type = "short",
                    CLRType = sixteenBitSignedInteger.GetType().FullName,
                    DefaultValue = sixteenBitSignedInteger.ToString(),
                    Range = $"{short.MinValue} to {short.MaxValue}"
                },
                new DataType
                {
                    Type = "int",
                    CLRType = thirtytwoBitSignedInteger.GetType().FullName,
                    DefaultValue = thirtytwoBitSignedInteger.ToString(),
                    Range = $"{int.MinValue} to {int.MaxValue}"
                },
                new DataType
                {
                    Type = "long",
                    CLRType = sixtyfourBitsignedInteger.GetType().FullName,
                    DefaultValue = sixtyfourBitsignedInteger.ToString("0L"),
                    Range = $"{long.MinValue:E} to {long.MaxValue:E}"
                },
                new DataType
                {
                    Type = "byte",
                    CLRType = eightBitunsignedInteger.GetType().FullName,
                    DefaultValue = eightBitunsignedInteger.ToString(),
                    Range = $"{byte.MinValue} to {byte.MaxValue}"
                },
                new DataType
                {
                    Type = "ushort",
                    CLRType = sixteenBitUnsignedInteger.GetType().FullName,
                    DefaultValue = sixteenBitUnsignedInteger.ToString(),
                    Range = $"{ushort.MinValue} to {ushort.MaxValue}"
                },
                new DataType
                {
                    Type = "uint",
                    CLRType = thirtytwoBitUnsignedInteger.GetType().FullName,
                    DefaultValue = thirtytwoBitUnsignedInteger.ToString(),
                    Range = $"{uint.MinValue} to {uint.MaxValue}"
                },
                new DataType
                {
                    Type = "ulong",
                    CLRType = sixtyfourBitUnsignedInteger.GetType().FullName,
                    DefaultValue = sixtyfourBitUnsignedInteger.ToString(),
                    Range = $"{ulong.MinValue} to {ulong.MaxValue}"
                },
                new DataType
                {
                    Type = "char",
                    CLRType = UTFSixteenCodeUnitCharacter.GetType().FullName,
                    DefaultValue = "\\0",
                    Range = "U +0000 to  U +ffff"
                },
                new DataType
                {
                    Type = "float",
                    CLRType = singlepreciationPointfloatingNumber.GetType().FullName,
                    DefaultValue = singlepreciationPointfloatingNumber.ToString("0.0F"),
                    Range = $"{float.MinValue:E} to {float.MaxValue:E}"
                },
                new DataType
                {
                    Type = "double",
                    CLRType = doublepreciationPointfloatingNumber.GetType().FullName,
                    DefaultValue = doublepreciationPointfloatingNumber.ToString("0.0D"),
                    Range = $"{double.MinValue:E} to {double.MaxValue:E}"
                },
                new DataType
                {
                    Type = "decimal",
                    CLRType = decimalNumber.GetType().FullName,
                    DefaultValue = decimalNumber.ToString("0.0M"),
                    Range = $"{decimal.MinValue:E2} to {decimal.MaxValue:E2}"
                }
                ,
                new DataType
                {
                    Type = "bool",
                    CLRType = boolean.GetType().FullName,
                    DefaultValue = boolean.ToString(),
                    Range = $"{bool.TrueString} to {bool.FalseString}"
                }
            };
        }
        private static string RepeatIt(char c, int length)
        {

            return new string(c, length);
        }
        public class DataType
        {
            public string Type { get; set; }
            public string CLRType { get; set; }
            public string Range { get; set; }
            public string DefaultValue { get; set; }
        }

        private void FormatOutput()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-50} {3,-5}", "Type", "CLR Type", "Range", "Default Value");
            Console.WriteLine(RepeatIt('\u2500', 100));
        }
    }
}
