using ComparisonHelper.Tests.Models;
using NUnit.Framework;

namespace ComparisonHelper.Tests
{

    [TestFixture]
    internal class TakeNewValueIfChangedTests
    {
        [Test]
        public static void Should_Take_New_Value_If_Value_Changed()
        {
            var updateCount = 0;
            var testObject = new TestModel
            {
                IntProperty = 1,
                StringProperty = "Yolo",
            };

            testObject.IntProperty = ComparisonHelper.TakeNewValueIfChanged(testObject.IntProperty, 7, ref updateCount);
            testObject.StringProperty = ComparisonHelper.TakeNewValueIfChanged(testObject.StringProperty, "Swag", ref updateCount);

            Assert.AreEqual(7, testObject.IntProperty);
            Assert.AreEqual("Swag", testObject.StringProperty);
            Assert.AreEqual(2, updateCount);
        }

        [Test]
        public static void Should_Not_Take_New_Value_If_Value_Is_Same()
        {
            var updateCount = 0;
            var testObject = new TestModel
            {
                IntProperty = 1,
                StringProperty = "Yolo",
            };

            testObject.IntProperty = ComparisonHelper.TakeNewValueIfChanged(testObject.IntProperty, 1, ref updateCount);
            testObject.StringProperty = ComparisonHelper.TakeNewValueIfChanged(testObject.StringProperty, "Yolo", ref updateCount);

            Assert.AreEqual(1, testObject.IntProperty);
            Assert.AreEqual("Yolo", testObject.StringProperty);
            Assert.AreEqual(0, updateCount);
        }
    }
}