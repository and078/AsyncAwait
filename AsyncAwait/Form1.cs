using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        Fibonacci fibonacci = new Fibonacci();
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            //label2.Text = "";
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) button1_Click(button1, null); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fibonacci.Counter = 0;
            label1.Text = "";
            progressBar1.Maximum = SetProgressMax.FibLoop((int)numericUpDown1.Value);
            FibCounter();
            ProgressBarWriter();
        }

        async void FibCounter()
        {
            await Task.Run(() =>
            {
                label1.Text = $"Fibonacci sequence last member of term {(long)numericUpDown1.Value} is {fibonacci.Calculator((long)numericUpDown1.Value).ToString()}";
                //label2.Text = "";
            });

        }
        async void ProgressBarWriter()
        {
            await Task.Run(() =>
            {
                while (progressBar1.Value <= progressBar1.Maximum)
                {
                    progressBar1.Value = fibonacci.Counter;
                    //label2.Text = $"Progress: {fibonacci.Counter.ToString()}";
                }
            });
        }
    }
}
