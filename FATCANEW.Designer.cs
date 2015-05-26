namespace FATCA
{
    partial class FATCANEW
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownloadNewPolicy = new System.Windows.Forms.Button();
            this.dataGridFATCAnewPolicyData = new System.Windows.Forms.DataGridView();
            this.btnViewFatcaNewPolicy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFATCAnewPolicyData)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(205, 150);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(288, 31);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 31);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2000, 6, 30, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Download Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 59);
            this.label2.TabIndex = 13;
            this.label2.Text = "FATCA NEW POLICY DATA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDownloadNewPolicy
            // 
            this.btnDownloadNewPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadNewPolicy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDownloadNewPolicy.Image = global::FATCA.Properties.Resources.download1;
            this.btnDownloadNewPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadNewPolicy.Location = new System.Drawing.Point(61, 187);
            this.btnDownloadNewPolicy.Name = "btnDownloadNewPolicy";
            this.btnDownloadNewPolicy.Size = new System.Drawing.Size(206, 48);
            this.btnDownloadNewPolicy.TabIndex = 14;
            this.btnDownloadNewPolicy.Text = "Download";
            this.btnDownloadNewPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadNewPolicy.UseVisualStyleBackColor = true;
            this.btnDownloadNewPolicy.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridFATCAnewPolicyData
            // 
            this.dataGridFATCAnewPolicyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFATCAnewPolicyData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFATCAnewPolicyData.Location = new System.Drawing.Point(0, 262);
            this.dataGridFATCAnewPolicyData.Name = "dataGridFATCAnewPolicyData";
            this.dataGridFATCAnewPolicyData.Size = new System.Drawing.Size(549, 150);
            this.dataGridFATCAnewPolicyData.TabIndex = 18;
            // 
            // btnViewFatcaNewPolicy
            // 
            this.btnViewFatcaNewPolicy.Enabled = false;
            this.btnViewFatcaNewPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFatcaNewPolicy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnViewFatcaNewPolicy.Location = new System.Drawing.Point(333, 187);
            this.btnViewFatcaNewPolicy.Name = "btnViewFatcaNewPolicy";
            this.btnViewFatcaNewPolicy.Size = new System.Drawing.Size(167, 42);
            this.btnViewFatcaNewPolicy.TabIndex = 19;
            this.btnViewFatcaNewPolicy.Text = "View";
            this.btnViewFatcaNewPolicy.UseVisualStyleBackColor = true;
            this.btnViewFatcaNewPolicy.Click += new System.EventHandler(this.btnViewFatcaNewPolicy_Click);
            // 
            // FATCANEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 412);
            this.Controls.Add(this.btnViewFatcaNewPolicy);
            this.Controls.Add(this.dataGridFATCAnewPolicyData);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownloadNewPolicy);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FATCANEW";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATCA new policy data";
            this.Load += new System.EventHandler(this.FATCANEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFATCAnewPolicyData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadNewPolicy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridFATCAnewPolicyData;
        private System.Windows.Forms.Button btnViewFatcaNewPolicy;
    }
}