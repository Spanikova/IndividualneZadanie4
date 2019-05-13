﻿namespace OrganizationalStructure
{
    partial class FrmStructure
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
            this.lblCompanies = new System.Windows.Forms.Label();
            this.dtGrdCompanies = new System.Windows.Forms.DataGridView();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.pnlCompanies = new System.Windows.Forms.Panel();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnDetailOfCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.pnlDivisions = new System.Windows.Forms.Panel();
            this.btnDeleteDivision = new System.Windows.Forms.Button();
            this.btnDetailOfDivision = new System.Windows.Forms.Button();
            this.btnUpdateDivision = new System.Windows.Forms.Button();
            this.dtGrdDivisions = new System.Windows.Forms.DataGridView();
            this.lblDivisions = new System.Windows.Forms.Label();
            this.btnNewDivision = new System.Windows.Forms.Button();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnDetailOfProject = new System.Windows.Forms.Button();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.dtGrdProjects = new System.Windows.Forms.DataGridView();
            this.lblProjects = new System.Windows.Forms.Label();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnDetailOfDepartment = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.dtGrdDepartments = new System.Windows.Forms.DataGridView();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.btnNewDepartment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnDetailOfEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.dtGrdEmployees = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCompanies)).BeginInit();
            this.pnlCompanies.SuspendLayout();
            this.pnlDivisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDivisions)).BeginInit();
            this.pnlProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProjects)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDepartments)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanies
            // 
            this.lblCompanies.AutoSize = true;
            this.lblCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompanies.Location = new System.Drawing.Point(28, 13);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(47, 20);
            this.lblCompanies.TabIndex = 0;
            this.lblCompanies.Text = "Firmy";
            // 
            // dtGrdCompanies
            // 
            this.dtGrdCompanies.AllowUserToAddRows = false;
            this.dtGrdCompanies.AllowUserToDeleteRows = false;
            this.dtGrdCompanies.AllowUserToResizeColumns = false;
            this.dtGrdCompanies.AllowUserToResizeRows = false;
            this.dtGrdCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCompanies.Location = new System.Drawing.Point(32, 124);
            this.dtGrdCompanies.Name = "dtGrdCompanies";
            this.dtGrdCompanies.ReadOnly = true;
            this.dtGrdCompanies.RowHeadersVisible = false;
            this.dtGrdCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdCompanies.Size = new System.Drawing.Size(212, 397);
            this.dtGrdCompanies.TabIndex = 1;
            this.dtGrdCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdCompanies_CellClick);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.Location = new System.Drawing.Point(141, 51);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(103, 23);
            this.btnNewCompany.TabIndex = 2;
            this.btnNewCompany.Tag = "0";
            this.btnNewCompany.Text = "Nová firma";
            this.btnNewCompany.UseVisualStyleBackColor = true;
            this.btnNewCompany.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // pnlCompanies
            // 
            this.pnlCompanies.Controls.Add(this.btnDeleteCompany);
            this.pnlCompanies.Controls.Add(this.btnDetailOfCompany);
            this.pnlCompanies.Controls.Add(this.btnUpdateCompany);
            this.pnlCompanies.Controls.Add(this.dtGrdCompanies);
            this.pnlCompanies.Controls.Add(this.lblCompanies);
            this.pnlCompanies.Controls.Add(this.btnNewCompany);
            this.pnlCompanies.Location = new System.Drawing.Point(12, 40);
            this.pnlCompanies.Name = "pnlCompanies";
            this.pnlCompanies.Size = new System.Drawing.Size(267, 570);
            this.pnlCompanies.TabIndex = 6;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(141, 80);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteCompany.TabIndex = 5;
            this.btnDeleteCompany.Tag = "0";
            this.btnDeleteCompany.Text = "Zmazať firmu";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDetailOfCompany
            // 
            this.btnDetailOfCompany.Location = new System.Drawing.Point(32, 51);
            this.btnDetailOfCompany.Name = "btnDetailOfCompany";
            this.btnDetailOfCompany.Size = new System.Drawing.Size(103, 23);
            this.btnDetailOfCompany.TabIndex = 4;
            this.btnDetailOfCompany.Tag = "0";
            this.btnDetailOfCompany.Text = "Zobraziť firmu";
            this.btnDetailOfCompany.UseVisualStyleBackColor = true;
            this.btnDetailOfCompany.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(32, 80);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateCompany.TabIndex = 3;
            this.btnUpdateCompany.Tag = "0";
            this.btnUpdateCompany.Text = "Upraviť firmu";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // pnlDivisions
            // 
            this.pnlDivisions.Controls.Add(this.btnDeleteDivision);
            this.pnlDivisions.Controls.Add(this.btnDetailOfDivision);
            this.pnlDivisions.Controls.Add(this.btnUpdateDivision);
            this.pnlDivisions.Controls.Add(this.dtGrdDivisions);
            this.pnlDivisions.Controls.Add(this.lblDivisions);
            this.pnlDivisions.Controls.Add(this.btnNewDivision);
            this.pnlDivisions.Location = new System.Drawing.Point(285, 40);
            this.pnlDivisions.Name = "pnlDivisions";
            this.pnlDivisions.Size = new System.Drawing.Size(267, 570);
            this.pnlDivisions.TabIndex = 7;
            // 
            // btnDeleteDivision
            // 
            this.btnDeleteDivision.Location = new System.Drawing.Point(141, 80);
            this.btnDeleteDivision.Name = "btnDeleteDivision";
            this.btnDeleteDivision.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteDivision.TabIndex = 6;
            this.btnDeleteDivision.Tag = "1";
            this.btnDeleteDivision.Text = "Zmazať divíziu";
            this.btnDeleteDivision.UseVisualStyleBackColor = true;
            this.btnDeleteDivision.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDetailOfDivision
            // 
            this.btnDetailOfDivision.Location = new System.Drawing.Point(32, 51);
            this.btnDetailOfDivision.Name = "btnDetailOfDivision";
            this.btnDetailOfDivision.Size = new System.Drawing.Size(103, 23);
            this.btnDetailOfDivision.TabIndex = 5;
            this.btnDetailOfDivision.Tag = "1";
            this.btnDetailOfDivision.Text = "Zobraziť divíziu";
            this.btnDetailOfDivision.UseVisualStyleBackColor = true;
            this.btnDetailOfDivision.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnUpdateDivision
            // 
            this.btnUpdateDivision.Location = new System.Drawing.Point(32, 80);
            this.btnUpdateDivision.Name = "btnUpdateDivision";
            this.btnUpdateDivision.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateDivision.TabIndex = 4;
            this.btnUpdateDivision.Tag = "1";
            this.btnUpdateDivision.Text = "Upraviť divíziu";
            this.btnUpdateDivision.UseVisualStyleBackColor = true;
            this.btnUpdateDivision.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dtGrdDivisions
            // 
            this.dtGrdDivisions.AllowUserToAddRows = false;
            this.dtGrdDivisions.AllowUserToDeleteRows = false;
            this.dtGrdDivisions.AllowUserToResizeColumns = false;
            this.dtGrdDivisions.AllowUserToResizeRows = false;
            this.dtGrdDivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDivisions.Location = new System.Drawing.Point(32, 124);
            this.dtGrdDivisions.Name = "dtGrdDivisions";
            this.dtGrdDivisions.ReadOnly = true;
            this.dtGrdDivisions.RowHeadersVisible = false;
            this.dtGrdDivisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdDivisions.Size = new System.Drawing.Size(212, 397);
            this.dtGrdDivisions.TabIndex = 1;
            this.dtGrdDivisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdDivisions_CellClick);
            // 
            // lblDivisions
            // 
            this.lblDivisions.AutoSize = true;
            this.lblDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDivisions.Location = new System.Drawing.Point(28, 13);
            this.lblDivisions.Name = "lblDivisions";
            this.lblDivisions.Size = new System.Drawing.Size(91, 20);
            this.lblDivisions.TabIndex = 0;
            this.lblDivisions.Text = "Divízie firmy";
            // 
            // btnNewDivision
            // 
            this.btnNewDivision.Location = new System.Drawing.Point(141, 51);
            this.btnNewDivision.Name = "btnNewDivision";
            this.btnNewDivision.Size = new System.Drawing.Size(103, 23);
            this.btnNewDivision.TabIndex = 2;
            this.btnNewDivision.Tag = "1";
            this.btnNewDivision.Text = "Nová divízia";
            this.btnNewDivision.UseVisualStyleBackColor = true;
            this.btnNewDivision.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.btnDeleteProject);
            this.pnlProjects.Controls.Add(this.btnDetailOfProject);
            this.pnlProjects.Controls.Add(this.btnUpdateProject);
            this.pnlProjects.Controls.Add(this.dtGrdProjects);
            this.pnlProjects.Controls.Add(this.lblProjects);
            this.pnlProjects.Controls.Add(this.btnNewProject);
            this.pnlProjects.Location = new System.Drawing.Point(558, 40);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(267, 570);
            this.pnlProjects.TabIndex = 8;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(141, 80);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteProject.TabIndex = 7;
            this.btnDeleteProject.Tag = "2";
            this.btnDeleteProject.Text = "Zmazať projekt";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDetailOfProject
            // 
            this.btnDetailOfProject.Location = new System.Drawing.Point(32, 51);
            this.btnDetailOfProject.Name = "btnDetailOfProject";
            this.btnDetailOfProject.Size = new System.Drawing.Size(103, 23);
            this.btnDetailOfProject.TabIndex = 6;
            this.btnDetailOfProject.Tag = "2";
            this.btnDetailOfProject.Text = "Zobraziť projekt";
            this.btnDetailOfProject.UseVisualStyleBackColor = true;
            this.btnDetailOfProject.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(32, 80);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateProject.TabIndex = 5;
            this.btnUpdateProject.Tag = "2";
            this.btnUpdateProject.Text = "Upraviť projekt";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dtGrdProjects
            // 
            this.dtGrdProjects.AllowUserToAddRows = false;
            this.dtGrdProjects.AllowUserToDeleteRows = false;
            this.dtGrdProjects.AllowUserToResizeColumns = false;
            this.dtGrdProjects.AllowUserToResizeRows = false;
            this.dtGrdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdProjects.Location = new System.Drawing.Point(32, 124);
            this.dtGrdProjects.Name = "dtGrdProjects";
            this.dtGrdProjects.ReadOnly = true;
            this.dtGrdProjects.RowHeadersVisible = false;
            this.dtGrdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdProjects.Size = new System.Drawing.Size(212, 397);
            this.dtGrdProjects.TabIndex = 1;
            this.dtGrdProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdProjects_CellClick);
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProjects.Location = new System.Drawing.Point(28, 13);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(111, 20);
            this.lblProjects.TabIndex = 0;
            this.lblProjects.Text = "Projekty divízie";
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(141, 51);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(103, 23);
            this.btnNewProject.TabIndex = 2;
            this.btnNewProject.Tag = "2";
            this.btnNewProject.Text = "Nový projekt";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteDepartment);
            this.panel1.Controls.Add(this.btnDetailOfDepartment);
            this.panel1.Controls.Add(this.btnUpdateDepartment);
            this.panel1.Controls.Add(this.dtGrdDepartments);
            this.panel1.Controls.Add(this.lblDepartments);
            this.panel1.Controls.Add(this.btnNewDepartment);
            this.panel1.Location = new System.Drawing.Point(831, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 570);
            this.panel1.TabIndex = 9;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(141, 80);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteDepartment.TabIndex = 7;
            this.btnDeleteDepartment.Tag = "3";
            this.btnDeleteDepartment.Text = "Zmazať oddelenie";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnDetailOfDepartment
            // 
            this.btnDetailOfDepartment.Location = new System.Drawing.Point(32, 51);
            this.btnDetailOfDepartment.Name = "btnDetailOfDepartment";
            this.btnDetailOfDepartment.Size = new System.Drawing.Size(103, 23);
            this.btnDetailOfDepartment.TabIndex = 6;
            this.btnDetailOfDepartment.Tag = "3";
            this.btnDetailOfDepartment.Text = "Zobraziť oddelenie";
            this.btnDetailOfDepartment.UseVisualStyleBackColor = true;
            this.btnDetailOfDepartment.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(32, 80);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateDepartment.TabIndex = 5;
            this.btnUpdateDepartment.Tag = "3";
            this.btnUpdateDepartment.Text = "Upraviť oddelenie";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dtGrdDepartments
            // 
            this.dtGrdDepartments.AllowUserToAddRows = false;
            this.dtGrdDepartments.AllowUserToDeleteRows = false;
            this.dtGrdDepartments.AllowUserToResizeColumns = false;
            this.dtGrdDepartments.AllowUserToResizeRows = false;
            this.dtGrdDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDepartments.Location = new System.Drawing.Point(32, 124);
            this.dtGrdDepartments.Name = "dtGrdDepartments";
            this.dtGrdDepartments.ReadOnly = true;
            this.dtGrdDepartments.RowHeadersVisible = false;
            this.dtGrdDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdDepartments.Size = new System.Drawing.Size(212, 397);
            this.dtGrdDepartments.TabIndex = 1;
            this.dtGrdDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdDepartments_CellClick);
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartments.Location = new System.Drawing.Point(28, 13);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(142, 20);
            this.lblDepartments.TabIndex = 0;
            this.lblDepartments.Text = "Oddelenia projektu";
            // 
            // btnNewDepartment
            // 
            this.btnNewDepartment.Location = new System.Drawing.Point(141, 51);
            this.btnNewDepartment.Name = "btnNewDepartment";
            this.btnNewDepartment.Size = new System.Drawing.Size(103, 23);
            this.btnNewDepartment.TabIndex = 2;
            this.btnNewDepartment.Tag = "3";
            this.btnNewDepartment.Text = "Nové oddelenie";
            this.btnNewDepartment.UseVisualStyleBackColor = true;
            this.btnNewDepartment.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteEmployee);
            this.panel2.Controls.Add(this.btnDetailOfEmployee);
            this.panel2.Controls.Add(this.btnUpdateEmployee);
            this.panel2.Controls.Add(this.dtGrdEmployees);
            this.panel2.Controls.Add(this.lblEmployees);
            this.panel2.Controls.Add(this.btnEmployees);
            this.panel2.Location = new System.Drawing.Point(1104, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 570);
            this.panel2.TabIndex = 10;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(170, 80);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnDeleteEmployee.TabIndex = 8;
            this.btnDeleteEmployee.Text = "Zmazať zamestnanca";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDetailOfEmployee
            // 
            this.btnDetailOfEmployee.Location = new System.Drawing.Point(32, 51);
            this.btnDetailOfEmployee.Name = "btnDetailOfEmployee";
            this.btnDetailOfEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnDetailOfEmployee.TabIndex = 7;
            this.btnDetailOfEmployee.Text = "Zobraziť zamestnanca";
            this.btnDetailOfEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(32, 80);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnUpdateEmployee.TabIndex = 6;
            this.btnUpdateEmployee.Text = "Upraviť zamestnanca";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // dtGrdEmployees
            // 
            this.dtGrdEmployees.AllowUserToAddRows = false;
            this.dtGrdEmployees.AllowUserToDeleteRows = false;
            this.dtGrdEmployees.AllowUserToResizeColumns = false;
            this.dtGrdEmployees.AllowUserToResizeRows = false;
            this.dtGrdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdEmployees.Location = new System.Drawing.Point(32, 124);
            this.dtGrdEmployees.Name = "dtGrdEmployees";
            this.dtGrdEmployees.ReadOnly = true;
            this.dtGrdEmployees.RowHeadersVisible = false;
            this.dtGrdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdEmployees.Size = new System.Drawing.Size(270, 397);
            this.dtGrdEmployees.TabIndex = 1;
            this.dtGrdEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdEmployees_CellClick);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployees.Location = new System.Drawing.Point(28, 13);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(165, 20);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Zamestanci oddelenia";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(170, 51);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(132, 23);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Nový zamestnanec";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // FrmStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.pnlDivisions);
            this.Controls.Add(this.pnlCompanies);
            this.Name = "FrmStructure";
            this.Text = "Organizačná štruktúra";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCompanies)).EndInit();
            this.pnlCompanies.ResumeLayout(false);
            this.pnlCompanies.PerformLayout();
            this.pnlDivisions.ResumeLayout(false);
            this.pnlDivisions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDivisions)).EndInit();
            this.pnlProjects.ResumeLayout(false);
            this.pnlProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDepartments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanies;
        private System.Windows.Forms.DataGridView dtGrdCompanies;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.Panel pnlCompanies;
        private System.Windows.Forms.Panel pnlDivisions;
        private System.Windows.Forms.DataGridView dtGrdDivisions;
        private System.Windows.Forms.Label lblDivisions;
        private System.Windows.Forms.Button btnNewDivision;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.DataGridView dtGrdProjects;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGrdDepartments;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Button btnNewDepartment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtGrdEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnUpdateDivision;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDetailOfCompany;
        private System.Windows.Forms.Button btnDetailOfDivision;
        private System.Windows.Forms.Button btnDetailOfProject;
        private System.Windows.Forms.Button btnDetailOfDepartment;
        private System.Windows.Forms.Button btnDetailOfEmployee;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnDeleteDivision;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}

