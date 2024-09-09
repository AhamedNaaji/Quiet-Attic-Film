namespace Quiet_Attic_Film
{
    partial class PropertyLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyLocation));
            this.cmbPropertyID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocationID = new System.Windows.Forms.ComboBox();
            this.dgvPropertylocation = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertylocation)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPropertyID
            // 
            this.cmbPropertyID.FormattingEnabled = true;
            this.cmbPropertyID.Location = new System.Drawing.Point(247, 146);
            this.cmbPropertyID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPropertyID.Name = "cmbPropertyID";
            this.cmbPropertyID.Size = new System.Drawing.Size(164, 24);
            this.cmbPropertyID.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 50;
            this.label1.Text = "Property";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLocationID
            // 
            this.cmbLocationID.FormattingEnabled = true;
            this.cmbLocationID.Location = new System.Drawing.Point(247, 75);
            this.cmbLocationID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocationID.Name = "cmbLocationID";
            this.cmbLocationID.Size = new System.Drawing.Size(164, 24);
            this.cmbLocationID.TabIndex = 49;
            // 
            // dgvPropertylocation
            // 
            this.dgvPropertylocation.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvPropertylocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertylocation.GridColor = System.Drawing.Color.Lavender;
            this.dgvPropertylocation.Location = new System.Drawing.Point(47, 203);
            this.dgvPropertylocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPropertylocation.Name = "dgvPropertylocation";
            this.dgvPropertylocation.ReadOnly = true;
            this.dgvPropertylocation.RowHeadersWidth = 51;
            this.dgvPropertylocation.RowTemplate.Height = 24;
            this.dgvPropertylocation.Size = new System.Drawing.Size(380, 274);
            this.dgvPropertylocation.TabIndex = 48;
            this.dgvPropertylocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionlocation_CellContentClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 41);
            this.label6.TabIndex = 47;
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
            this.label4.Size = new System.Drawing.Size(459, 50);
            this.label4.TabIndex = 46;
            this.label4.Text = "Property Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(243, 487);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 60);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(47, 487);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 60);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PropertyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(459, 560);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPropertyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLocationID);
            this.Controls.Add(this.dgvPropertylocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PropertyLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PropertyLocation";
            this.Load += new System.EventHandler(this.PropertyLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertylocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPropertyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocationID;
        private System.Windows.Forms.DataGridView dgvPropertylocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}