using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P_I_6
{
    internal class ZnachenieNelineynogoYrovneniy
    {
        public delegate double del(double x);
        public delegate void notification(string Str);
        public event notification Notification;

        private double X { get; set; }
        private double Eps { get; set; }

        public double eps
        {
            get
            { return Eps; }
            set
            { Eps = value; }
        }


        public ZnachenieNelineynogoYrovneniy()
        {
        }
        public void error()
        {
            Notification.Invoke("Точность должна быть вещественным числом");
        }
        public double Function_1(double x)
        {
            return Math.Sin(x + 1) - 2 * Math.Pow((x + 3), 3);
        }

        public double Function_2(double x)
        {
            return Math.Pow(x, 3) - Math.Pow(x, 2) + 4 * x - 1;
        }

        public double ProizvodnayFunction_1(double x)
        {
            return Math.Cos(x + 1) - 6 * Math.Pow((x + 3), 2);
        }

        public double ProizvodnayFunction_2(double x)
        {
            return 3 * Math.Pow(x, 2) - 2 * x + 4;
        }

        public double[] SchagoviyMetod(del Function)
        {
            double[] interval = new double[2];
            double[] znach_int = new double[2];
            double i = -10;
            while (((znach_int[0] >= 0) & (znach_int[1] >= 0)) | ((znach_int[0] < 0) & (znach_int[1] < 0)))
            {
                interval[0] = i;
                znach_int[0] = Function(i);
                i += 0.1;
                interval[1] = i;
                znach_int[1] = Function(i);
            }
            return interval;
        }

        public double MetodNytona(del Function, del ProizvodnayFunction, bool flag)
        {
            string Prom_Rez = "Промежуточный результат:\n\n";
            int num = 1;
            double[] interval = SchagoviyMetod(Function);
            double downX = interval[0];
            X = interval[1];
            while (Math.Abs(downX - X) > Eps) 
            {
                downX = X;
                X = X - Function(X) / ProizvodnayFunction(X);
                Prom_Rez += $"Итерация {num}: Результат: X = {X}, Точность E = {Math.Abs(downX - X)} \n";
                num++;
            }
            if (flag == true)
                Notification.Invoke(Prom_Rez);
            return X;
        }
        public double MetodPolovinnogoDeleniy(del Function, bool flag)
        {
            string Prom_Rez = "Промежуточный результат:\n\n";
            int num = 1;
            double[] A_B = SchagoviyMetod(Function);
            this.X = (A_B[0] + A_B[1])/2;
            double F_A = Function(A_B[0]);
            double F_X = Function(X);
            double ProizvedenieF_A_F_X = F_A * F_X;
            while (Math.Abs(F_X) > Eps)
            {
                if (ProizvedenieF_A_F_X > 0) 
                    A_B[0] = this.X;
                if (ProizvedenieF_A_F_X < 0)
                    A_B[1] = this.X;
                this.X = (A_B[0] + A_B[1]) / 2;
                F_A = Function(A_B[0]);
                F_X = Function(X);
                ProizvedenieF_A_F_X = F_A * F_X;
                Prom_Rez += $"Итерация {num}: Результат: X = {this.X}, Точность E = {F_X} \n";
                num++;
            }
            if (flag == true)
                Notification.Invoke(Prom_Rez);
            return X;
        }

    }
}
