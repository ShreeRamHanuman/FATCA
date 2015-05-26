namespace FATCA
{
    partial class FATCACLS
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
            this.btnViewFATCACLS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridFATCAwaitingPolicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFATCAwaitingPolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewFATCACLS
            // 
            this.btnViewFATCACLS.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFATCACLS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewFATCACLS.Image = global::FATCA.Properties.Resources.download1;
            this.btnViewFATCACLS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFATCACLS.Location = new System.Drawing.Point(280, 133);
            this.btnViewFATCACLS.Name = "btnViewFATCACLS";
            this.btnViewFATCACLS.Size = new System.Drawing.Size(206, 48);
            this.btnViewFATCACLS.TabIndex = 6;
            this.btnViewFATCACLS.Text = "View";
            this.btnViewFATCACLS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFATCACLS.UseVisualStyleBackColor = true;
            this.btnViewFATCACLS.Click += new System.EventHandler(this.btnViewFATCACLS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "FATCA WAITING POLICY";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::FATCA.Properties.Resources.download1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(29, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridFATCAwaitingPolicy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFATCAwaitingPolicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFATCAwaitingPolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFATCAwaitingPolicy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFATCAwaitingPolicy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFATCAwaitingPolicy.Location = new System.Drawing.Point(0, 187);
            this.dataGridFATCAwaitingPolicy.Name = "dataGridFATCAwaitingPolicy";
            this.dataGridFATCAwaitingPolicy.Size = new System.Drawing.Size(549, 130);
            this.dataGridFATCAwaitingPolicy.TabIndex = 7;
            // 
            // FATCACLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 317);
            this.Controls.Add(this.dataGridFATCAwaitingPolicy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewFATCACLS);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.Name = "FATCACLS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATCA Waiting";
            this.Load += new System.EventHandler(this.FATCACLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFATCAwaitingPolicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewFATCACLS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridFATCAwaitingPolicy;
    }
}