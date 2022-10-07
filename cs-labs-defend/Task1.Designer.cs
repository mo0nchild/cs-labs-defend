namespace cs_labs_defend
{
    partial class Task1
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
            this.value_listview = new System.Windows.Forms.ListView();
            this.value_name = new System.Windows.Forms.ColumnHeader();
            this.value = new System.Windows.Forms.ColumnHeader();
            this.value_numeric = new System.Windows.Forms.NumericUpDown();
            this.add_button = new System.Windows.Forms.Button();
            this.array_listview = new System.Windows.Forms.ListView();
            this.array = new System.Windows.Forms.ColumnHeader();
            this.value_label = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.rowsum_listview = new System.Windows.Forms.ListView();
            this.rowname = new System.Windows.Forms.ColumnHeader();
            this.rowvalue = new System.Windows.Forms.ColumnHeader();
            this.columnsum_listview = new System.Windows.Forms.ListView();
            this.columnname = new System.Windows.Forms.ColumnHeader();
            this.columnvalue = new System.Windows.Forms.ColumnHeader();
            this.setvalues_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.column_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.row_textbox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.value_numeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // value_listview
            // 
            this.value_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.value_name,
            this.value});
            this.value_listview.Location = new System.Drawing.Point(12, 12);
            this.value_listview.Name = "value_listview";
            this.value_listview.Size = new System.Drawing.Size(150, 198);
            this.value_listview.TabIndex = 0;
            this.value_listview.UseCompatibleStateImageBehavior = false;
            this.value_listview.View = System.Windows.Forms.View.Details;
            // 
            // value_name
            // 
            this.value_name.Text = "Название";
            this.value_name.Width = 80;
            // 
            // value
            // 
            this.value.Text = "Число";
            // 
            // value_numeric
            // 
            this.value_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_numeric.Location = new System.Drawing.Point(12, 239);
            this.value_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.value_numeric.Name = "value_numeric";
            this.value_numeric.Size = new System.Drawing.Size(150, 34);
            this.value_numeric.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(12, 299);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(150, 38);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // array_listview
            // 
            this.array_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.array});
            this.array_listview.Location = new System.Drawing.Point(180, 12);
            this.array_listview.Name = "array_listview";
            this.array_listview.Size = new System.Drawing.Size(229, 261);
            this.array_listview.TabIndex = 3;
            this.array_listview.UseCompatibleStateImageBehavior = false;
            this.array_listview.View = System.Windows.Forms.View.Details;
            // 
            // array
            // 
            this.array.Text = "Массив";
            this.array.Width = 200;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(12, 216);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(83, 20);
            this.value_label.TabIndex = 5;
            this.value_label.Text = "Значение: ";
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_button.Location = new System.Drawing.Point(180, 346);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(229, 38);
            this.calc_button.TabIndex = 9;
            this.calc_button.Text = "Вычислить";
            this.calc_button.UseVisualStyleBackColor = true;
            // 
            // rowsum_listview
            // 
            this.rowsum_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rowname,
            this.rowvalue});
            this.rowsum_listview.Location = new System.Drawing.Point(9, 9);
            this.rowsum_listview.Name = "rowsum_listview";
            this.rowsum_listview.Size = new System.Drawing.Size(229, 160);
            this.rowsum_listview.TabIndex = 10;
            this.rowsum_listview.UseCompatibleStateImageBehavior = false;
            this.rowsum_listview.View = System.Windows.Forms.View.Details;
            // 
            // rowname
            // 
            this.rowname.Text = "Строка";
            this.rowname.Width = 120;
            // 
            // rowvalue
            // 
            this.rowvalue.Text = "Значение";
            this.rowvalue.Width = 100;
            // 
            // columnsum_listview
            // 
            this.columnsum_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnname,
            this.columnvalue});
            this.columnsum_listview.Location = new System.Drawing.Point(9, 175);
            this.columnsum_listview.Name = "columnsum_listview";
            this.columnsum_listview.Size = new System.Drawing.Size(229, 157);
            this.columnsum_listview.TabIndex = 11;
            this.columnsum_listview.UseCompatibleStateImageBehavior = false;
            this.columnsum_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnname
            // 
            this.columnname.Text = "Столбец";
            this.columnname.Width = 120;
            // 
            // columnvalue
            // 
            this.columnvalue.Text = "Значение";
            this.columnvalue.Width = 100;
            // 
            // setvalues_button
            // 
            this.setvalues_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setvalues_button.Location = new System.Drawing.Point(180, 299);
            this.setvalues_button.Name = "setvalues_button";
            this.setvalues_button.Size = new System.Drawing.Size(229, 38);
            this.setvalues_button.TabIndex = 12;
            this.setvalues_button.Text = "Установить";
            this.setvalues_button.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(428, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 372);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rowsum_listview);
            this.tabPage1.Controls.Add(this.columnsum_listview);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.column_textbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.row_textbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Столбец: ";
            // 
            // column_textbox
            // 
            this.column_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.column_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.column_textbox.Location = new System.Drawing.Point(18, 95);
            this.column_textbox.Name = "column_textbox";
            this.column_textbox.ReadOnly = true;
            this.column_textbox.Size = new System.Drawing.Size(207, 34);
            this.column_textbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Строка: ";
            // 
            // row_textbox
            // 
            this.row_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row_textbox.Location = new System.Drawing.Point(18, 35);
            this.row_textbox.Name = "row_textbox";
            this.row_textbox.ReadOnly = true;
            this.row_textbox.Size = new System.Drawing.Size(207, 34);
            this.row_textbox.TabIndex = 0;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_button.Location = new System.Drawing.Point(12, 346);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(150, 38);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 394);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.setvalues_button);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.array_listview);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.value_numeric);
            this.Controls.Add(this.value_listview);
            this.Name = "Task1";
            this.Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)(this.value_numeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView value_listview;
        private ColumnHeader value_name;
        private ColumnHeader value;
        private NumericUpDown value_numeric;
        private Button add_button;
        private ListView array_listview;
        private ColumnHeader array;
        private Label value_label;
        private Button calc_button;
        private ListView rowsum_listview;
        private ColumnHeader rowname;
        private ColumnHeader rowvalue;
        private ListView columnsum_listview;
        private ColumnHeader columnname;
        private ColumnHeader columnvalue;
        private Button setvalues_button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private TextBox column_textbox;
        private Label label1;
        private TextBox row_textbox;
        private Button clear_button;
    }
}