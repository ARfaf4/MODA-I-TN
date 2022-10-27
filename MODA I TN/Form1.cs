using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODA_I_TN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Buton za sredno aritmetcihno
        private void button3_Click(object sender, EventArgs e)
        {
            string[] split = textBox1.Text.Split(' ');
            List<int> values = split.Select(x=> int.Parse(x)).ToList();
            double sum = 0;
            foreach (var item in values)
            {
                sum = sum + item;
            }
            double avg = sum / values.Count;
            label2.Text = "Average is: " + avg;
        }
        //Buton za mediana
        private void button2_Click(object sender, EventArgs e)
        {
            string[] split = textBox1.Text.Split(' ');
            List<int> values = split.Select(x => int.Parse(x)).ToList();
            values.Sort();
            double median = 0;
            if (values.Count % 2 ==0)
            {
                int midIndex = values.Count / 2;
                var item1 = values[midIndex];
                var item2 = values[midIndex-1];
                median = (item1 + item2) / 2;
            }
            else
            {
                int midIndex = values.Count / 2;
                median = values[midIndex];
            }
            label3.Text = "Median is: " + median;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] split = textBox1.Text.Split(' ');
            List<int> values = split.Select(x => int.Parse(x)).ToList();
            int? modeValue =  values.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).Select(x => (int?)x.Key).FirstOrDefault();
            label1.Text = "Mode is: " + modeValue;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
