using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1ISRPO
{
    internal class Class1
    {
        public static double[] func(double[,] matr)
        {
            int str = matr.GetLength(0);
            int stolb = matr.GetLength(1);
            double pr = 1, sum=0, min=10000, max=-10000;
            double[]b = new double[str*2+stolb*2];


            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    pr=pr*matr[i,j];
                }
                b[i] = pr;
                pr = 1;
            }


            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    sum = sum+matr[j,i];
                }
                b[str+i] = sum/str;
                sum = 0;
            }


            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    if (matr[j, i] < 0)
                    { 
                        b[str+stolb + i] = matr[j,i];
                        break;
                    }
                }
                if (b[str + stolb + i] == 0)
                {
                    b[str + stolb + i] = 0;
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
                if(min<0) Math.Abs(min);
                b[str+stolb+stolb+ i] = max - min;
                max = -10000; min = 10000;
            }
            return b;
        }
    }
}
