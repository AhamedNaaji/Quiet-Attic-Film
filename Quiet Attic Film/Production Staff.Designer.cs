namespace Quiet_Attic_Film
{
    partial class Production_Staff
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
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cmbProductionID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.dgvProductionstafftype = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionstafftype)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Lavender;
            this.btndelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(235, 466);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(164, 60);
            this.btndelete.TabIndex = 66;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lavender;
            this.btnsave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(11, 466);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(167, 60);
            this.btnsave.TabIndex = 67;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cmbProductionID
            // 
            this.cmbProductionID.FormattingEnabled = true;
            this.cmbProductionID.Location = new System.Drawing.Point(235, 401);
            this.cmbProductionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductionID.Name = "cmbProductionID";
            this.cmbProductionID.Size = new System.Drawing.Size(164, 24);
            this.cmbProductionID.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 41);
            this.label1.TabIndex = 64;
            this.label1.Text = "Production ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(235, 338);
            this.cmbStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(164, 24);
            this.cmbStaffID.TabIndex = 63;
            // 
            // dgvProductionstafftype
            // 
            this.dgvProductionstafftype.AccessibleName = "";
            this.dgvProductionstafftype.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvProductionstafftype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionstafftype.GridColor = System.Drawing.Color.Lavender;
            this.dgvProductionstafftype.Location = new System.Drawing.Point(11, 54);
            this.dgvProductionstafftype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductionstafftype.Name = "dgvProductionstafftype";
            this.dgvProductionstafftype.RowHeadersWidth = 51;
            this.dgvProductionstafftype.RowTemplate.Height = 24;
            this.dgvProductionstafftype.Size = new System.Drawing.Size(397, 250);
            this.dgvProductionstafftype.TabIndex = 62;
            this.dgvProductionstafftype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionstafftype_CellContentClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 41);
            this.label6.TabIndex = 61;
            this.label6.Text = "Staff ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 50);
            this.label4.TabIndex = 60;
            this.label4.Text = "Production Staff";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Production_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(421, 543);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbProductionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.dgvProductionstafftype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Production_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production_Staff";
            this.Load += new System.EventHandler(this.Production_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionstafftype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbProductionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.DataGridView dgvProductionstafftype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}