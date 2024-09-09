namespace Quiet_Attic_Film
{
    partial class Staff_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Type));
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvstafftype = new System.Windows.Forms.DataGridView();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbstaffFee = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstafftype)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 50);
            this.label4.TabIndex = 23;
            this.label4.Text = "Staff Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 41);
            this.label6.TabIndex = 24;
            this.label6.Text = "Staff Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvstafftype
            // 
            this.dgvstafftype.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvstafftype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstafftype.GridColor = System.Drawing.Color.Lavender;
            this.dgvstafftype.Location = new System.Drawing.Point(12, 218);
            this.dgvstafftype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvstafftype.Name = "dgvstafftype";
            this.dgvstafftype.RowHeadersWidth = 51;
            this.dgvstafftype.RowTemplate.Height = 24;
            this.dgvstafftype.Size = new System.Drawing.Size(509, 257);
            this.dgvstafftype.TabIndex = 27;
            this.dgvstafftype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstafftype_CellContentClick);
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(247, 82);
            this.cmbStaffType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(164, 24);
            this.cmbStaffType.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbstaffFee
            // 
            this.cmbstaffFee.FormattingEnabled = true;
            this.cmbstaffFee.Location = new System.Drawing.Point(247, 162);
            this.cmbstaffFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstaffFee.Name = "cmbstaffFee";
            this.cmbstaffFee.Size = new System.Drawing.Size(164, 24);
            this.cmbstaffFee.TabIndex = 45;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(315, 490);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 60);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 490);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 60);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Staff_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(533, 562);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbstaffFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStaffType);
            this.Controls.Add(this.dgvstafftype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Staff_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Type";
            this.Load += new System.EventHandler(this.Staff_Type_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstafftype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvstafftype;
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbstaffFee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}