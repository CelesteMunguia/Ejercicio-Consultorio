namespace Ejercicio_Consultorio
{
    partial class BuscarMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgMedic = new System.Windows.Forms.DataGridView();
            this.cbFiltrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el medico";
            // 
            // dgMedic
            // 
            this.dgMedic.AllowUserToAddRows = false;
            this.dgMedic.AllowUserToDeleteRows = false;
            this.dgMedic.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedic.Location = new System.Drawing.Point(12, 124);
            this.dgMedic.Name = "dgMedic";
            this.dgMedic.ReadOnly = true;
            this.dgMedic.RowHeadersWidth = 62;
            this.dgMedic.RowTemplate.Height = 28;
            this.dgMedic.Size = new System.Drawing.Size(776, 436);
            this.dgMedic.TabIndex = 8;
            this.dgMedic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedic_CellDoubleClick);
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.AutoSize = true;
            this.cbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrar.Location = new System.Drawing.Point(13, 90);
            this.cbFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(181, 26);
            this.cbFiltrar.TabIndex = 9;
            this.cbFiltrar.Text = "Filtrar solo activos";
            this.cbFiltrar.UseVisualStyleBackColor = true;
            this.cbFiltrar.CheckedChanged += new System.EventHandler(this.cbFiltrar_CheckedChanged);
            // 
            // BuscarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.dgMedic);
            this.Controls.Add(this.label1);
            this.Name = "BuscarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarMedico";
            this.Load += new System.EventHandler(this.BuscarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMedic;
        private System.Windows.Forms.CheckBox cbFiltrar;
    }
}