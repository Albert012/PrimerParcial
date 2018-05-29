namespace PrimerParcial.UI.Registros
{
    partial class rRegistro
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Varlidar_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Varlidar_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Eliminar_button);
            this.groupBox1.Controls.Add(this.Nuevo_button);
            this.groupBox1.Controls.Add(this.Guardar_button);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(112, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Navy;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(3, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Varlidar_errorProvider
            // 
            this.Varlidar_errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::PrimerParcial.Properties.Resources.find;
            this.Buscar_button.Location = new System.Drawing.Point(223, 76);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(38, 38);
            this.Buscar_button.TabIndex = 3;
            this.Buscar_button.UseVisualStyleBackColor = true;
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Eliminar_button.Image = global::PrimerParcial.Properties.Resources.Delete;
            this.Eliminar_button.Location = new System.Drawing.Point(176, 22);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(46, 42);
            this.Eliminar_button.TabIndex = 2;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::PrimerParcial.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(41, 22);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(46, 42);
            this.Nuevo_button.TabIndex = 1;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::PrimerParcial.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(111, 22);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(46, 42);
            this.Guardar_button.TabIndex = 0;
            this.Guardar_button.UseVisualStyleBackColor = true;
            // 
            // rRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(516, 456);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "rRegistro";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Varlidar_errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider Varlidar_errorProvider;
        private System.Windows.Forms.Button Buscar_button;
    }
}