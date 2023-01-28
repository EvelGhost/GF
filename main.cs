using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphiccFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double Parse(string expression)
        {
            return CSharpScript.EvaluateAsync<double>(expression).Result;
        }
        static string Evaluate(string expression, double x)
        {
            Form1 f= new Form1();
            expression = expression.Replace("x", x.ToString());

            return expression;
        }

        private void drawOnlyGrphicOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            try
            {
                double a = Convert.ToDouble(aSideTextBox.Text),
                    b = Convert.ToDouble(bSideTextBox.Text),
                    h = Convert.ToDouble(canvasWalkTextBox.Text);
                double x = Convert.ToDouble(xBlueTextBox.Text), y;
                while (x <= b)
                {
                    y = Parse(Evaluate(yBlueTextBox.Text, x));
                    chart1.Series[0].Points.AddXY(x,y);
                    x += h;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
