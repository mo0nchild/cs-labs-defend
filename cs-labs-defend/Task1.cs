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
    using cs_labs_defend.WinFormsApp1;
    using Microsoft.VisualBasic.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace WinFormsApp1
    {
        public class Logic
        {
            public struct LogReturn
            {
                public List<double> Vs;
                public double result;
            }

            public LogReturn Task1(List<List<double>> arr)
            {

                double max_S = int.MinValue;

                List<double> vs = new List<double>();

                double result = (double)default;
                LogReturn log = new LogReturn();
                for (int i = 0; i < arr.Count; i++)
                {
                    double temp = (double)default;
                    for (int j = 0; j < arr[i].Count; j++)
                    {
                        temp += arr[i][j];
                    }
                    if (temp > max_S)
                    {
                        vs.Clear();
                        max_S = temp;
                        for (int j = 0; j < arr[i].Count; j++)
                        {
                            vs.Add(arr[i][j]);
                        }
                    }
                    if (temp == max_S)
                    {
                        result = i;
                    }

                    
                    log.result = result;
                    log.Vs = vs;

                }

                return log;
            }


            public LogReturn Task2(List<List<double>> arr, int column_max)
            {
                double min_S = double.MaxValue, result = (double)default;
                List<double> vs = new List<double>();

                double[] column_buffer = new double[column_max];

                for (int i = arr.Count - 1; i >= 0; i--)
                {
                    for (int j = arr[i].Count - 1; j >= 0; j--) column_buffer[j] += arr[i][j];
                }
                for(var i = 0; i < column_buffer.Length; i++) 
                {
                    if (column_buffer[i] < min_S) 
                    {
                        result = i;
                        min_S = column_buffer[i];
                    }
                }
                vs.Clear();
                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr[i].Count; j++) 
                    {
                        if (result == j)
                        {

                            vs.Add(arr[i][j]);
                        }
                    }
                        
                }

                Console.WriteLine(result);


                LogReturn log = new LogReturn();
                log.result = result;
                log.Vs = vs;
                return log;
            }

        }
    }

    public partial class Task1 : Form
    {
        private List<double> current_row = new();
        private List<List<double>> matrix = new();
        private double max_column = 0;

        private Logic logic = new();
        public Task1()
        {
            this.InitializeComponent();

            this.add_button.Click += Add_button_Click;
            this.calc_button.Click += Calc_button_Click;
            this.setvalues_button.Click += Setvalues_button_Click;
            this.clear_button.Click += Clear_button_Click;
        }

        private void Clear_button_Click(object? sender, EventArgs e)
        {
            this.matrix = new();
            this.current_row = new();

            this.array_listview.Items.Clear();
            this.rowsum_listview.Items.Clear();
            this.columnsum_listview.Items.Clear();
            this.value_listview.Items.Clear();

            this.column_textbox.Text = "";
            this.row_textbox.Text = "";
            max_column = 0;
    }

        private void Setvalues_button_Click(object? sender, EventArgs e)
        {
            if (this.max_column > this.current_row.Count)
            {
                var m = current_row.Count;
                for (int i = 0; i < (max_column - m); i++) current_row.Add(0);
            }
            else 
            {
                for (int i = 0; i < this.matrix.Count; i++)
                {
                    var column_count = this.matrix[i].Count;
                    for (int j = 0; j < current_row.Count - max_column; j++) this.matrix[i].Add(0);
                }
                this.max_column = this.current_row.Count;
            }

            this.matrix.Add(current_row);

            this.value_listview.Items.Clear();
            this.array_listview.Items.Clear();
            foreach (var row in this.matrix) 
            {
                string row_string = "";
                foreach (var item in row) row_string += $"{item}, ";
                
                this.array_listview.Items.Add(row_string);
            }

            this.current_row = new();
        }

        private void Calc_button_Click(object? sender, EventArgs e)
        {
            if (matrix.Count == 0) return; 

            List<double> row_calc = new(), column_calc = new();
            double[] buffer = new double[(int)this.max_column];

            this.columnsum_listview.Items.Clear();
            this.rowsum_listview.Items.Clear();

            for (int i = 0; i < this.matrix.Count; i++) 
            {
                double value = 0;
                //foreach (var item in matrix[i]) value += item;
                for (int j = 0; j < this.matrix[i].Count; j++) 
                {
                    value += this.matrix[i][j];
                    buffer[j] += this.matrix[i][j];
                }

                string[] rowviewlist = { $"Строка: {i + 1}", value.ToString() };
                this.rowsum_listview.Items.Add(new ListViewItem(rowviewlist));
            }

            for (var i = 0; i < buffer.Length; i++) 
            {
                string[] columnviewlist = { $"Строка: {i + 1}", buffer[i].ToString() };
                this.columnsum_listview.Items.Add(new ListViewItem(columnviewlist));
            }

            var row_result = this.logic.Task1(this.matrix);
            var column_result = this.logic.Task2(this.matrix, (int)this.max_column);

            this.row_textbox.Text = $"[{row_result.result}]: ";
            foreach (double i in row_result.Vs) 
            {
                this.row_textbox.Text += $"{i}, ";
            }
            this.column_textbox.Text = $"[{column_result.result}]: ";
            foreach (double i in column_result.Vs)
            {
                this.column_textbox.Text += $"{i}, ";
            }
        }

        private void Add_button_Click(object? sender, EventArgs e)
        {
            var value = (double)this.value_numeric.Value;
            this.current_row.Add(value);

            var item = new ListViewItem(new String[] { $"Item1: {this.current_row.Count}", value.ToString() });
            this.value_listview.Items.Add(item);
        }
    }
}
