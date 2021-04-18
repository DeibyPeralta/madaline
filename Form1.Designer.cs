
namespace madaline
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_entradas = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TotalCapas = new System.Windows.Forms.ComboBox();
            this.txbox_Ncapas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oculta = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_entradas
            // 
            this.btn_entradas.Location = new System.Drawing.Point(33, 12);
            this.btn_entradas.Name = "btn_entradas";
            this.btn_entradas.Size = new System.Drawing.Size(103, 35);
            this.btn_entradas.TabIndex = 0;
            this.btn_entradas.Text = "Cargar entradas";
            this.btn_entradas.UseVisualStyleBackColor = true;
            this.btn_entradas.Click += new System.EventHandler(this.btn_entradas_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TotalCapas
            // 
            this.TotalCapas.FormattingEnabled = true;
            this.TotalCapas.Location = new System.Drawing.Point(348, 77);
            this.TotalCapas.Name = "TotalCapas";
            this.TotalCapas.Size = new System.Drawing.Size(56, 21);
            this.TotalCapas.TabIndex = 1;
            // 
            // txbox_Ncapas
            // 
            this.txbox_Ncapas.Location = new System.Drawing.Point(370, 31);
            this.txbox_Ncapas.Name = "txbox_Ncapas";
            this.txbox_Ncapas.Size = new System.Drawing.Size(100, 20);
            this.txbox_Ncapas.TabIndex = 2;
            this.txbox_Ncapas.TextChanged += new System.EventHandler(this.txbox_Ncapas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Capas ocultas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(53, 173);
            this.listBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Capas ocultas";
            // 
            // oculta
            // 
            this.oculta.AutoSize = true;
            this.oculta.Location = new System.Drawing.Point(508, 113);
            this.oculta.Name = "oculta";
            this.oculta.Size = new System.Drawing.Size(0, 13);
            this.oculta.TabIndex = 10;
            this.oculta.Click += new System.EventHandler(this.oculta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.oculta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbox_Ncapas);
            this.Controls.Add(this.TotalCapas);
            this.Controls.Add(this.btn_entradas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entradas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox TotalCapas;
        private System.Windows.Forms.TextBox txbox_Ncapas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oculta;
        private System.Windows.Forms.Button button3;
    }
}

