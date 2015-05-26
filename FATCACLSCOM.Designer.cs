namespace FATCA
{
    partial class FATCACLSCOM
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownloadCompliant = new System.Windows.Forms.Button();
            this.btnViewFatcaCompliantPolicy = new System.Windows.Forms.Button();
            this.dataGridFatcaCompliantPolicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaCompliantPolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "FATCA COMPLIANT POLICY";
            // 
            // btnDownloadCompliant
            // 
            this.btnDownloadCompliant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadCompliant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadCompliant.Image = global::FATCA.Properties.Resources.download1;
            this.btnDownloadCompliant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadCompliant.Location = new System.Drawing.Point(58, 120);
            this.btnDownloadCompliant.Name = "btnDownloadCompliant";
            this.btnDownloadCompliant.Size = new System.Drawing.Size(206, 48);
            this.btnDownloadCompliant.TabIndex = 4;
            this.btnDownloadCompliant.Text = "Download";
            this.btnDownloadCompliant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadCompliant.UseVisualStyleBackColor = true;
            this.btnDownloadCompliant.Click += new System.EventHandler(this.btnDownloadCompliant_Click);
            // 
            // btnViewFatcaCompliantPolicy
            // 
            this.btnViewFatcaCompliantPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFatcaCompliantPolicy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewFatcaCompliantPolicy.Image = global::FATCA.Properties.Resources.download1;
            this.btnViewFatcaCompliantPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFatcaCompliantPolicy.Location = new System.Drawing.Point(294, 120);
            this.btnViewFatcaCompliantPolicy.Name = "btnViewFatcaCompliantPolicy";
            this.btnViewFatcaCompliantPolicy.Size = new System.Drawing.Size(206, 48);
            this.btnViewFatcaCompliantPolicy.TabIndex = 4;
            this.btnViewFatcaCompliantPolicy.Text = "View";
            this.btnViewFatcaCompliantPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFatcaCompliantPolicy.UseVisualStyleBackColor = true;
            this.btnViewFatcaCompliantPolicy.Click += new System.EventHandler(this.btnViewFatcaCompliantPolicy_Click);
            // 
            // dataGridFatcaCompliantPolicy
            // 
            this.dataGridFatcaCompliantPolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFatcaCompliantPolicy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFatcaCompliantPolicy.Location = new System.Drawing.Point(0, 174);
            this.dataGridFatcaCompliantPolicy.Name = "dataGridFatcaCompliantPolicy";
            this.dataGridFatcaCompliantPolicy.Size = new System.Drawing.Size(549, 143);
            this.dataGridFatcaCompliantPolicy.TabIndex = 5;
            // 
            // FATCACLSCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 317);
            this.Controls.Add(this.dataGridFatcaCompliantPolicy);
            this.Controls.Add(this.btnViewFatcaCompliantPolicy);
            this.Controls.Add(this.btnDownloadCompliant);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.Name = "FATCACLSCOM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATCACLSCOM";
            this.Load += new System.EventHandler(this.FATCACLSCOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaCompliantPolicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownloadCompliant;
        private System.Windows.Forms.Button btnViewFatcaCompliantPolicy;
        private System.Windows.Forms.DataGridView dataGridFatcaCompliantPolicy;
    }
}