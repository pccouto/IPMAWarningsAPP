namespace IPMAWarningsApp.Views
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.ComboBox comboBoxIdAreaAviso;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer do Windows Form

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.comboBoxIdAreaAviso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(12, 12);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(100, 23);
            this.btnFetchData.TabIndex = 1;
            this.btnFetchData.Text = "Buscar Dados";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // comboBoxIdAreaAviso
            // 
            this.comboBoxIdAreaAviso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdAreaAviso.FormattingEnabled = true;
            this.comboBoxIdAreaAviso.Location = new System.Drawing.Point(130, 12);
            this.comboBoxIdAreaAviso.Name = "comboBoxIdAreaAviso";
            this.comboBoxIdAreaAviso.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdAreaAviso.TabIndex = 2;
            this.comboBoxIdAreaAviso.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdAreaAviso_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.Load += new System.EventHandler(this.Form1_Load); // Comente ou remova esta linha se não for necessária
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxIdAreaAviso);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
