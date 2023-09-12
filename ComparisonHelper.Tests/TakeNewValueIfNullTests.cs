using ComparisonHelper.Tests.Models;
using NUnit.Framework;

namespace ComparisonHelper.Tests
{
    [TestFixture]
    internal class TakeNewValueIfNullTests
    {
        [Test]
        public static void Should_Take_New_Value_If_Value_Is_Null()
        {
            var updateCount = 0;
            var testObject = new NullableTestModel();

            testObject.IntProperty = ComparisonHelper.TakeNewValueIfNull(testObject.IntProperty, 7, ref updateCount);
            testObject.StringProperty = ComparisonHelper.TakeNewValueIfNull(testObject.StringProperty, "Swag", ref updateCount);

            Assert.AreEqual(7, testObject.IntProperty);
            Assert.AreEqual("Swag", testObject.StringProperty);
            Assert.AreEqual(2, updateCount);
        }

        [Test]
        public static void Should_Not_Take_New_Value_If_Value_Is_Not_Null()
        {
            var updateCount = 0;
            var testObject = new NullableTestModel
            {
                IntProperty = 1,
                StringProperty = "Yolo",
            };

            testObject.IntProperty = ComparisonHelper.TakeNewValueIfNull(testObject.IntProperty, 7, ref updateCount);
            testObject.StringProperty = ComparisonHelper.TakeNewValueIfNull(testObject.StringProperty, "Swag", ref updateCount);

            Assert.AreEqual(1, testObject.IntProperty);
            Assert.AreEqual("Yolo", testObject.StringProperty);
            Assert.AreEqual(0, updateCount);
        }
    }
}
