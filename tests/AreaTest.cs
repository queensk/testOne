using sendMessage.Rectangle;

namespace tests
{
    public class AreaTestCl
    {
        public static object[] RectangleData =
        {
            new object[] { 2, 3, 6 },
            new object[] { 4, 5, 20 },
            new object[] { 6, 7, 42 }
        };

        [Test]
        [TestCaseSource("RectangleData")]
        public void AreaTest(int length, int width, int expectedArea)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = length;
            rectangle.Width = width;

            int actualArea = rectangle.Area();
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }
    }
}