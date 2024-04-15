namespace Ejercicio_Consultorio
{
    partial class PMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMedico));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.dgMedico = new System.Windows.Forms.DataGridView();
            this.txtMedicoId = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medico Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Location = new System.Drawing.Point(12, 250);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(175, 24);
            this.cbActivos.TabIndex = 3;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // dgMedico
            // 
            this.dgMedico.AllowUserToAddRows = false;
            this.dgMedico.AllowUserToDeleteRows = false;
            this.dgMedico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedico.Location = new System.Drawing.Point(12, 280);
            this.dgMedico.Name = "dgMedico";
            this.dgMedico.ReadOnly = true;
            this.dgMedico.RowHeadersWidth = 62;
            this.dgMedico.RowTemplate.Height = 28;
            this.dgMedico.Size = new System.Drawing.Size(866, 325);
            this.dgMedico.TabIndex = 4;
            this.dgMedico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedico_CellDoubleClick);
            // 
            // txtMedicoId
            // 
            this.txtMedicoId.Location = new System.Drawing.Point(189, 33);
            this.txtMedicoId.Name = "txtMedicoId";
            this.txtMedicoId.ReadOnly = true;
            this.txtMedicoId.Size = new System.Drawing.Size(103, 26);
            this.txtMedicoId.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(189, 76);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(407, 26);
            this.txtNombres.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(189, 121);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(407, 26);
            this.txtApellidos.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(426, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 43);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(596, 221);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 43);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(189, 172);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(78, 24);
            this.cbEstado.TabIndex = 10;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(301, 168);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(294, 26);
            this.dtFecha.TabIndex = 11;
            // 
            // PMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 617);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtMedicoId);
            this.Controls.Add(this.dgMedico);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMedico";
            this.Load += new System.EventHandler(this.PMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.DataGridView dgMedico;
        private System.Windows.Forms.TextBox txtMedicoId;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}