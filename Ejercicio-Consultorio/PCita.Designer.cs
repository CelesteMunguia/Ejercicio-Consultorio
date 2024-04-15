namespace Ejercicio_Consultorio
{
    partial class PCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCita));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCitaId = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.dtFechaa = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgcita = new System.Windows.Forms.DataGridView();
            this.btnGuardarr = new System.Windows.Forms.Button();
            this.btnEliminarr = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBMedic = new System.Windows.Forms.Button();
            this.btnBPaci = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombress = new System.Windows.Forms.TextBox();
            this.txtApellidoss = new System.Windows.Forms.TextBox();
            this.txtMeId = new System.Windows.Forms.TextBox();
            this.txtPaciId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgcita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cita Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Busque Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Busque Paciente";
            // 
            // txtCitaId
            // 
            this.txtCitaId.Location = new System.Drawing.Point(189, 44);
            this.txtCitaId.Name = "txtCitaId";
            this.txtCitaId.ReadOnly = true;
            this.txtCitaId.Size = new System.Drawing.Size(100, 26);
            this.txtCitaId.TabIndex = 5;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(983, 50);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(78, 24);
            this.cbEstado.TabIndex = 8;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Location = new System.Drawing.Point(21, 251);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(175, 24);
            this.cbActivos.TabIndex = 9;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            // 
            // dtFechaa
            // 
            this.dtFechaa.Location = new System.Drawing.Point(643, 48);
            this.dtFechaa.Name = "dtFechaa";
            this.dtFechaa.Size = new System.Drawing.Size(290, 26);
            this.dtFechaa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha Cita";
            // 
            // dgcita
            // 
            this.dgcita.AllowUserToAddRows = false;
            this.dgcita.AllowUserToDeleteRows = false;
            this.dgcita.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgcita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcita.Location = new System.Drawing.Point(12, 293);
            this.dgcita.Name = "dgcita";
            this.dgcita.ReadOnly = true;
            this.dgcita.RowHeadersWidth = 62;
            this.dgcita.RowTemplate.Height = 28;
            this.dgcita.Size = new System.Drawing.Size(1069, 312);
            this.dgcita.TabIndex = 12;
            this.dgcita.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcita_CellDoubleClick);
            // 
            // btnGuardarr
            // 
            this.btnGuardarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarr.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarr.Image")));
            this.btnGuardarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarr.Location = new System.Drawing.Point(533, 227);
            this.btnGuardarr.Name = "btnGuardarr";
            this.btnGuardarr.Size = new System.Drawing.Size(152, 48);
            this.btnGuardarr.TabIndex = 13;
            this.btnGuardarr.Text = "Guardar";
            this.btnGuardarr.UseVisualStyleBackColor = true;
            this.btnGuardarr.Click += new System.EventHandler(this.btnGuardarr_Click);
            // 
            // btnEliminarr
            // 
            this.btnEliminarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarr.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarr.Image")));
            this.btnEliminarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarr.Location = new System.Drawing.Point(733, 227);
            this.btnEliminarr.Name = "btnEliminarr";
            this.btnEliminarr.Size = new System.Drawing.Size(152, 48);
            this.btnEliminarr.TabIndex = 14;
            this.btnEliminarr.Text = "Eliminar";
            this.btnEliminarr.UseVisualStyleBackColor = true;
            this.btnEliminarr.Click += new System.EventHandler(this.btnEliminarr_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBMedic
            // 
            this.btnBMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMedic.Image = ((System.Drawing.Image)(resources.GetObject("btnBMedic.Image")));
            this.btnBMedic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBMedic.Location = new System.Drawing.Point(189, 82);
            this.btnBMedic.Name = "btnBMedic";
            this.btnBMedic.Size = new System.Drawing.Size(132, 47);
            this.btnBMedic.TabIndex = 15;
            this.btnBMedic.Text = "Buscar";
            this.btnBMedic.UseVisualStyleBackColor = true;
            this.btnBMedic.Click += new System.EventHandler(this.btnBMedic_Click);
            // 
            // btnBPaci
            // 
            this.btnBPaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBPaci.Image = ((System.Drawing.Image)(resources.GetObject("btnBPaci.Image")));
            this.btnBPaci.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBPaci.Location = new System.Drawing.Point(189, 139);
            this.btnBPaci.Name = "btnBPaci";
            this.btnBPaci.Size = new System.Drawing.Size(132, 49);
            this.btnBPaci.TabIndex = 16;
            this.btnBPaci.Text = "Buscar";
            this.btnBPaci.UseVisualStyleBackColor = true;
            this.btnBPaci.Click += new System.EventHandler(this.btnBPaci_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombres";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apellidos";
            // 
            // txtNombress
            // 
            this.txtNombress.Location = new System.Drawing.Point(643, 103);
            this.txtNombress.Name = "txtNombress";
            this.txtNombress.Size = new System.Drawing.Size(418, 26);
            this.txtNombress.TabIndex = 19;
            // 
            // txtApellidoss
            // 
            this.txtApellidoss.Location = new System.Drawing.Point(643, 157);
            this.txtApellidoss.Name = "txtApellidoss";
            this.txtApellidoss.Size = new System.Drawing.Size(418, 26);
            this.txtApellidoss.TabIndex = 20;
            // 
            // txtMeId
            // 
            this.txtMeId.Location = new System.Drawing.Point(386, 92);
            this.txtMeId.Name = "txtMeId";
            this.txtMeId.Size = new System.Drawing.Size(54, 26);
            this.txtMeId.TabIndex = 21;
            // 
            // txtPaciId
            // 
            this.txtPaciId.Location = new System.Drawing.Point(386, 153);
            this.txtPaciId.Name = "txtPaciId";
            this.txtPaciId.Size = new System.Drawing.Size(54, 26);
            this.txtPaciId.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID";
            // 
            // PCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 617);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPaciId);
            this.Controls.Add(this.txtMeId);
            this.Controls.Add(this.txtApellidoss);
            this.Controls.Add(this.txtNombress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBPaci);
            this.Controls.Add(this.btnBMedic);
            this.Controls.Add(this.btnEliminarr);
            this.Controls.Add(this.btnGuardarr);
            this.Controls.Add(this.dgcita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtFechaa);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtCitaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCita";
            this.Load += new System.EventHandler(this.PCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCitaId;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.DateTimePicker dtFechaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgcita;
        private System.Windows.Forms.Button btnGuardarr;
        private System.Windows.Forms.Button btnEliminarr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnBPaci;
        private System.Windows.Forms.Button btnBMedic;
        private System.Windows.Forms.TextBox txtApellidoss;
        private System.Windows.Forms.TextBox txtNombress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaciId;
        private System.Windows.Forms.TextBox txtMeId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}