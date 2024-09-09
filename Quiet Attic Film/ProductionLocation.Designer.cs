namespace Quiet_Attic_Film
{
    partial class ProductionLocation
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbProductionID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocationID = new System.Windows.Forms.ComboBox();
            this.dgvproductionlocation = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductionlocation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(244, 475);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 60);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(20, 475);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 60);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbProductionID
            // 
            this.cmbProductionID.FormattingEnabled = true;
            this.cmbProductionID.Location = new System.Drawing.Point(244, 410);
            this.cmbProductionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductionID.Name = "cmbProductionID";
            this.cmbProductionID.Size = new System.Drawing.Size(164, 24);
            this.cmbProductionID.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 64;
            this.label1.Text = "Production";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLocationID
            // 
            this.cmbLocationID.FormattingEnabled = true;
            this.cmbLocationID.Location = new System.Drawing.Point(244, 347);
            this.cmbLocationID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocationID.Name = "cmbLocationID";
            this.cmbLocationID.Size = new System.Drawing.Size(164, 24);
            this.cmbLocationID.TabIndex = 63;
            // 
            // dgvproductionlocation
            // 
            this.dgvproductionlocation.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvproductionlocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductionlocation.GridColor = System.Drawing.Color.Lavender;
            this.dgvproductionlocation.Location = new System.Drawing.Point(11, 63);
            this.dgvproductionlocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproductionlocation.Name = "dgvproductionlocation";
            this.dgvproductionlocation.RowHeadersWidth = 51;
            this.dgvproductionlocation.RowTemplate.Height = 24;
            this.dgvproductionlocation.Size = new System.Drawing.Size(397, 250);
            this.dgvproductionlocation.TabIndex = 62;
            this.dgvproductionlocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductionlocation_CellContentClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 41);
            this.label6.TabIndex = 61;
            this.label6.Text = "Location";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 50);
            this.label4.TabIndex = 60;
            this.label4.Text = "Production Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductionLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(419, 546);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbProductionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLocationID);
            this.Controls.Add(this.dgvproductionlocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductionLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionLocation";
            this.Load += new System.EventHandler(this.ProductionLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductionlocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbProductionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocationID;
        private System.Windows.Forms.DataGridView dgvproductionlocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}