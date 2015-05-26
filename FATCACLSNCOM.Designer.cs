namespace FATCA
{
    partial class FATCACLSNCOM
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
            this.btnDownloadNONCOMPLIANT = new System.Windows.Forms.Button();
            this.btnViewFatcaNonComp = new System.Windows.Forms.Button();
            this.dataGridFatcaNonComplient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaNonComplient)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "FATCA NON COMPLIANT POLICY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDownloadNONCOMPLIANT
            // 
            this.btnDownloadNONCOMPLIANT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadNONCOMPLIANT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadNONCOMPLIANT.Image = global::FATCA.Properties.Resources.download1;
            this.btnDownloadNONCOMPLIANT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadNONCOMPLIANT.Location = new System.Drawing.Point(68, 116);
            this.btnDownloadNONCOMPLIANT.Name = "btnDownloadNONCOMPLIANT";
            this.btnDownloadNONCOMPLIANT.Size = new System.Drawing.Size(206, 48);
            this.btnDownloadNONCOMPLIANT.TabIndex = 4;
            this.btnDownloadNONCOMPLIANT.Text = "Download";
            this.btnDownloadNONCOMPLIANT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadNONCOMPLIANT.UseVisualStyleBackColor = true;
            this.btnDownloadNONCOMPLIANT.Click += new System.EventHandler(this.btnDownloadNONCOMPLIANT_Click);
            // 
            // btnViewFatcaNonComp
            // 
            this.btnViewFatcaNonComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFatcaNonComp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewFatcaNonComp.Image = global::FATCA.Properties.Resources.download1;
            this.btnViewFatcaNonComp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFatcaNonComp.Location = new System.Drawing.Point(305, 116);
            this.btnViewFatcaNonComp.Name = "btnViewFatcaNonComp";
            this.btnViewFatcaNonComp.Size = new System.Drawing.Size(206, 48);
            this.btnViewFatcaNonComp.TabIndex = 4;
            this.btnViewFatcaNonComp.Text = "View";
            this.btnViewFatcaNonComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFatcaNonComp.UseVisualStyleBackColor = true;
            this.btnViewFatcaNonComp.Click += new System.EventHandler(this.btnViewFatcaNonComp_Click);
            // 
            // dataGridFatcaNonComplient
            // 
            this.dataGridFatcaNonComplient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFatcaNonComplient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFatcaNonComplient.Location = new System.Drawing.Point(0, 170);
            this.dataGridFatcaNonComplient.Name = "dataGridFatcaNonComplient";
            this.dataGridFatcaNonComplient.Size = new System.Drawing.Size(549, 147);
            this.dataGridFatcaNonComplient.TabIndex = 5;
            // 
            // FATCACLSNCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 317);
            this.Controls.Add(this.dataGridFatcaNonComplient);
            this.Controls.Add(this.btnViewFatcaNonComp);
            this.Controls.Add(this.btnDownloadNONCOMPLIANT);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FATCACLSNCOM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatca non complaint";
            this.Load += new System.EventHandler(this.FATCACLSNCOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaNonComplient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownloadNONCOMPLIANT;
        private System.Windows.Forms.Button btnViewFatcaNonComp;
        private System.Windows.Forms.DataGridView dataGridFatcaNonComplient;
    }
}