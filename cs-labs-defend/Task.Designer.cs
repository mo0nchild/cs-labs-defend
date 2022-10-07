namespace cs_labs_defend
{
    partial class Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.calc_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.value_d_label = new System.Windows.Forms.Label();
            this.value_c_label = new System.Windows.Forms.Label();
            this.value_b_label = new System.Windows.Forms.Label();
            this.value_a_label = new System.Windows.Forms.Label();
            this.value_d_numeric = new System.Windows.Forms.NumericUpDown();
            this.value_c_numeric = new System.Windows.Forms.NumericUpDown();
            this.value_b_numeric = new System.Windows.Forms.NumericUpDown();
            this.value_a_numeric = new System.Windows.Forms.NumericUpDown();
            this.rst_button = new System.Windows.Forms.Button();
            this.max_label = new System.Windows.Forms.Label();
            this.max_textbox = new System.Windows.Forms.TextBox();
            this.min_label = new System.Windows.Forms.Label();
            this.min_textbox = new System.Windows.Forms.TextBox();
            this.input_button = new System.Windows.Forms.Button();
            this.input_numeric = new System.Windows.Forms.NumericUpDown();
            this.input_listbox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_d_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_c_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_b_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_a_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.min_label);
            this.tabPage1.Controls.Add(this.rst_button);
            this.tabPage1.Controls.Add(this.input_listbox);
            this.tabPage1.Controls.Add(this.max_label);
            this.tabPage1.Controls.Add(this.input_numeric);
            this.tabPage1.Controls.Add(this.max_textbox);
            this.tabPage1.Controls.Add(this.input_button);
            this.tabPage1.Controls.Add(this.min_textbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.calc_button);
            this.tabPage2.Controls.Add(this.value_a_label);
            this.tabPage2.Controls.Add(this.result_label);
            this.tabPage2.Controls.Add(this.value_a_numeric);
            this.tabPage2.Controls.Add(this.result_textbox);
            this.tabPage2.Controls.Add(this.value_b_numeric);
            this.tabPage2.Controls.Add(this.value_d_label);
            this.tabPage2.Controls.Add(this.value_c_numeric);
            this.tabPage2.Controls.Add(this.value_c_label);
            this.tabPage2.Controls.Add(this.value_d_numeric);
            this.tabPage2.Controls.Add(this.value_b_label);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // calc_button
            // 
            this.calc_button.Location = new System.Drawing.Point(223, 173);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(150, 29);
            this.calc_button.TabIndex = 21;
            this.calc_button.Text = "вычислить";
            this.calc_button.UseVisualStyleBackColor = true;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(38, 150);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(74, 20);
            this.result_label.TabIndex = 20;
            this.result_label.Text = "Решение:";
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(38, 173);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(150, 27);
            this.result_textbox.TabIndex = 19;
            // 
            // value_d_label
            // 
            this.value_d_label.AutoSize = true;
            this.value_d_label.Location = new System.Drawing.Point(223, 93);
            this.value_d_label.Name = "value_d_label";
            this.value_d_label.Size = new System.Drawing.Size(94, 20);
            this.value_d_label.TabIndex = 18;
            this.value_d_label.Text = "Значение D:";
            // 
            // value_c_label
            // 
            this.value_c_label.AutoSize = true;
            this.value_c_label.Location = new System.Drawing.Point(38, 93);
            this.value_c_label.Name = "value_c_label";
            this.value_c_label.Size = new System.Drawing.Size(92, 20);
            this.value_c_label.TabIndex = 17;
            this.value_c_label.Text = "Значение C:";
            // 
            // value_b_label
            // 
            this.value_b_label.AutoSize = true;
            this.value_b_label.Location = new System.Drawing.Point(223, 37);
            this.value_b_label.Name = "value_b_label";
            this.value_b_label.Size = new System.Drawing.Size(92, 20);
            this.value_b_label.TabIndex = 16;
            this.value_b_label.Text = "Значение B:";
            // 
            // value_a_label
            // 
            this.value_a_label.AutoSize = true;
            this.value_a_label.Location = new System.Drawing.Point(38, 37);
            this.value_a_label.Name = "value_a_label";
            this.value_a_label.Size = new System.Drawing.Size(93, 20);
            this.value_a_label.TabIndex = 15;
            this.value_a_label.Text = "Значение A:";
            // 
            // value_d_numeric
            // 
            this.value_d_numeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.value_d_numeric.Location = new System.Drawing.Point(223, 116);
            this.value_d_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.value_d_numeric.Name = "value_d_numeric";
            this.value_d_numeric.Size = new System.Drawing.Size(150, 27);
            this.value_d_numeric.TabIndex = 14;
            // 
            // value_c_numeric
            // 
            this.value_c_numeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.value_c_numeric.Location = new System.Drawing.Point(38, 116);
            this.value_c_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.value_c_numeric.Name = "value_c_numeric";
            this.value_c_numeric.Size = new System.Drawing.Size(150, 27);
            this.value_c_numeric.TabIndex = 13;
            // 
            // value_b_numeric
            // 
            this.value_b_numeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.value_b_numeric.Location = new System.Drawing.Point(223, 63);
            this.value_b_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.value_b_numeric.Name = "value_b_numeric";
            this.value_b_numeric.Size = new System.Drawing.Size(150, 27);
            this.value_b_numeric.TabIndex = 12;
            // 
            // value_a_numeric
            // 
            this.value_a_numeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.value_a_numeric.Location = new System.Drawing.Point(38, 63);
            this.value_a_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.value_a_numeric.Name = "value_a_numeric";
            this.value_a_numeric.Size = new System.Drawing.Size(150, 27);
            this.value_a_numeric.TabIndex = 11;
            // 
            // rst_button
            // 
            this.rst_button.Location = new System.Drawing.Point(275, 113);
            this.rst_button.Name = "rst_button";
            this.rst_button.Size = new System.Drawing.Size(150, 34);
            this.rst_button.TabIndex = 15;
            this.rst_button.Text = "удалить";
            this.rst_button.UseVisualStyleBackColor = true;
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(172, 207);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(37, 20);
            this.max_label.TabIndex = 14;
            this.max_label.Text = "max";
            // 
            // max_textbox
            // 
            this.max_textbox.Location = new System.Drawing.Point(172, 230);
            this.max_textbox.Name = "max_textbox";
            this.max_textbox.ReadOnly = true;
            this.max_textbox.Size = new System.Drawing.Size(125, 27);
            this.max_textbox.TabIndex = 13;
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(24, 207);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(34, 20);
            this.min_label.TabIndex = 12;
            this.min_label.Text = "min";
            // 
            // min_textbox
            // 
            this.min_textbox.Location = new System.Drawing.Point(6, 230);
            this.min_textbox.Name = "min_textbox";
            this.min_textbox.ReadOnly = true;
            this.min_textbox.Size = new System.Drawing.Size(125, 27);
            this.min_textbox.TabIndex = 11;
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(275, 73);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(150, 34);
            this.input_button.TabIndex = 10;
            this.input_button.Text = "добавить";
            this.input_button.UseVisualStyleBackColor = true;
            // 
            // input_numeric
            // 
            this.input_numeric.DecimalPlaces = 2;
            this.input_numeric.Location = new System.Drawing.Point(275, 30);
            this.input_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.input_numeric.Name = "input_numeric";
            this.input_numeric.Size = new System.Drawing.Size(150, 27);
            this.input_numeric.TabIndex = 9;
            // 
            // input_listbox
            // 
            this.input_listbox.FormattingEnabled = true;
            this.input_listbox.ItemHeight = 20;
            this.input_listbox.Location = new System.Drawing.Point(6, 30);
            this.input_listbox.Name = "input_listbox";
            this.input_listbox.Size = new System.Drawing.Size(248, 164);
            this.input_listbox.TabIndex = 8;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 457);
            this.Controls.Add(this.tabControl1);
            this.Name = "Task";
            this.Text = "Task";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_d_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_c_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_b_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_a_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button calc_button;
        private Label value_a_label;
        private Label result_label;
        private NumericUpDown value_a_numeric;
        private TextBox result_textbox;
        private NumericUpDown value_b_numeric;
        private Label value_d_label;
        private NumericUpDown value_c_numeric;
        private Label value_c_label;
        private NumericUpDown value_d_numeric;
        private Label value_b_label;
        private Label min_label;
        private Button rst_button;
        private ListBox input_listbox;
        private Label max_label;
        private NumericUpDown input_numeric;
        private TextBox max_textbox;
        private Button input_button;
        private TextBox min_textbox;
    }
}