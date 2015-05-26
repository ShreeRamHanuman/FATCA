namespace FATCA
{
    partial class FATCAUS
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
            this.btnViewFatcaUsPerson = new System.Windows.Forms.Button();
            this.dataGridFatcaUsPerson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaUsPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(90, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 59);
            this.label2.TabIndex = 7;
            this.label2.Text = "FATCA US PERSON";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::FATCA.Properties.Resources.download1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(57, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Download";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnViewFatcaUsPerson
            // 
            this.btnViewFatcaUsPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFatcaUsPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewFatcaUsPerson.Image = global::FATCA.Properties.Resources.download1;
            this.btnViewFatcaUsPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFatcaUsPerson.Location = new System.Drawing.Point(302, 102);
            this.btnViewFatcaUsPerson.Name = "btnViewFatcaUsPerson";
            this.btnViewFatcaUsPerson.Size = new System.Drawing.Size(206, 48);
            this.btnViewFatcaUsPerson.TabIndex = 15;
            this.btnViewFatcaUsPerson.Text = "View";
            this.btnViewFatcaUsPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFatcaUsPerson.UseVisualStyleBackColor = true;
            this.btnViewFatcaUsPerson.Click += new System.EventHandler(this.btnViewFatcaUsPerson_Click);
            // 
            // dataGridFatcaUsPerson
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFatcaUsPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFatcaUsPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFatcaUsPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFatcaUsPerson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFatcaUsPerson.Location = new System.Drawing.Point(0, 167);
            this.dataGridFatcaUsPerson.Name = "dataGridFatcaUsPerson";
            this.dataGridFatcaUsPerson.Size = new System.Drawing.Size(549, 150);
            this.dataGridFatcaUsPerson.TabIndex = 16;
            // 
            // FATCAUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 317);
            this.Controls.Add(this.dataGridFatcaUsPerson);
            this.Controls.Add(this.btnViewFatcaUsPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FATCAUS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATCA US Person";
            this.Load += new System.EventHandler(this.FATCAUS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatcaUsPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewFatcaUsPerson;
        private System.Windows.Forms.DataGridView dataGridFatcaUsPerson;
    }
}