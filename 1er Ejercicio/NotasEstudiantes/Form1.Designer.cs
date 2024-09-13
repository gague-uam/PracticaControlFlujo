namespace NotasEstudiantes
{
    partial class ArregloNotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lbNotas = new System.Windows.Forms.ListBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHighest);
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.lbNotas);
            this.groupBox1.Controls.Add(this.lblGrades);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbGrade);
            this.groupBox1.Controls.Add(this.lblInsert);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(352, 202);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(127, 25);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Promedio: 0";
            // 
            // lbNotas
            // 
            this.lbNotas.FormattingEnabled = true;
            this.lbNotas.ItemHeight = 25;
            this.lbNotas.Location = new System.Drawing.Point(36, 197);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(291, 129);
            this.lbNotas.TabIndex = 4;
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(31, 155);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(187, 25);
            this.lblGrades.TabIndex = 3;
            this.lblGrades.Text = "Notas registradas:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(188, 71);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(147, 31);
            this.tbGrade.TabIndex = 1;
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(22, 74);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(160, 25);
            this.lblInsert.TabIndex = 0;
            this.lblInsert.Text = "Ingrese la nota:";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(356, 241);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(144, 25);
            this.lblHighest.TabIndex = 6;
            this.lblHighest.Text = "Mayor nota: 0";
            // 
            // ArregloNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArregloNotas";
            this.Text = "ArregloNotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.ListBox lbNotas;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblHighest;
    }
}

