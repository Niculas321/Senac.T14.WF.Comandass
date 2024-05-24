namespace Comandas
{
    partial class Form5
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            dreamForm1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            dreamForm1.Controls.Add(button3);
            dreamForm1.Controls.Add(button2);
            dreamForm1.Controls.Add(groupBox3);
            dreamForm1.Controls.Add(groupBox2);
            dreamForm1.Controls.Add(groupBox1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(800, 653);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "FormCardapioCad";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 105);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Mesa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(459, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 31);
            textBox2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(39, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 32);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 0;
            label3.Text = "Item:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(504, 31);
            textBox3.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(622, 24);
            button1.Name = "button1";
            button1.Size = new Size(50, 42);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(39, 331);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(609, 296);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista Items";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(685, 340);
            button2.Name = "button2";
            button2.Size = new Size(95, 34);
            button2.TabIndex = 3;
            button2.Text = "✔ ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(685, 392);
            button3.Name = "button3";
            button3.Size = new Size(95, 34);
            button3.TabIndex = 4;
            button3.Text = "✖";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(516, 225);
            dataGridView1.TabIndex = 1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 653);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            dreamForm1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}