namespace FATCA
{
    partial class FATCACHPOL
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
            this.txtBoxPolicyNumber = new System.Windows.Forms.TextBox();
            this.btnDownloadPolicy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridFATCAchangePolicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFATCAchangePolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "FATCA CHANGE POLICY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Policy Number:";
            // 
            // txtBoxPolicyNumber
            // 
            this.txtBoxPolicyNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxPolicyNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPolicyNumber.Location = new System.Drawing.Point(246, 132);
            this.txtBoxPolicyNumber.Name = "txtBoxPolicyNumber";
            this.txtBoxPolicyNumber.Size = new System.Drawing.Size(202, 31);
            this.txtBoxPolicyNumber.TabIndex = 5;
            // 
            // btnDownloadPolicy
            // 
            this.btnDownloadPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadPolicy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDownloadPolicy.Image = global::FATCA.Properties.Resources.download1;
            this.btnDownloadPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadPolicy.Location = new System.Drawing.Point(38, 170);
            this.btnDownloadPolicy.Name = "btnDownloadPolicy";
            this.btnDownloadPolicy.Size = new System.Drawing.Size(243, 48);
            this.btnDownloadPolicy.TabIndex = 6;
            this.btnDownloadPolicy.Text = "Download byPolicy";
            this.btnDownloadPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadPolicy.UseVisualStyleBackColor = true;
            this.btnDownloadPolicy.Click += new System.EventHandler(this.btnDownloadPolicy_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::FATCA.Properties.Resources.download1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(358, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "View";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridFATCAchangePolicy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFATCAchangePolicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFATCAchangePolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFATCAchangePolicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFATCAchangePolicy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFATCAchangePolicy.Location = new System.Drawing.Point(0, 224);
            this.dataGridFATCAchangePolicy.Name = "dataGridFATCAchangePolicy";
            this.dataGridFATCAchangePolicy.Size = new System.Drawing.Size(549, 125);
            this.dataGridFATCAchangePolicy.TabIndex = 7;
            // 
            // FATCACHPOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 349);
            this.Controls.Add(this.dataGridFATCAchangePolicy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDownloadPolicy);
            this.Controls.Add(this.txtBoxPolicyNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FATCACHPOL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATCACHPOL";
            this.Load += new System.EventHandler(this.FATCACHPOL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFATCAchangePolicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPolicyNumber;
        private System.Windows.Forms.Button btnDownloadPolicy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridFATCAchangePolicy;
    }
}