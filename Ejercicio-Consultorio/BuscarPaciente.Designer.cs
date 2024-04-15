namespace Ejercicio_Consultorio
{
    partial class BuscarPaciente
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
            this.dgBPa = new System.Windows.Forms.DataGridView();
            this.cbFiltrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBPa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione el paciente";
            // 
            // dgBPa
            // 
            this.dgBPa.AllowUserToAddRows = false;
            this.dgBPa.AllowUserToDeleteRows = false;
            this.dgBPa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgBPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBPa.Location = new System.Drawing.Point(12, 130);
            this.dgBPa.Name = "dgBPa";
            this.dgBPa.ReadOnly = true;
            this.dgBPa.RowHeadersWidth = 62;
            this.dgBPa.RowTemplate.Height = 28;
            this.dgBPa.Size = new System.Drawing.Size(776, 430);
            this.dgBPa.TabIndex = 9;
            this.dgBPa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBPa_CellDoubleClick);
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.AutoSize = true;
            this.cbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrar.Location = new System.Drawing.Point(13, 83);
            this.cbFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(181, 26);
            this.cbFiltrar.TabIndex = 10;
            this.cbFiltrar.Text = "Filtrar solo activos";
            this.cbFiltrar.UseVisualStyleBackColor = true;
            this.cbFiltrar.CheckedChanged += new System.EventHandler(this.cbFiltrar_CheckedChanged);
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.dgBPa);
            this.Controls.Add(this.label1);
            this.Name = "BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPaciente";
            this.Load += new System.EventHandler(this.BuscarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBPa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBPa;
        private System.Windows.Forms.CheckBox cbFiltrar;
    }
}