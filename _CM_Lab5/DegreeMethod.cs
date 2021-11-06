using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CM_Lab5
{
    internal class DegreeMethod
    {
        List<List<double>> Mtr;
        double Epsilon;

        List<double> Values = new List<double>();

        public DegreeMethod(List<List<double>> Mtr, double Epsilon)
        {
            this.Mtr = Mtr;
            this.Epsilon = Epsilon;
            Deg();
        }

        public List<double> GetIterRes
        {
            get
            {
                return Values;
            }
        }

        void Deg()
        {
            double summ = 0, e, d, d0;
            double[] 
                w0 = new double[100], 
                w = new double[100], 
                w0norm = new double[100];
            int i, j;
            w0[0] = 1;
            for(i = 1; i < Mtr.Count; i++)
            {
                w0[i] = 0;
            }
            do
            {
                for(i = 0; i < Mtr.Count; i++)
                {
                    summ = summ + Math.Pow(w0[i], 2);
                }
                d0 = Math.Sqrt(summ);
                for(i = 0; i < Mtr.Count; i++)
                {
                    w0norm[i] = w0[i] / d0;
                }
                for(i = 0; i < Mtr.Count; i++)
                {
                    w[i] = 0;
                    for(j = 0; j < Mtr.Count; j++)
                    {
                        w[i] = w[i] + Mtr[i][j] * w0norm[j];
                    }
                }
                summ = 0;
                for(i = 0; i < Mtr.Count; i++)
                {
                    summ = summ + w[i] * w[i];
                }
                d = Math.Sqrt(summ);
                e = Math.Abs(d - d0);
                for(i = 0; i < Mtr.Count; i++)
                {
                    w0[i] = w[i];
                }
                summ = 0;
                Values.Add(d);
            } 
            while (e > Epsilon);
        }
    }
}
