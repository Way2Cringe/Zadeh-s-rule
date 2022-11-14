using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NM2
{
    public partial class Form1 : Form
    {
        Trapeze x1, x2, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            Build();
        }
        private void Build()
        {
            try
            {
                x1 = new Trapeze((double)numericUpDown_x1_1.Value, (double)numericUpDown_x1_2.Value, (double)numericUpDown_x1_3.Value, (double)numericUpDown_x1_4.Value);
                x2 = new Trapeze((double)numericUpDown_x2_1.Value, (double)numericUpDown_x2_2.Value, (double)numericUpDown_x2_3.Value, (double)numericUpDown_x2_4.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            y = x1 * x2;
            var x1Arr = x1.getPointsArray(x1.p1 - 0.5, x1.p4 + 0.5, (int) numericUpDown_x_amount.Value);
            var x2Arr = x2.getPointsArray(x2.p1 - 0.5, x2.p4 + 0.5, (int) numericUpDown_x_amount.Value);
            var yArr = y.getPointsArray(y.p1 - 0.5, y.p4 + 0.5, (int)numericUpDown_y_amount.Value);
            var yMultArr = MultiplyArr(x1Arr, x2Arr);

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            foreach (var p in yArr) chart1.Series[0].Points.AddXY(p.x, p.y);
            foreach (var p in yMultArr) chart1.Series[1].Points.AddXY(p.x, p.y);
        }
        private (double x, double y)[] MultiplyArr((double x, double y)[] Arr1, (double x, double y)[] Arr2)
        {
            List<(double x, double y)> ResultList = new List<(double x, double y)>();
            foreach(var el1 in Arr1)
            {
                foreach (var el2 in Arr2)
                {
                    ResultList.Add((el1.x * el2.x, el1.y * el2.y));
                }
            }
            ResultList.Sort((o1,o2) => o1.x.CompareTo(o2.x));
            return ResultList.ToArray();
        }
    }
}
