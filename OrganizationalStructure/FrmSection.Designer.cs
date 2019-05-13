namespace OrganizationalStructure
{
    partial class FrmSection
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
            this.lblSection = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSuperiorSection = new System.Windows.Forms.Label();
            this.cmbSuperiorSection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSection.Location = new System.Drawing.Point(33, 24);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(99, 20);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "Typ štruktúry";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(34, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Názov:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCode.Location = new System.Drawing.Point(34, 129);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 16);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Kód:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(175, 129);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(197, 20);
            this.txtCode.TabIndex = 5;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManager.Location = new System.Drawing.Point(34, 214);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(136, 16);
            this.lblManager.TabIndex = 6;
            this.lblManager.Text = "Vedúci zamestnanec:";
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(175, 214);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(197, 21);
            this.cmbManager.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(297, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblSuperiorSection
            // 
            this.lblSuperiorSection.AutoSize = true;
            this.lblSuperiorSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuperiorSection.Location = new System.Drawing.Point(34, 171);
            this.lblSuperiorSection.Name = "lblSuperiorSection";
            this.lblSuperiorSection.Size = new System.Drawing.Size(136, 16);
            this.lblSuperiorSection.TabIndex = 9;
            this.lblSuperiorSection.Text = "Nadriadená štruktúra:";
            // 
            // cmbSuperiorSection
            // 
            this.cmbSuperiorSection.FormattingEnabled = true;
            this.cmbSuperiorSection.Location = new System.Drawing.Point(175, 171);
            this.cmbSuperiorSection.Name = "cmbSuperiorSection";
            this.cmbSuperiorSection.Size = new System.Drawing.Size(197, 21);
            this.cmbSuperiorSection.TabIndex = 10;
            // 
            // FrmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 296);
            this.Controls.Add(this.cmbSuperiorSection);
            this.Controls.Add(this.lblSuperiorSection);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbManager);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSection);
            this.Name = "FrmSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSuperiorSection;
        private System.Windows.Forms.ComboBox cmbSuperiorSection;
    }
}