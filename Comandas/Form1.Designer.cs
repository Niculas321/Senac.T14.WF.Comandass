namespace Comandas
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
            moonForm1 = new ReaLTaiizor.Forms.MoonForm();
            Principal = new ReaLTaiizor.Forms.DreamForm();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            moonForm1.SuspendLayout();
            Principal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // moonForm1
            // 
            moonForm1.BackColor = Color.FromArgb(244, 241, 243);
            moonForm1.BorderColor = Color.LightGray;
            moonForm1.BorderStyle = FormBorderStyle.None;
            moonForm1.Controls.Add(Principal);
            moonForm1.Customization = "/////9PT0//w8PD/";
            moonForm1.Dock = DockStyle.Fill;
            moonForm1.FirstEdge = Color.LightGray;
            moonForm1.Font = new Font("Segoe UI", 9F);
            moonForm1.Image = null;
            moonForm1.Location = new Point(0, 0);
            moonForm1.MinimumSize = new Size(261, 65);
            moonForm1.Movable = true;
            moonForm1.Name = "moonForm1";
            moonForm1.NoRounding = false;
            moonForm1.SecondEdge = Color.White;
            moonForm1.Sizable = true;
            moonForm1.Size = new Size(835, 559);
            moonForm1.SmartBounds = true;
            moonForm1.StartPosition = FormStartPosition.CenterScreen;
            moonForm1.TabIndex = 0;
            moonForm1.Text = "moonForm1";
            moonForm1.TitleColor = Color.Black;
            moonForm1.TransparencyKey = Color.Fuchsia;
            moonForm1.Transparent = false;
            // 
            // Principal
            // 
            Principal.ColorA = Color.FromArgb(40, 218, 255);
            Principal.ColorB = Color.FromArgb(63, 63, 63);
            Principal.ColorC = Color.FromArgb(41, 41, 41);
            Principal.ColorD = Color.FromArgb(27, 27, 27);
            Principal.ColorE = Color.FromArgb(0, 0, 0, 0);
            Principal.ColorF = Color.FromArgb(25, 255, 255, 255);
            Principal.Controls.Add(groupBox1);
            Principal.Dock = DockStyle.Fill;
            Principal.Location = new Point(0, 0);
            Principal.Name = "Principal";
            Principal.Size = new Size(835, 559);
            Principal.TabIndex = 0;
            Principal.TabStop = false;
            Principal.Text = "FormPrincipal";
            Principal.TitleAlign = HorizontalAlignment.Center;
            Principal.TitleHeight = 25;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(30, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 418);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Principal";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Location = new Point(42, 270);
            button1.Name = "button1";
            button1.Size = new Size(160, 100);
            button1.TabIndex = 0;
            button1.Text = "Cardápio";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Location = new Point(219, 270);
            button2.Name = "button2";
            button2.Size = new Size(160, 100);
            button2.TabIndex = 1;
            button2.Text = "Comanda";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Location = new Point(395, 270);
            button3.Name = "button3";
            button3.Size = new Size(160, 100);
            button3.TabIndex = 2;
            button3.Text = "Pedido Cozinha";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Location = new Point(572, 270);
            button4.Name = "button4";
            button4.Size = new Size(160, 100);
            button4.TabIndex = 3;
            button4.Text = "Usuários";
            button4.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(690, 33);
            comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 559);
            Controls.Add(moonForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(261, 65);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            moonForm1.ResumeLayout(false);
            Principal.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.MoonForm moonForm1;
        private ReaLTaiizor.Forms.DreamForm Principal;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
