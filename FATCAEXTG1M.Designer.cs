namespace FATCA
{
    partial class FATCAEXTG1M
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.btnDownloadEXtScope = new System.Windows.Forms.Button();
            this.btnViewFatcaInScopePolicy = new System.Windows.Forms.Button();
            this.dataGridFatcaInscope = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaInscope)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 59);
            this.label2.TabIndex = 14;
            this.label2.Text = "FATCA IN SCOPE POLICY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Year:";
            // 
            // nmUpDownYear
            // 
            this.nmUpDownYear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUpDownYear.Location = new System.Drawing.Point(252, 117);
            this.nmUpDownYear.Maximum = new decimal(new int[] {
            3014,
            0,
            0,
            0});
            this.nmUpDownYear.Name = "nmUpDownYear";
            this.nmUpDownYear.Size = new System.Drawing.Size(95, 31);
            this.nmUpDownYear.TabIndex = 16;
            this.nmUpDownYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // btnDownloadEXtScope
            // 
            this.btnDownloadEXtScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadEXtScope.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadEXtScope.Image = global::FATCA.Properties.Resources.download1;
            this.btnDownloadEXtScope.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadEXtScope.Location = new System.Drawing.Point(48, 164);
            this.btnDownloadEXtScope.Name = "btnDownloadEXtScope";
            this.btnDownloadEXtScope.Size = new System.Drawing.Size(206, 48);
            this.btnDownloadEXtScope.TabIndex = 17;
            this.btnDownloadEXtScope.Text = "Download";
            this.btnDownloadEXtScope.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadEXtScope.UseVisualStyleBackColor = true;
            this.btnDownloadEXtScope.Click += new System.EventHandler(this.btnDownloadEXtScope_Click);
            // 
            // btnViewFatcaInScopePolicy
            // 
            this.btnViewFatcaInScopePolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFatcaInScopePolicy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewFatcaInScopePolicy.Image = global::FATCA.Properties.Resources.download1;
            this.btnViewFatcaInScopePolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFatcaInScopePolicy.Location = new System.Drawing.Point(298, 164);
            this.btnViewFatcaInScopePolicy.Name = "btnViewFatcaInScopePolicy";
            this.btnViewFatcaInScopePolicy.Size = new System.Drawing.Size(206, 48);
            this.btnViewFatcaInScopePolicy.TabIndex = 17;
            this.btnViewFatcaInScopePolicy.Text = "View";
            this.btnViewFatcaInScopePolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFatcaInScopePolicy.UseVisualStyleBackColor = true;
            this.btnViewFatcaInScopePolicy.Click += new System.EventHandler(this.btnViewFatcaInScopePolicy_Click);
            // 
            // dataGridFatcaInscope
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFatcaInscope.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFatcaInscope.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFatcaInscope.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFatcaInscope.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFatcaInscope.Location = new System.Drawing.Point(0, 234);
            this.dataGridFatcaInscope.Name = "dataGridFatcaInscope";
            this.dataGridFatcaInscope.Size = new System.Drawing.Size(549, 150);
            this.dataGridFatcaInscope.TabIndex = 18;
            // 
            // FATCAEXTG1M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.dataGridFatcaInscope);
            this.Controls.Add(this.btnViewFatcaInScopePolicy);
            this.Controls.Add(this.btnDownloadEXtScope);
            this.Controls.Add(this.nmUpDownYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.Name = "FATCAEXTG1M";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATCA Existing (1 Million USD) - Yearly";
            this.Load += new System.EventHandler(this.FATCAEXTG1M_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaInscope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmUpDownYear;
        private System.Windows.Forms.Button btnDownloadEXtScope;
        private System.Windows.Forms.Button btnViewFatcaInScopePolicy;
        private System.Windows.Forms.DataGridView dataGridFatcaInscope;
    }
}