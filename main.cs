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
            expression = expression.Replace("cos", "System.Math.Cos");
            expression = expression.Replace("sin", "System.Math.Sin");
            expression = expression.Replace("tan", "System.Math.Tan");
            expression = expression.Replace("pow", "System.Math.Pow");
            expression = expression.Replace("sqrt", "System.Math.Sqrt");
            expression = expression.Replace("log", "System.Math.Log");
            expression = expression.Replace("pi", "System.Math.PI");
            expression = expression.Replace("e", "System.Math.E");
            expression = expression.Replace("exp", "System.Math.Exp");

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
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
