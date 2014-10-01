using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n2
{
    class Polynom
    {
        private int[] a;
        private int degree = 0;
        private int x = 1;
        public string exp = "";
        public Polynom(int x ,int n=2)
        {
            this.a = new int[n+1];
            this.degree = n;
            this.x = x;
        }

        public void SetFactors(int n=0)
        {
            if (n < degree+1)
            {
               
                Console.Write("Введите коэффициент {0} степень = ",n);
                a[n] = int.Parse(Console.ReadLine());
                exp = exp.Insert(0, (a[n] > 0) ? (n + 1 > degree) ? string.Format("{0}*{1}^{2}", a[n], this.x, n) : string.Format("+{0}*{1}^{2}", a[n], this.x, n) : a[n].ToString());
                SetFactors(++n);
            }
        }

        public int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < degree+1;i++ )
            {
                sum += (i == 0) ? a[i] : a[i] * (int)Math.Pow(this.x, i);
            }
            return sum;
        }

      
        
        
    }
}
