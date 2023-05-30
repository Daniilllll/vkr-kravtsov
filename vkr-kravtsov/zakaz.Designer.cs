namespace vkr_kravtsov
{
    partial class zakaz
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
            this.dgvZakaz = new System.Windows.Forms.DataGridView();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZakaz
            // 
            this.dgvZakaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaz.Location = new System.Drawing.Point(-2, 0);
            this.dgvZakaz.Name = "dgvZakaz";
            this.dgvZakaz.Size = new System.Drawing.Size(802, 340);
            this.dgvZakaz.TabIndex = 1;
            this.dgvZakaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvZakaz.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZakaz_RowEnter);
            // 
            // dgvPosition
            // 
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Location = new System.Drawing.Point(-2, 360);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(802, 340);
            this.dgvPosition.TabIndex = 2;
            // 
            // zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.dgvZakaz);
            this.Name = "zakaz";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvZakaz;
        private System.Windows.Forms.DataGridView dgvPosition;
    }
}