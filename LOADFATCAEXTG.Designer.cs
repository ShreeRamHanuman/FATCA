namespace FATCA
{
    partial class LOADFATCAEXTG
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewFATCAInscopePolicy = new System.Windows.Forms.Button();
            this.dataGridFatcaInScopePolicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaInScopePolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 59);
            this.label2.TabIndex = 8;
            this.label2.Text = "FATCA IN SCOPE POLICY";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::FATCA.Properties.Resources.download1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(46, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Load FATCA EXTG Policy";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewFATCAInscopePolicy
            // 
            this.btnViewFATCAInscopePolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFATCAInscopePolicy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewFATCAInscopePolicy.Image = global::FATCA.Properties.Resources.download1;
            this.btnViewFATCAInscopePolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFATCAInscopePolicy.Location = new System.Drawing.Point(359, 160);
            this.btnViewFATCAInscopePolicy.Name = "btnViewFATCAInscopePolicy";
            this.btnViewFATCAInscopePolicy.Size = new System.Drawing.Size(162, 44);
            this.btnViewFATCAInscopePolicy.TabIndex = 13;
            this.btnViewFATCAInscopePolicy.Text = "View";
            this.btnViewFATCAInscopePolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFATCAInscopePolicy.UseVisualStyleBackColor = true;
            this.btnViewFATCAInscopePolicy.Click += new System.EventHandler(this.btnViewFATCAInscopePolicy_Click);
            // 
            // dataGridFatcaInScopePolicy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFatcaInScopePolicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFatcaInScopePolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFatcaInScopePolicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFatcaInScopePolicy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFatcaInScopePolicy.Location = new System.Drawing.Point(0, 274);
            this.dataGridFatcaInScopePolicy.Name = "dataGridFatcaInScopePolicy";
            this.dataGridFatcaInScopePolicy.Size = new System.Drawing.Size(549, 119);
            this.dataGridFatcaInScopePolicy.TabIndex = 17;
            // 
            // LOADFATCAEXTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 393);
            this.Controls.Add(this.dataGridFatcaInScopePolicy);
            this.Controls.Add(this.btnViewFATCAInscopePolicy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "LOADFATCAEXTG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOADFATCAEXTG";
            this.Load += new System.EventHandler(this.LOADFATCAEXTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaInScopePolicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewFATCAInscopePolicy;
        private System.Windows.Forms.DataGridView dataGridFatcaInScopePolicy;
    }
}