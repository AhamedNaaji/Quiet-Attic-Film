namespace Quiet_Attic_Film
{
    partial class Property
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property));
            this.cmbpropertytype = new System.Windows.Forms.ComboBox();
            this.dgvproperty = new System.Windows.Forms.DataGridView();
            this.txtpropertyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproperty)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbpropertytype
            // 
            this.cmbpropertytype.FormattingEnabled = true;
            this.cmbpropertytype.Items.AddRange(new object[] {
            "Vehicle",
            "Furniture",
            "Building"});
            this.cmbpropertytype.Location = new System.Drawing.Point(403, 162);
            this.cmbpropertytype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbpropertytype.Name = "cmbpropertytype";
            this.cmbpropertytype.Size = new System.Drawing.Size(265, 24);
            this.cmbpropertytype.TabIndex = 7;
            // 
            // dgvproperty
            // 
            this.dgvproperty.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvproperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproperty.Location = new System.Drawing.Point(12, 215);
            this.dgvproperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproperty.Name = "dgvproperty";
            this.dgvproperty.ReadOnly = true;
            this.dgvproperty.RowHeadersWidth = 51;
            this.dgvproperty.RowTemplate.Height = 24;
            this.dgvproperty.Size = new System.Drawing.Size(776, 223);
            this.dgvproperty.TabIndex = 8;
            this.dgvproperty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproperty_CellContentClick);
            // 
            // txtpropertyName
            // 
            this.txtpropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpropertyName.Location = new System.Drawing.Point(403, 81);
            this.txtpropertyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpropertyName.Multiline = true;
            this.txtpropertyName.Name = "txtpropertyName";
            this.txtpropertyName.Size = new System.Drawing.Size(265, 41);
            this.txtpropertyName.TabIndex = 10;
            this.txtpropertyName.TextChanged += new System.EventHandler(this.txtpropertyName_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "Property Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 49);
            this.label3.TabIndex = 13;
            this.label3.Text = "Property Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 50);
            this.label4.TabIndex = 14;
            this.label4.Text = "Property Info";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(239, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 60);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(28, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 60);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(440, 453);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 60);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Lavender;
            this.btnNew.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(651, 453);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 60);
            this.btnNew.TabIndex = 34;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpropertyName);
            this.Controls.Add(this.dgvproperty);
            this.Controls.Add(this.cmbpropertytype);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Property";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.Property_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbpropertytype;
        private System.Windows.Forms.DataGridView dgvproperty;
        private System.Windows.Forms.TextBox txtpropertyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}