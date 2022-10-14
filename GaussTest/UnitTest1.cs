namespace GaussTest;
using System;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Razmer1()
        {
        double[,] MatrixCoef = new double[RowAm, RowAm];
        int RowAm = 1;
        var Multi1 = new double[1, 1];
        Multi1[1, 1] = 1;
        var Multi2 = new double[1, 1];
        Multi2[1, 1] = 1;

        for (int k = 0; k < RowAm; k++)
        {
            for (int j = k + 1; j < RowAm; j++)
            {
                Multi1 = MatrixCoef[j, k] / MatrixCoef[k, k];
                for (int i = k; i < RowAm; i++)
                {
                    MatrixCoef[j, i] = MatrixCoef[j, i] - Multi1 * MatrixCoef[k, i];
                }
                FreeCoef[j] = FreeCoef[j] - Multi1 * FreeCoef[k];
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

    }
    }
