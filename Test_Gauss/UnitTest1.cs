namespace Test_Gauss
{
    [TestClass]
    public class UnitTest1
    {
        //public static void Gauss_1(int n, double s, double[,] a, double[] b, double[] x)
        //{
        //    for (int k = 0; k < n - 1; k++)
        //    {
        //        for (int i = k + 1; i < n; i++)
        //        {
        //            for (int j = k + 1; j < n; j++)
        //            {
        //                a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
        //            }
        //            b[i] = b[i] - b[k] * a[i, k] / a[k, k];
        //        }
        //    }
        //    for (int k = n - 1; k >= 0; k--)
        //    {
        //        s = 0;
        //        for (int j = k + 1; j < n; j++)
        //            s = s + a[k, j] * x[j];
        //        x[k] = (b[k] - s) / a[k, k];
        //    }
        //}
        //public static void Gauss_2(int n, double s, double[,] a, double[] b, double[] x)
        //{
            
        //}
        [TestMethod]
        public void TestMethod1()
        {

            int n = 2;
            double s = 0;
            double[,] a = new double[n, n];
            double[] b = new double[n];
            double[] x = new double[n];
            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 1;
            a[1, 1] = 1;
            b[0] = 3;
            b[1] = 2;

            double expected1 = 1;
            double expected2 = 1;

            Gauss.Gauss.Gauss_1(n, a, b);
            Gauss.Gauss.Gauss_2(n, s, a, b, x);

            Assert.AreEqual(expected1, x[0]);
            Assert.AreEqual(expected2, x[1]);

            //Assert.IsTrue(expected1 == x[0]);
            //Assert.IsTrue(expected2 == x[1]);

            //if (x[0] != expected1)
            //    Assert.Fail();
        }
    }
}