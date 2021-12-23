using System;
namespace MyCount
{
    public class Count
    {
        public int values(double s, double S, double K, double R1, double R2, double R3)
        {

            if (s > 0 & S > 0 & K > 0.47 & R1 > 0 & R2 > 0 & R3 > 0)
            {
                double R0 = Math.Sqrt(s / Math.PI);
                double R = Math.Sqrt(S / Math.PI);
                double L = K * Math.Pow (R0 / R, 2);
                double D1 = 2 * R1;
                double D2 = 2 * R2;
                double D3 = 2 * R3;
                double C = Math.Pow(D1, 2.5) + Math.Pow(D2, 1.5) + Math.Pow(D3, 0.5);
                int N = Convert.ToInt32(L / C);
                Console.WriteLine("Количество станций:");
                Console.WriteLine(N);
                return N;
             }
            return 8;
        }
    }
}
