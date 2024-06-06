namespace WindowsFormsApp1
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
            this.tbdistancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.rbBicicleta = new System.Windows.Forms.RadioButton();
            this.rbMotos = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbPublico = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbdistancia
            // 
            this.tbdistancia.Location = new System.Drawing.Point(89, 29);
            this.tbdistancia.Name = "tbdistancia";
            this.tbdistancia.Size = new System.Drawing.Size(100, 20);
            this.tbdistancia.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(179, 120);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(75, 39);
            this.btnResultados.TabIndex = 9;
            this.btnResultados.Text = "Ver Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(359, 91);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 48);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Encuesta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(6, 19);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(451, 95);
            this.lbResultados.TabIndex = 11;
            // 
            // rbBicicleta
            // 
            this.rbBicicleta.AutoSize = true;
            this.rbBicicleta.Location = new System.Drawing.Point(63, 26);
            this.rbBicicleta.Name = "rbBicicleta";
            this.rbBicicleta.Size = new System.Drawing.Size(65, 17);
            this.rbBicicleta.TabIndex = 12;
            this.rbBicicleta.TabStop = true;
            this.rbBicicleta.Text = "Bicicleta";
            this.rbBicicleta.UseVisualStyleBackColor = true;
            // 
            // rbMotos
            // 
            this.rbMotos.AutoSize = true;
            this.rbMotos.Location = new System.Drawing.Point(63, 49);
            this.rbMotos.Name = "rbMotos";
            this.rbMotos.Size = new System.Drawing.Size(85, 17);
            this.rbMotos.TabIndex = 13;
            this.rbMotos.TabStop = true;
            this.rbMotos.Text = "Motocicletas";
            this.rbMotos.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(63, 72);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(71, 17);
            this.rbAuto.TabIndex = 14;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automóvil";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbPublico
            // 
            this.rbPublico.AutoSize = true;
            this.rbPublico.Location = new System.Drawing.Point(63, 95);
            this.rbPublico.Name = "rbPublico";
            this.rbPublico.Size = new System.Drawing.Size(114, 17);
            this.rbPublico.TabIndex = 15;
            this.rbPublico.TabStop = true;
            this.rbPublico.Text = "Transporte Publico";
            this.rbPublico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPublico);
            this.groupBox1.Controls.Add(this.rbBicicleta);
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Controls.Add(this.rbMotos);
            this.groupBox1.Location = new System.Drawing.Point(25, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 136);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de transporte de uso más frecuente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Location = new System.Drawing.Point(47, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 254);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresar número";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbdistancia);
            this.groupBox3.Location = new System.Drawing.Point(25, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 71);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distancia aproximada según el vehículo seleccionado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbResultados);
            this.groupBox4.Controls.Add(this.btnResultados);
            this.groupBox4.Location = new System.Drawing.Point(47, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 166);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbdistancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.RadioButton rbBicicleta;
        private System.Windows.Forms.RadioButton rbMotos;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbPublico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

