namespace DelegateAnalu
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 66);
            label1.Name = "label1";
            label1.Size = new Size(579, 74);
            label1.TabIndex = 0;
            label1.Text = "B I E N V E N I D O S";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Thanks Autumn", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 140);
            label2.Name = "label2";
            label2.Size = new Size(300, 57);
            label2.TabIndex = 1;
            label2.Text = "Chepe te Vende";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(315, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(315, 415);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(399, 276);
            label3.Name = "label3";
            label3.Size = new Size(225, 22);
            label3.TabIndex = 4;
            label3.Text = "Ingresar correo electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(439, 390);
            label4.Name = "label4";
            label4.Size = new Size(164, 22);
            label4.TabIndex = 5;
            label4.Text = "Ingresar contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(315, 541);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 6;
            label5.Text = "Crear Usuario";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(509, 519);
            button1.Name = "button1";
            button1.Size = new Size(207, 62);
            button1.TabIndex = 7;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1009, 646);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}