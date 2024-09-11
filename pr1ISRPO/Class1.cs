using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1ISRPO
{
    internal class Class1
    {
        public double[] func(double[,] matr)
        {
            int str = matr.GetLength(0);
            int stolb = matr.GetLength(1);
            double pr = 1, sum=0, min=10000, max=-10000;
            double[]b = new double[str*4];


            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    pr=pr*matr[i,j];
                }
                b[i] = pr;
            }


            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    sum = sum+matr[i,j];
                }
                b[str+i] = sum/str;
            }


            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    if (matr[i, j] < 0)
                    {
                        b[str+str + i] = matr[i,j];
                    }
                }
            }


            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (matr[i, j] < min)
                    {
                        min = matr[i, j];
                    }
                    if (matr[i, j] > max)
                    {
                        max=matr[i, j];
                    }
                }
                b[str+str+str + i] = max - min;
            }

            return b;
        }
    }
}
