using System;
using System.Drawing;
using System.Windows.Forms;
using Z.Expressions;// библиотека для динамического решения функций

namespace Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static double f(double x)
        {
            return Math.Pow(x, 3) - 18 * x - 83;
        }

        private double Trapezium_Method(double a, double b, double n, string func)
        {
            double h, res;
            double sum = 0;
            double xi, xi1;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                xi = a + i * h;
                xi1 = a + (i + 1) * h;
                sum += f(xi) + f(xi1);
            }
            res = sum * h / 2;

            return (res);
        }

        private double Method_Chord(double a, double b, double n, string func)
        {
            double x_next = 0;
            double tmp;

            do
            {
                tmp = x_next;
                x_next = b - f(b) * (a - b) / (f(a) - f(b));
                a = b;
                b = tmp;
            } while (Math.Abs(x_next - b) > n);

            return x_next;
        }

        private void button_Answer_Click(object sender, EventArgs e)
        {
            try
            {
                string func = rtbFunc.Text;// строка с функцией

                // переменные, хранящие ответы вызываемых методов
                double AnsInteger = Trapezium_Method(Convert.ToDouble(tA.Text), Convert.ToDouble(tB.Text), Convert.ToDouble(tN.Text), func);
                double AnsDich = Method_Chord(Convert.ToDouble(tA.Text), Convert.ToDouble(tB.Text), Convert.ToDouble(tEps.Text), func);

                // вывод ответа
                label5.Text = "Интегралл = " + AnsInteger.ToString();
                label6.Text = "Ответ = " + AnsDich.ToString();
            }
            catch (Exception)// в случае, если вдруг возникнет ошибка
            {
                rtbFunc.BackColor = Color.Red;// программа даст об этом знать
                //Refresh();                    // перекрасив область для ввода формулы в красный цвет

                //Thread.Sleep(1000); // и приостановив саму программу на 1 секунду, чтобы изменение цвета области было видно

                //rtbTable.BackColor = Color.White;// а после все вернется в норму
                //Refresh();
            }
        }
    }
}
