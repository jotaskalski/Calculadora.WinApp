namespace Calculadora.WinApp
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSomar = new Button();
            btnIgual = new Button();
            btn0 = new Button();
            btnLimpar = new Button();
            btnSubtrair = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMultiplicar = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDividir = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            panel1 = new Panel();
            txtNumeros = new TextBox();
            txtCalculo = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnSomar, 3, 3);
            tableLayoutPanel1.Controls.Add(btnIgual, 2, 3);
            tableLayoutPanel1.Controls.Add(btn0, 1, 3);
            tableLayoutPanel1.Controls.Add(btnLimpar, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSubtrair, 3, 2);
            tableLayoutPanel1.Controls.Add(btn3, 2, 2);
            tableLayoutPanel1.Controls.Add(btn2, 1, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiplicar, 3, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDividir, 3, 0);
            tableLayoutPanel1.Controls.Add(btn9, 2, 0);
            tableLayoutPanel1.Controls.Add(btn8, 1, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 202);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(249, 241);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSomar
            // 
            btnSomar.Dock = DockStyle.Fill;
            btnSomar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSomar.Location = new Point(189, 183);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(57, 55);
            btnSomar.TabIndex = 15;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Dock = DockStyle.Fill;
            btnIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(127, 183);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(56, 55);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(65, 183);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 55);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(3, 183);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 55);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Dock = DockStyle.Fill;
            btnSubtrair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtrair.Location = new Point(189, 123);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(57, 54);
            btnSubtrair.TabIndex = 11;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(127, 123);
            btn3.Name = "btn3";
            btn3.Size = new Size(56, 54);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(65, 123);
            btn2.Name = "btn2";
            btn2.Size = new Size(56, 54);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(3, 123);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 54);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Dock = DockStyle.Fill;
            btnMultiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(189, 63);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(57, 54);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(127, 63);
            btn6.Name = "btn6";
            btn6.Size = new Size(56, 54);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(65, 63);
            btn5.Name = "btn5";
            btn5.Size = new Size(56, 54);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(3, 63);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 54);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Dock = DockStyle.Fill;
            btnDividir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.Location = new Point(189, 3);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(57, 54);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(127, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(56, 54);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(65, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 54);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(3, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 54);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNumeros);
            panel1.Controls.Add(txtCalculo);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 171);
            panel1.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Dock = DockStyle.Bottom;
            txtNumeros.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeros.Location = new Point(0, 100);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(243, 71);
            txtNumeros.TabIndex = 1;
            // 
            // txtCalculo
            // 
            txtCalculo.Dock = DockStyle.Top;
            txtCalculo.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            txtCalculo.Location = new Point(0, 0);
            txtCalculo.Name = "txtCalculo";
            txtCalculo.Size = new Size(243, 54);
            txtCalculo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 455);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(282, 487);
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn7;
        private Button btn8;
        private Button btnSomar;
        private Button btnIgual;
        private Button btn0;
        private Button btnLimpar;
        private Button btnSubtrair;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMultiplicar;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDividir;
        private Button btn9;
        private Panel panel1;
        private TextBox txtNumeros;
        private TextBox txtCalculo;
    }
}