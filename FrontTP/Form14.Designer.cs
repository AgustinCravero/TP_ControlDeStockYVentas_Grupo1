namespace FrontTP
{
    partial class Form14
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(484, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 61);
            label1.Name = "label1";
            label1.Size = new Size(309, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el proveedor que desea modificar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(484, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(322, 435);
            button1.Name = "button1";
            button1.Size = new Size(178, 51);
            button1.TabIndex = 3;
            button1.Text = "Confirmar Cambios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(705, 498);
            button2.Name = "button2";
            button2.Size = new Size(178, 52);
            button2.TabIndex = 4;
            button2.Text = "Volver al menú principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(484, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(484, 385);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 148);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 229);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 309);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 388);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Dirección";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 562);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form14";
            Text = "Form14";
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}