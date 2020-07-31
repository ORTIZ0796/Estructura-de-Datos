namespace Ejemplo1
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
            this.TxtA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtResp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtRespR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtCarac = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCad2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCad = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.TxtSal = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtN3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.NumericUpDown();
            this.N2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtA
            // 
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtA.Location = new System.Drawing.Point(61, 44);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 31);
            this.TxtA.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TxtB
            // 
            this.TxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB.Location = new System.Drawing.Point(61, 123);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 31);
            this.TxtB.TabIndex = 2;
            // 
            // TxtResp
            // 
            this.TxtResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResp.Location = new System.Drawing.Point(61, 220);
            this.TxtResp.Name = "TxtResp";
            this.TxtResp.Size = new System.Drawing.Size(100, 31);
            this.TxtResp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtB);
            this.groupBox1.Controls.Add(this.TxtResp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 267);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.TxtRespR);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 267);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Real";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad 1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(61, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Suma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(61, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 2;
            // 
            // TxtRespR
            // 
            this.TxtRespR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRespR.Location = new System.Drawing.Point(61, 220);
            this.TxtRespR.Name = "TxtRespR";
            this.TxtRespR.Size = new System.Drawing.Size(100, 31);
            this.TxtRespR.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtC);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.TxtCarac);
            this.groupBox3.Location = new System.Drawing.Point(561, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 267);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caracter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Introduce un carac.";
            // 
            // TxtC
            // 
            this.TxtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtC.Location = new System.Drawing.Point(61, 44);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(100, 31);
            this.TxtC.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(61, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtCarac
            // 
            this.TxtCarac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarac.Location = new System.Drawing.Point(61, 142);
            this.TxtCarac.Name = "TxtCarac";
            this.TxtCarac.Size = new System.Drawing.Size(100, 31);
            this.TxtCarac.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TxtCad2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TxtCad);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.TxtSal);
            this.groupBox4.Location = new System.Drawing.Point(789, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 267);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor para la cadena 2";
            // 
            // TxtCad2
            // 
            this.TxtCad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCad2.Location = new System.Drawing.Point(27, 121);
            this.TxtCad2.Name = "TxtCad2";
            this.TxtCad2.Size = new System.Drawing.Size(167, 31);
            this.TxtCad2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor para la cadena 1";
            // 
            // TxtCad
            // 
            this.TxtCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCad.Location = new System.Drawing.Point(27, 44);
            this.TxtCad.Name = "TxtCad";
            this.TxtCad.Size = new System.Drawing.Size(167, 31);
            this.TxtCad.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 31);
            this.button4.TabIndex = 1;
            this.button4.Text = "Concatenar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtSal
            // 
            this.TxtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSal.Location = new System.Drawing.Point(27, 220);
            this.TxtSal.Name = "TxtSal";
            this.TxtSal.Size = new System.Drawing.Size(167, 31);
            this.TxtSal.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.N2);
            this.groupBox6.Controls.Add(this.N1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.TxtN3);
            this.groupBox6.Location = new System.Drawing.Point(497, 301);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 229);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Logico";
            // 
            // TxtN3
            // 
            this.TxtN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN3.Location = new System.Drawing.Point(106, 157);
            this.TxtN3.Name = "TxtN3";
            this.TxtN3.Size = new System.Drawing.Size(100, 31);
            this.TxtN3.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(92, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 31);
            this.button6.TabIndex = 1;
            this.button6.Text = "AND ( Y )";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Introduce un carac.";
            // 
            // N1
            // 
            this.N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1.Location = new System.Drawing.Point(51, 58);
            this.N1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(59, 29);
            this.N1.TabIndex = 6;
            // 
            // N2
            // 
            this.N2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.Location = new System.Drawing.Point(170, 58);
            this.N2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(59, 29);
            this.N2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 554);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tipos de Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtRespR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtCarac;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TxtSal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCad2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown N2;
        private System.Windows.Forms.NumericUpDown N1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TxtN3;
    }
}

