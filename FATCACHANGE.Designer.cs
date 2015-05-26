namespace FATCA
{
    partial class FATCACHANGE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDownloadFATCACHANGE = new System.Windows.Forms.Button();
            this.vtnViewFatcaChange = new System.Windows.Forms.Button();
            this.dataGridFatcaChangePolicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaChangePolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Download Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(52, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "FATCA CHANGE POLICY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "2014-07-10";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 27);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2014, 7, 10, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "2014-07-11";
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 162);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(259, 27);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // btnDownloadFATCACHANGE
            // 
            this.btnDownloadFATCACHANGE.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadFATCACHANGE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDownloadFATCACHANGE.Image = global::FATCA.Properties.Resources.download1;
            this.btnDownloadFATCACHANGE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadFATCACHANGE.Location = new System.Drawing.Point(30, 206);
            this.btnDownloadFATCACHANGE.Name = "btnDownloadFATCACHANGE";
            this.btnDownloadFATCACHANGE.Size = new System.Drawing.Size(206, 48);
            this.btnDownloadFATCACHANGE.TabIndex = 0;
            this.btnDownloadFATCACHANGE.Text = "Download";
            this.btnDownloadFATCACHANGE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadFATCACHANGE.UseVisualStyleBackColor = true;
            this.btnDownloadFATCACHANGE.Click += new System.EventHandler(this.btnDownloadFATCACHANGE_Click);
            // 
            // vtnViewFatcaChange
            // 
            this.vtnViewFatcaChange.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtnViewFatcaChange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vtnViewFatcaChange.Image = global::FATCA.Properties.Resources.download1;
            this.vtnViewFatcaChange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vtnViewFatcaChange.Location = new System.Drawing.Point(274, 206);
            this.vtnViewFatcaChange.Name = "vtnViewFatcaChange";
            this.vtnViewFatcaChange.Size = new System.Drawing.Size(206, 48);
            this.vtnViewFatcaChange.TabIndex = 0;
            this.vtnViewFatcaChange.Text = "View";
            this.vtnViewFatcaChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vtnViewFatcaChange.UseVisualStyleBackColor = true;
            this.vtnViewFatcaChange.Click += new System.EventHandler(this.vtnViewFatcaChange_Click);
            // 
            // dataGridFatcaChangePolicy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFatcaChangePolicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFatcaChangePolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFatcaChangePolicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFatcaChangePolicy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFatcaChangePolicy.Location = new System.Drawing.Point(0, 260);
            this.dataGridFatcaChangePolicy.Name = "dataGridFatcaChangePolicy";
            this.dataGridFatcaChangePolicy.Size = new System.Drawing.Size(531, 123);
            this.dataGridFatcaChangePolicy.TabIndex = 9;
            // 
            // FATCACHANGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 383);
            this.Controls.Add(this.dataGridFatcaChangePolicy);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vtnViewFatcaChange);
            this.Controls.Add(this.btnDownloadFATCACHANGE);
            this.MaximizeBox = false;
            this.Name = "FATCACHANGE";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatca Change Policy";
            this.Load += new System.EventHandler(this.FATCACHANGE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaChangePolicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadFATCACHANGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button vtnViewFatcaChange;
        private System.Windows.Forms.DataGridView dataGridFatcaChangePolicy;
    }
}