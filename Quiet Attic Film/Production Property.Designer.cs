namespace Quiet_Attic_Film
{
    partial class Production_Property
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
            this.cmbProductionID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPropertyID = new System.Windows.Forms.ComboBox();
            this.dgvproductionproperty = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductionproperty)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductionID
            // 
            this.cmbProductionID.FormattingEnabled = true;
            this.cmbProductionID.Location = new System.Drawing.Point(257, 418);
            this.cmbProductionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductionID.Name = "cmbProductionID";
            this.cmbProductionID.Size = new System.Drawing.Size(164, 24);
            this.cmbProductionID.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 56;
            this.label1.Text = "Production";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPropertyID
            // 
            this.cmbPropertyID.FormattingEnabled = true;
            this.cmbPropertyID.Location = new System.Drawing.Point(257, 356);
            this.cmbPropertyID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPropertyID.Name = "cmbPropertyID";
            this.cmbPropertyID.Size = new System.Drawing.Size(164, 24);
            this.cmbPropertyID.TabIndex = 55;
            // 
            // dgvproductionproperty
            // 
            this.dgvproductionproperty.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvproductionproperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductionproperty.GridColor = System.Drawing.Color.Lavender;
            this.dgvproductionproperty.Location = new System.Drawing.Point(23, 71);
            this.dgvproductionproperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproductionproperty.Name = "dgvproductionproperty";
            this.dgvproductionproperty.RowHeadersWidth = 51;
            this.dgvproductionproperty.RowTemplate.Height = 24;
            this.dgvproductionproperty.Size = new System.Drawing.Size(397, 250);
            this.dgvproductionproperty.TabIndex = 54;
            this.dgvproductionproperty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductionproperty_CellContentClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 41);
            this.label6.TabIndex = 53;
            this.label6.Text = "Property";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 50);
            this.label4.TabIndex = 52;
            this.label4.Text = "Production Property";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(257, 484);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 60);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(33, 484);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 60);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Production_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(451, 556);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbProductionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPropertyID);
            this.Controls.Add(this.dgvproductionproperty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Production_Property";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production_Property";
            this.Load += new System.EventHandler(this.Production_Property_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductionproperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPropertyID;
        private System.Windows.Forms.DataGridView dgvproductionproperty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}