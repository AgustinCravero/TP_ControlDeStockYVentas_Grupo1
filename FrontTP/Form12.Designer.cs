namespace FrontTP
{
    partial class Form12
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(401, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(401, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(401, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 81);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingrese el nombre del proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 162);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 6;
            label2.Text = "Ingrese el teléfono del proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 240);
            label3.Name = "label3";
            label3.Size = new Size(212, 20);
            label3.TabIndex = 7;
            label3.Text = "Ingrese el email del proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 325);
            label4.Name = "label4";
            label4.Size = new Size(236, 20);
            label4.TabIndex = 8;
            label4.Text = "Ingrese la dirección del proveedor";
            // 
            // button1
            // 
            button1.Location = new Point(285, 379);
            button1.Name = "button1";
            button1.Size = new Size(136, 49);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(588, 433);
            button2.Name = "button2";
            button2.Size = new Size(200, 55);
            button2.TabIndex = 11;
            button2.Text = "Volver al menú principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}