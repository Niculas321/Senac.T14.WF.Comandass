namespace Comandas
{
    partial class Form4
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
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            dreamForm1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(button4);
            dreamForm1.Controls.Add(button3);
            dreamForm1.Controls.Add(button2);
            dreamForm1.Controls.Add(groupBox1);
            dreamForm1.Controls.Add(textBox1);
            dreamForm1.Controls.Add(button1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(800, 450);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "dreamForm1";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // button1
            // 
            button1.Location = new Point(69, 46);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 0;
            button1.Text = "+  Comanda";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 31);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(30, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 246);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(523, 162);
            button2.Name = "button2";
            button2.Size = new Size(142, 32);
            button2.TabIndex = 3;
            button2.Text = "#  Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Location = new Point(523, 245);
            button3.Name = "button3";
            button3.Size = new Size(142, 32);
            button3.TabIndex = 4;
            button3.Text = "@  Encerrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(523, 322);
            button4.Name = "button4";
            button4.Size = new Size(142, 32);
            button4.TabIndex = 5;
            button4.Text = "✖ Cancelar";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(379, 169);
            dataGridView1.TabIndex = 0;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            dreamForm1.ResumeLayout(false);
            dreamForm1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}