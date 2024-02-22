using Geom;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Triangle T1 = new Triangle( 1, 3, 2);
            Console.WriteLine(T1.Square);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Circle S1 = new Circle(1);
            Console.WriteLine(S1.Square);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Triangle T1 = new Triangle(-1, 0, 2);
            Console.WriteLine(T1.Square);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Circle S1 = new Circle(-4);
            Console.WriteLine(S1.Square);
        }
    }
}