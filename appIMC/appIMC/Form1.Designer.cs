namespace appIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncalcu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmens = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncalcu);
            this.groupBox1.Controls.Add(this.txtaltu);
            this.groupBox1.Controls.Add(this.txtpeso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(79, 33);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(64, 20);
            this.txtpeso.TabIndex = 2;
            // 
            // txtaltu
            // 
            this.txtaltu.Location = new System.Drawing.Point(228, 33);
            this.txtaltu.Name = "txtaltu";
            this.txtaltu.Size = new System.Drawing.Size(64, 20);
            this.txtaltu.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmens);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblres);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // btncalcu
            // 
            this.btncalcu.Image = global::appIMC.Properties.Resources.brick;
            this.btncalcu.Location = new System.Drawing.Point(228, 59);
            this.btncalcu.Name = "btncalcu";
            this.btncalcu.Size = new System.Drawing.Size(113, 32);
            this.btncalcu.TabIndex = 4;
            this.btncalcu.Text = "Calcular";
            this.btncalcu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncalcu.UseVisualStyleBackColor = true;
            this.btncalcu.Click += new System.EventHandler(this.btncalcu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IMC =";
            // 
            // lblres
            // 
            this.lblres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblres.Location = new System.Drawing.Point(109, 33);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(100, 23);
            this.lblres.TabIndex = 1;
            this.lblres.Text = "0.00";
            this.lblres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mensaje";
            // 
            // lblmens
            // 
            this.lblmens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmens.Location = new System.Drawing.Point(109, 65);
            this.lblmens.Name = "lblmens";
            this.lblmens.Size = new System.Drawing.Size(100, 23);
            this.lblmens.TabIndex = 3;
            this.lblmens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 286);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 286);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncalcu;
        private System.Windows.Forms.TextBox txtaltu;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmens;
        private System.Windows.Forms.Label label4;
    }
}

