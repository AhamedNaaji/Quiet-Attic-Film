namespace Quiet_Attic_Film
{
    partial class Production
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production));
            this.cmbclient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbproductiontype = new System.Windows.Forms.ComboBox();
            this.txtNoofDays = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvproduction = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduction)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbclient
            // 
            this.cmbclient.FormattingEnabled = true;
            this.cmbclient.Location = new System.Drawing.Point(272, 273);
            this.cmbclient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbclient.Name = "cmbclient";
            this.cmbclient.Size = new System.Drawing.Size(164, 24);
            this.cmbclient.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(-1, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 206);
            this.label8.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 41);
            this.label6.TabIndex = 36;
            this.label6.Text = "Client";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 41);
            this.label4.TabIndex = 35;
            this.label4.Text = "No of Days";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 58);
            this.label3.TabIndex = 34;
            this.label3.Text = "Production Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(467, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 519);
            this.label1.TabIndex = 33;
            // 
            // cmbproductiontype
            // 
            this.cmbproductiontype.FormattingEnabled = true;
            this.cmbproductiontype.Items.AddRange(new object[] {
            "Movie",
            "Ad"});
            this.cmbproductiontype.Location = new System.Drawing.Point(272, 395);
            this.cmbproductiontype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbproductiontype.Name = "cmbproductiontype";
            this.cmbproductiontype.Size = new System.Drawing.Size(164, 24);
            this.cmbproductiontype.TabIndex = 32;
            this.cmbproductiontype.SelectedIndexChanged += new System.EventHandler(this.cmbproductiontype_SelectedIndexChanged);
            // 
            // txtNoofDays
            // 
            this.txtNoofDays.Location = new System.Drawing.Point(272, 468);
            this.txtNoofDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoofDays.Multiline = true;
            this.txtNoofDays.Name = "txtNoofDays";
            this.txtNoofDays.Size = new System.Drawing.Size(164, 41);
            this.txtNoofDays.TabIndex = 31;
            this.txtNoofDays.TextChanged += new System.EventHandler(this.txtNoofDays_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(831, 378);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 60);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1157, 378);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 60);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(514, 378);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 60);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvproduction
            // 
            this.dgvproduction.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvproduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduction.GridColor = System.Drawing.Color.Lavender;
            this.dgvproduction.Location = new System.Drawing.Point(500, 11);
            this.dgvproduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproduction.Name = "dgvproduction";
            this.dgvproduction.ReadOnly = true;
            this.dgvproduction.RowHeadersWidth = 51;
            this.dgvproduction.RowTemplate.Height = 24;
            this.dgvproduction.Size = new System.Drawing.Size(861, 344);
            this.dgvproduction.TabIndex = 26;
            this.dgvproduction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduction_CellContentClick);
            this.dgvproduction.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduction_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(885, 70);
            this.label2.TabIndex = 39;
            this.label2.Text = "Production Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1373, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbclient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbproductiontype);
            this.Controls.Add(this.txtNoofDays);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvproduction);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Production";
            this.Text = "Production";
            this.Load += new System.EventHandler(this.Production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbclient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbproductiontype;
        private System.Windows.Forms.TextBox txtNoofDays;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvproduction;
        private System.Windows.Forms.Label label2;
    }
}