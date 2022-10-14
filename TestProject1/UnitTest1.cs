namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

                        for (int k = 0; k<RowAm; k++)
                {
                    for (int j = k + 1; j<RowAm; j++)
                    {
                        Multi1 = MatrixCoef[j, k] / MatrixCoef[k, k];
                        for (int i = k; i<RowAm; i++)
                        {
                            MatrixCoef[j, i] = MatrixCoef[j, i] - Multi1* MatrixCoef[k, i];
    }
    FreeCoef[j] = FreeCoef[j] - Multi1* FreeCoef[k];
}
                }
                for (int k = RowAm - 1; k >= 0; k--)
{
    Multi1 = 0;
    for (int j = k; j < RowAm; j++)
    {
        Multi2 = MatrixCoef[k, j] * Result[j];
        Multi1 += Multi2;
    }
    Result[k] = (FreeCoef[k] - Multi1) / MatrixCoef[k, k];
}

[TestMethod]
        public void TestMethod1()
        {

        }
    }
}