namespace FrontTP
{
    partial class Form8
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
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(317, 349);
            button1.Name = "button1";
            button1.Size = new Size(209, 60);
            button1.TabIndex = 1;
            button1.Text = "Agregar producto a la venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(456, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(503, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(317, 479);
            button2.Name = "button2";
            button2.Size = new Size(209, 60);
            button2.TabIndex = 4;
            button2.Text = "Finalizar Venta";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(702, 552);
            button3.Name = "button3";
            button3.Size = new Size(209, 60);
            button3.TabIndex = 5;
            button3.Text = "Volver al menú principal";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 66);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingrese la fecha de la venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 145);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 7;
            label2.Text = "Seleccione el producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 234);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 8;
            label3.Text = "Ingrese la cantidad";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 624);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}