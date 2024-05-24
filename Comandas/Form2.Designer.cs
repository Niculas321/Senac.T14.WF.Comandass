namespace Comandas
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            airForm2 = new ReaLTaiizor.Forms.AirForm();
            airForm3 = new ReaLTaiizor.Forms.AirForm();
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            airForm1.SuspendLayout();
            airForm2.SuspendLayout();
            airForm3.SuspendLayout();
            dreamForm1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.FromArgb(244, 241, 243);
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(airForm2);
            airForm1.Customization = "AAAA/1paWv9ycnL/";
            airForm1.Dock = DockStyle.Fill;
            airForm1.Font = new Font("Segoe UI", 9F);
            airForm1.Image = null;
            airForm1.Location = new Point(0, 0);
            airForm1.MinimumSize = new Size(261, 65);
            airForm1.Movable = true;
            airForm1.Name = "airForm1";
            airForm1.NoRounding = false;
            airForm1.Sizable = true;
            airForm1.Size = new Size(800, 450);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            airForm1.TabIndex = 0;
            airForm1.Text = "airForm1";
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // airForm2
            // 
            airForm2.BackColor = Color.FromArgb(244, 241, 243);
            airForm2.BorderStyle = FormBorderStyle.None;
            airForm2.Controls.Add(airForm3);
            airForm2.Customization = "AAAA/1paWv9ycnL/";
            airForm2.Dock = DockStyle.Fill;
            airForm2.Font = new Font("Segoe UI", 9F);
            airForm2.Image = null;
            airForm2.Location = new Point(0, 0);
            airForm2.MinimumSize = new Size(261, 65);
            airForm2.Movable = true;
            airForm2.Name = "airForm2";
            airForm2.NoRounding = false;
            airForm2.Sizable = true;
            airForm2.Size = new Size(800, 450);
            airForm2.SmartBounds = true;
            airForm2.StartPosition = FormStartPosition.CenterScreen;
            airForm2.TabIndex = 0;
            airForm2.Text = "airForm2";
            airForm2.TransparencyKey = Color.Fuchsia;
            airForm2.Transparent = false;
            // 
            // airForm3
            // 
            airForm3.BackColor = Color.FromArgb(244, 241, 243);
            airForm3.BorderStyle = FormBorderStyle.None;
            airForm3.Controls.Add(dreamForm1);
            airForm3.Customization = "AAAA/1paWv9ycnL/";
            airForm3.Dock = DockStyle.Fill;
            airForm3.Font = new Font("Segoe UI", 9F);
            airForm3.Image = null;
            airForm3.Location = new Point(0, 0);
            airForm3.MinimumSize = new Size(261, 65);
            airForm3.Movable = true;
            airForm3.Name = "airForm3";
            airForm3.NoRounding = false;
            airForm3.Sizable = true;
            airForm3.Size = new Size(800, 450);
            airForm3.SmartBounds = true;
            airForm3.StartPosition = FormStartPosition.CenterScreen;
            airForm3.TabIndex = 0;
            airForm3.Text = "airForm3";
            airForm3.TransparencyKey = Color.Fuchsia;
            airForm3.Transparent = false;
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(groupBox1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(800, 450);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "FormCardapio";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            dreamForm1.Enter += dreamForm1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Pedidos";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Location = new Point(59, 138);
            button1.Name = "button1";
            button1.Size = new Size(242, 36);
            button1.TabIndex = 1;
            button1.Text = "+     Item cardápio";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(74, 65);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "Pesquisar :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 31);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(448, 353);
            button2.Name = "button2";
            button2.Size = new Size(110, 32);
            button2.TabIndex = 4;
            button2.Text = "✖  Excluir";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(595, 353);
            button3.Name = "button3";
            button3.Size = new Size(110, 32);
            button3.TabIndex = 5;
            button3.Text = "✔  Editar";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(59, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(592, 145);
            dataGridView1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 65);
            Name = "Form2";
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            airForm2.ResumeLayout(false);
            airForm3.ResumeLayout(false);
            dreamForm1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Forms.AirForm airForm2;
        private ReaLTaiizor.Forms.AirForm airForm3;
        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}