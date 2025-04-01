using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treug03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string A, B, C;

                A = TA.Text;
                int S = int.Parse(A);

                B = TB.Text;
                int D = int.Parse(B);

                C = TC.Text;
                int F = int.Parse(C);

                if (S < D + F && D < S + F && F < S + D) // проверка есть ли такой треугольник
                {
                    if (D == F && D == S && F == S)
                    {
                        Text2.Text = "это равносторонний треугольник";
                    }
                    else if (D == F || D == S || S == F)
                    {
                        Text2.Text = "это равнобедренный треугольник";
                    }
                    else
                    {
                        Text2.Text = "это разносторонний треугольник";
                    }
                }
                else // иначе если такого треугольника нет
                {
                    Text2.Text = "такого треугольника быть не может";
                }
            }
            catch
            {
                Text2.Text = "неправильный ввод";
            }
        }
    }
}
