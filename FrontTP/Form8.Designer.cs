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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(348, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(255, 446);
            button1.Name = "button1";
            button1.Size = new Size(209, 60);
            button1.TabIndex = 1;
            button1.Text = "Agregar producto a la venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(426, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(817, 635);
            button2.Name = "button2";
            button2.Size = new Size(209, 60);
            button2.TabIndex = 4;
            button2.Text = "Finalizar Venta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1056, 635);
            button3.Name = "button3";
            button3.Size = new Size(209, 60);
            button3.TabIndex = 5;
            button3.Text = "Volver al menú principal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 76);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingrese la fecha de la venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 155);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 7;
            label2.Text = "Seleccione el producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 244);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 8;
            label3.Text = "Ingrese la cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 369);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(675, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(567, 371);
            dataGridView1.TabIndex = 10;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 707);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label4;
        private DataGridView dataGridView1;
    }
}