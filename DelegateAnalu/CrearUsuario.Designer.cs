namespace DelegateAnalu
{
    partial class CrearUsuario
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
            label1 = new Label();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(298, 62);
            label1.Name = "label1";
            label1.Size = new Size(378, 40);
            label1.TabIndex = 0;
            label1.Text = "Crear nuevo usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(469, 508);
            button1.Name = "button1";
            button1.Size = new Size(207, 62);
            button1.TabIndex = 13;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(275, 530);
            label5.Name = "label5";
            label5.Size = new Size(117, 22);
            label5.TabIndex = 12;
            label5.Text = "Iniciar sesion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(388, 370);
            label4.Name = "label4";
            label4.Size = new Size(164, 22);
            label4.TabIndex = 11;
            label4.Text = "Ingresar contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(359, 265);
            label3.Name = "label3";
            label3.Size = new Size(225, 22);
            label3.TabIndex = 10;
            label3.Text = "Ingresar correo electronico";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(275, 404);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(275, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 31);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(397, 160);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 14;
            label2.Text = "Ingresar nombre";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Location = new Point(275, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(401, 31);
            textBox3.TabIndex = 15;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 603);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
    }
}