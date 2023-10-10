using System;

namespace Main
{
    public class Main
    {
        public void Koubaihou()
        {

            double[] a_ls = new double[] { 5, 4, 4 };
            double[] a_ls_ans = new double[a_ls.Length];
            Array.Copy(a_ls, a_ls_ans, a_ls.Count());

            List<double> gosa_ls = new List<double>();

            double dx = 0.1;
            double ln = 0.1; //学習率

            int time = 0;

            while (true)
            {
                time++;

                for (int day = 0; day < a_ls.Count(); day++)
                {
                    //x+dxの計算
                    double[] a_ls_plus = new double[a_ls.Count()];
                    Array.Copy(a_ls, a_ls_plus, a_ls.Length);
                    a_ls_plus[day] += dx;
                    double error_p = Tashizan(a_ls_plus);//x+dx

                    //x-dxの計算
                    double[] a_ls_minus = new double[a_ls.Count()];
                    Array.Copy(a_ls, a_ls_minus, a_ls.Length);
                    a_ls_minus[day] -= dx;
                    double error_m = Tashizan(a_ls_minus);//x-dx


                    a_ls_ans[day] = a_ls[day] - (error_p - error_m) * ln;
                }

                double gosa = Tashizan(a_ls_ans);

                if (Math.Abs(gosa_ls[gosa_ls.Count - 1] - gosa) < 0.01) break;
                else if (time > 100) break;
                else
                {
                    gosa_ls.Add(gosa);
                    Array.Copy(a_ls_ans, a_ls, a_ls.Count());
                }
            }

        }

        public double Tashizan(double[] a_ls)
        {
            double error = 0;

            //誤差の計算

            return error;
        }
    }
}
