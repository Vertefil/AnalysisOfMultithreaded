namespace parallProg3Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            radBut4 = new RadioButton();
            radBut3 = new RadioButton();
            radBut2 = new RadioButton();
            radBut1 = new RadioButton();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(811, 156);
            button1.Name = "button1";
            button1.Size = new Size(144, 57);
            button1.TabIndex = 0;
            button1.Text = "Calculate!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(361, 380);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radBut4);
            groupBox1.Controls.Add(radBut3);
            groupBox1.Controls.Add(radBut2);
            groupBox1.Controls.Add(radBut1);
            groupBox1.Location = new Point(811, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radBut4
            // 
            radBut4.AutoSize = true;
            radBut4.Location = new Point(6, 96);
            radBut4.Name = "radBut4";
            radBut4.Size = new Size(84, 19);
            radBut4.TabIndex = 3;
            radBut4.Text = "N = 100000";
            radBut4.UseVisualStyleBackColor = true;
            // 
            // radBut3
            // 
            radBut3.AutoSize = true;
            radBut3.Location = new Point(6, 71);
            radBut3.Name = "radBut3";
            radBut3.Size = new Size(72, 19);
            radBut3.TabIndex = 2;
            radBut3.Text = "N = 1000";
            radBut3.UseVisualStyleBackColor = true;
            // 
            // radBut2
            // 
            radBut2.AutoSize = true;
            radBut2.Location = new Point(6, 46);
            radBut2.Name = "radBut2";
            radBut2.Size = new Size(66, 19);
            radBut2.TabIndex = 1;
            radBut2.Text = "N = 100";
            radBut2.UseVisualStyleBackColor = true;
            // 
            // radBut1
            // 
            radBut1.AutoSize = true;
            radBut1.Checked = true;
            radBut1.Location = new Point(6, 21);
            radBut1.Name = "radBut1";
            radBut1.Size = new Size(60, 19);
            radBut1.TabIndex = 0;
            radBut1.TabStop = true;
            radBut1.Text = "N = 10";
            radBut1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(433, 58);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(361, 380);
            dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 23);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 6;
            label1.Text = "Диапазонное выделение";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 23);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 7;
            label2.Text = "Круговая декомпозиция";
            // 
            // button2
            // 
            button2.Location = new Point(811, 236);
            button2.Name = "button2";
            button2.Size = new Size(144, 76);
            button2.TabIndex = 8;
            button2.Text = "Clear row";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(811, 338);
            button3.Name = "button3";
            button3.Size = new Size(144, 84);
            button3.TabIndex = 9;
            button3.Text = "Clear all table";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton radBut4;
        private RadioButton radBut3;
        private RadioButton radBut2;
        private RadioButton radBut1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}