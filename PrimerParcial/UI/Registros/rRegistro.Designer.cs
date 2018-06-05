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
            System.Windows.Forms.Label grupoIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label integrantesLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label grupoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValidarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscar_button = new System.Windows.Forms.Button();
            this.grupoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.integrantesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.grupoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            grupoIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            integrantesLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrantesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(104, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
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
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::PrimerParcial.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(41, 22);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(46, 42);
            this.Nuevo_button.TabIndex = 1;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::PrimerParcial.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(111, 22);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(46, 42);
            this.Guardar_button.TabIndex = 0;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Navy;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro De Grupo De Estudiantes";
            // 
            // ValidarErrorProvider
            // 
            this.ValidarErrorProvider.ContainerControl = this;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::PrimerParcial.Properties.Resources.find;
            this.Buscar_button.Location = new System.Drawing.Point(241, 74);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(34, 35);
            this.Buscar_button.TabIndex = 3;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupoIdLabel.ForeColor = System.Drawing.SystemColors.Control;
            grupoIdLabel.Location = new System.Drawing.Point(21, 85);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(75, 16);
            grupoIdLabel.TabIndex = 3;
            grupoIdLabel.Text = "Grupo Id:";
            // 
            // grupoIdNumericUpDown
            // 
            this.grupoIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "GrupoId", true));
            this.grupoIdNumericUpDown.Location = new System.Drawing.Point(104, 85);
            this.grupoIdNumericUpDown.Name = "grupoIdNumericUpDown";
            this.grupoIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.grupoIdNumericUpDown.TabIndex = 4;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaLabel.Location = new System.Drawing.Point(32, 123);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(57, 16);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(104, 119);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.SystemColors.Control;
            descripcionLabel.Location = new System.Drawing.Point(6, 161);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(97, 16);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(104, 158);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(307, 20);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // integrantesLabel
            // 
            integrantesLabel.AutoSize = true;
            integrantesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            integrantesLabel.ForeColor = System.Drawing.SystemColors.Control;
            integrantesLabel.Location = new System.Drawing.Point(-2, 241);
            integrantesLabel.Name = "integrantesLabel";
            integrantesLabel.Size = new System.Drawing.Size(91, 16);
            integrantesLabel.TabIndex = 13;
            integrantesLabel.Text = "Integrantes:";
            // 
            // integrantesNumericUpDown
            // 
            this.integrantesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Integrantes", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.integrantesNumericUpDown.Location = new System.Drawing.Point(104, 241);
            this.integrantesNumericUpDown.Name = "integrantesNumericUpDown";
            this.integrantesNumericUpDown.ReadOnly = true;
            this.integrantesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.integrantesNumericUpDown.TabIndex = 14;
            this.integrantesNumericUpDown.ValueChanged += new System.EventHandler(this.integrantesNumericUpDown_ValueChanged);
            this.integrantesNumericUpDown.VisibleChanged += new System.EventHandler(this.integrantesNumericUpDown_VisibleChanged);
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.ForeColor = System.Drawing.SystemColors.Control;
            cantidadLabel.Location = new System.Drawing.Point(21, 202);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(77, 16);
            cantidadLabel.TabIndex = 14;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Cantidad", true));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(104, 201);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(110, 20);
            this.cantidadNumericUpDown.TabIndex = 15;
            this.cantidadNumericUpDown.ValueChanged += new System.EventHandler(this.cantidadNumericUpDown_ValueChanged);
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grupoLabel.ForeColor = System.Drawing.SystemColors.Control;
            grupoLabel.Location = new System.Drawing.Point(230, 202);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(56, 16);
            grupoLabel.TabIndex = 15;
            grupoLabel.Text = "Grupo:";
            // 
            // grupoNumericUpDown
            // 
            this.grupoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Grupo", true));
            this.grupoNumericUpDown.Location = new System.Drawing.Point(291, 199);
            this.grupoNumericUpDown.Name = "grupoNumericUpDown";
            this.grupoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.grupoNumericUpDown.TabIndex = 16;
            this.grupoNumericUpDown.ValueChanged += new System.EventHandler(this.grupoNumericUpDown_ValueChanged);
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataSource = typeof(PrimerParcial.Entidades.Grupos);
            // 
            // rRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(479, 394);
            this.Controls.Add(grupoLabel);
            this.Controls.Add(this.grupoNumericUpDown);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(integrantesLabel);
            this.Controls.Add(this.integrantesNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(grupoIdLabel);
            this.Controls.Add(this.grupoIdNumericUpDown);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.rRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrantesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ValidarErrorProvider;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.NumericUpDown integrantesNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown grupoIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown grupoNumericUpDown;
    }
}