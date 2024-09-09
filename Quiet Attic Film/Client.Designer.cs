namespace Quiet_Attic_Film
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientContactNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 42);
            this.label4.TabIndex = 35;
            this.label4.Text = "Client Contact No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 42);
            this.label3.TabIndex = 34;
            this.label3.Text = "Client Name ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(520, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 583);
            this.label1.TabIndex = 33;
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.White;
            this.txtClientName.Location = new System.Drawing.Point(220, 104);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientName.Multiline = true;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(291, 42);
            this.txtClientName.TabIndex = 31;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1218, 480);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 60);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(999, 480);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 60);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Lavender;
            this.btnNew.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(774, 480);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(182, 60);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvclient
            // 
            this.dgvclient.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.GridColor = System.Drawing.Color.Lavender;
            this.dgvclient.Location = new System.Drawing.Point(545, 24);
            this.dgvclient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.ReadOnly = true;
            this.dgvclient.RowHeadersWidth = 51;
            this.dgvclient.RowTemplate.Height = 24;
            this.dgvclient.Size = new System.Drawing.Size(867, 404);
            this.dgvclient.TabIndex = 26;
            this.dgvclient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclient_CellContentClick);
            this.dgvclient.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclient_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 76);
            this.label2.TabIndex = 39;
            this.label2.Text = "Client Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(220, 200);
            this.txtClientAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(291, 131);
            this.txtClientAddress.TabIndex = 40;
            this.txtClientAddress.TextChanged += new System.EventHandler(this.txtClientAddress_TextChanged);
            // 
            // txtClientContactNo
            // 
            this.txtClientContactNo.Location = new System.Drawing.Point(220, 386);
            this.txtClientContactNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientContactNo.Multiline = true;
            this.txtClientContactNo.Name = "txtClientContactNo";
            this.txtClientContactNo.Size = new System.Drawing.Size(291, 42);
            this.txtClientContactNo.TabIndex = 41;
            this.txtClientContactNo.TextChanged += new System.EventHandler(this.txtClientContactNo_TextChanged);
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 138);
            this.label8.TabIndex = 37;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Lavender;
            this.btnInsert.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(545, 480);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(182, 60);
            this.btnInsert.TabIndex = 42;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 64);
            this.label5.TabIndex = 43;
            this.label5.Text = "Client Details ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1422, 573);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtClientContactNo);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvclient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtClientContactNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
    }
}