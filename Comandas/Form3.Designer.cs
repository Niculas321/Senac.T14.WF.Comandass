namespace Comandas
{
    partial class Form3
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            dreamForm1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            dreamForm1.Controls.Add(button2);
            dreamForm1.Controls.Add(button1);
            dreamForm1.Controls.Add(groupBox1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(800, 450);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "FormCardápioCad";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 125);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 209);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Preço:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(501, 33);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(501, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 31);
            textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Possui preparo?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(568, 61);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 31);
            numericUpDown1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(445, 399);
            button1.Name = "button1";
            button1.Size = new Size(146, 37);
            button1.TabIndex = 1;
            button1.Text = "✖  Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(609, 399);
            button2.Name = "button2";
            button2.Size = new Size(146, 37);
            button2.TabIndex = 2;
            button2.Text = "✔   Salvar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            dreamForm1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}