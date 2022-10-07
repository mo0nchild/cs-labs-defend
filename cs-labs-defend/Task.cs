using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_labs_defend
{
    public partial class Task : Form
    {
        private List<double> values = new();
        public Task()
        {
            InitializeComponent();

            this.input_button.Click += new EventHandler(InputButtonClick);
            this.rst_button.Click += new EventHandler(ResetButtonClick);
            this.calc_button.Click += new EventHandler(CalculateButtonClick);
        }

        private void InputButtonClick(object? sender, EventArgs arg)
        {
            if (this.values.Count >= 7) return;

            var input_value = (double)this.input_numeric.Value;
            this.values.Add(input_value);
            this.input_listbox.Items.Add(string.Format("значение {0}: {1:f2}", this.values.Count, input_value));

            if (this.values.Count >= 7)
            {
                double min = double.MaxValue, max = double.MinValue;
                foreach (var value in this.values)
                {
                    if (min > value) min = value;
                    if (max < value) max = value;
                }

                this.min_textbox.Text = Math.Round(min).ToString();
                this.max_textbox.Text = Math.Round(max).ToString();
            }
        }

        private void ResetButtonClick(object? sender, EventArgs arg)
        {
            this.input_listbox.Items.Clear();
            this.values.Clear();
            this.min_textbox.Text = "";
            this.max_textbox.Text = "";
        }

        private void CalculateButtonClick(object? sender, EventArgs arg)
        {
            double a = (double)this.value_a_numeric.Value,
                b = (double)this.value_b_numeric.Value,
                c = (double)this.value_c_numeric.Value,
                d = (double)this.value_d_numeric.Value;

            if ((b == 0 && a == 0) || c == 0 && d == 0)
            {
                if (b == 0 && a == 0) this.result_textbox.Text = "INF";
                if (c == 0 && d == 0) this.result_textbox.Text = "NO";
                return;
            }

            this.result_textbox.Text = Math.Round(-(b / a)).ToString();
        }
    }
}
