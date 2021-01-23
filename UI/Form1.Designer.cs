namespace UI
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNODOS = new System.Windows.Forms.Button();
            this.buttonCONCENSO = new System.Windows.Forms.Button();
            this.listBoxNODOS = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Minar en nodo principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver cadena de nodo principal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 227);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(612, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva transacción";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(75, 89);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(75, 60);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Receptor:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(62, 34);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Agregar a nodo principal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emisor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.maskedTextBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(612, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 227);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver transacciones de un bloque del nodo principal";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 149);
            this.dataGridView2.TabIndex = 5;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(109, 36);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Index del bloque:";
            // 
            // buttonNODOS
            // 
            this.buttonNODOS.Location = new System.Drawing.Point(282, 161);
            this.buttonNODOS.Name = "buttonNODOS";
            this.buttonNODOS.Size = new System.Drawing.Size(284, 38);
            this.buttonNODOS.TabIndex = 5;
            this.buttonNODOS.Text = "Nuevos nodos";
            this.buttonNODOS.UseVisualStyleBackColor = true;
            this.buttonNODOS.Click += new System.EventHandler(this.buttonNODOS_Click);
            // 
            // buttonCONCENSO
            // 
            this.buttonCONCENSO.Location = new System.Drawing.Point(282, 212);
            this.buttonCONCENSO.Name = "buttonCONCENSO";
            this.buttonCONCENSO.Size = new System.Drawing.Size(284, 38);
            this.buttonCONCENSO.TabIndex = 6;
            this.buttonCONCENSO.Text = "Concenso de nodos";
            this.buttonCONCENSO.UseVisualStyleBackColor = true;
            this.buttonCONCENSO.Click += new System.EventHandler(this.buttonCONCENSO_Click);
            // 
            // listBoxNODOS
            // 
            this.listBoxNODOS.FormattingEnabled = true;
            this.listBoxNODOS.Location = new System.Drawing.Point(41, 28);
            this.listBoxNODOS.Name = "listBoxNODOS";
            this.listBoxNODOS.Size = new System.Drawing.Size(250, 43);
            this.listBoxNODOS.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nodos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxNODOS);
            this.Controls.Add(this.buttonCONCENSO);
            this.Controls.Add(this.buttonNODOS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNODOS;
        private System.Windows.Forms.Button buttonCONCENSO;
        private System.Windows.Forms.ListBox listBoxNODOS;
        private System.Windows.Forms.Label label5;
    }
}

