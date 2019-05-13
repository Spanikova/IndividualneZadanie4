using OrganizationalStructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizationalStructure.Logic;
using OrganizationalStructure.Models;

namespace OrganizationalStructure
{
    public partial class FrmStructure : Form
    {
        private OrganizationalLevel _orgLevel;
        private ActionType _action;
        private OrgStructureLogic _logic = new OrgStructureLogic();

        public FrmStructure()
        {
            InitializeComponent();
            FillDtGrdSection(dtGrdCompanies, OrganizationalLevel.Company, null);
            dtGrdEmployees.DataSource = _logic.GetEmployeesOfCompany("111");
        }

        #region Buttons
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            _orgLevel = (OrganizationalLevel)((Button)sender).Tag;
            _action = ActionType.Detail;
            OpenFrmSection(_orgLevel, _action);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _orgLevel = (OrganizationalLevel)((Button)sender).Tag;
            _action = ActionType.Update;
            OpenFrmSection(_orgLevel, _action);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _orgLevel = (OrganizationalLevel)((Button)sender).Tag;
            _action = ActionType.Delete;
            OpenFrmSection(_orgLevel, _action);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            _orgLevel = (OrganizationalLevel)((Button)sender).Tag;
            _action = ActionType.New;
            OpenFrmSection(_orgLevel, _action);
        }
        #endregion

        private void OpenFrmSection(OrganizationalLevel orgLevel, ActionType action)
        {
            using (FrmSection newForm = new FrmSection(orgLevel, action))
            {
                newForm.ShowDialog();
            }
        }

        #region Fill DataGridViews
        private void FillDtGrdSection(DataGridView dataGridView, OrganizationalLevel level, int? superiorSectionId)
        {
            if (level.Equals(OrganizationalLevel.Company))
            {
                dataGridView.DataSource = _logic.GetCompanies(level);
            }
            else
            {
                dataGridView.DataSource = _logic.GetSections(level, superiorSectionId);
            }
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns["OrganizationalLevel"].Visible = false;
            dataGridView.Columns["ManagerID"].Visible = false;
            dataGridView.Columns["SuperiorSectionID"].Visible = false;
            dataGridView.Columns["Code"].HeaderText = "Kód";
            dataGridView.Columns["Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["Name"].HeaderText = "Názov";
            dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillDtGrdEmployees(int departmentId)
        {
            dtGrdEmployees.DataSource = _logic.GetEmployees(departmentId);
            dtGrdEmployees.Columns["ID"].Visible = false;
            dtGrdEmployees.Columns["Phone"].Visible = false;
            dtGrdEmployees.Columns["Email"].Visible = false;
            dtGrdEmployees.Columns["DepartmentID"].Visible = false;
            dtGrdEmployees.Columns["FirstName"].HeaderText = "Meno";
            dtGrdEmployees.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGrdEmployees.Columns["LastName"].HeaderText = "Priezvisko";
            dtGrdEmployees.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGrdEmployees.Columns["Title"].HeaderText = "Titul";
            dtGrdEmployees.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

        #region Read data from datagridviews
        private Section ReadSectionFromDtGrd(DataGridView dtGrd)
        {
            Section section = new Section();
            section.ID = (int)dtGrd.SelectedCells[0].Value;
            section.Name = dtGrd.SelectedCells[1].Value.ToString();
            section.Code = dtGrd.SelectedCells[2].Value.ToString();
            section.OrganizationalLevel = (OrganizationalLevel)dtGrd.SelectedCells[3].Value;
            section.ManagerID = (int?)dtGrd.SelectedCells[4].Value;
            section.SuperiorSectionID = (int?)dtGrd.SelectedCells[5].Value;
            return section;
        }

        private Employee ReadEmployeeFromDtGrd()
        {
            Employee employee = new Employee();
            employee.ID = (int)dtGrdEmployees.SelectedCells[0].Value;
            employee.FirstName = dtGrdEmployees.SelectedCells[1].Value.ToString();
            employee.LastName = dtGrdEmployees.SelectedCells[2].Value.ToString();
            employee.Title = dtGrdEmployees.SelectedCells[3].Value.ToString();
            employee.Phone = dtGrdEmployees.SelectedCells[4].Value.ToString();
            employee.Email = dtGrdEmployees.SelectedCells[5].Value.ToString();
            employee.DepartmentID = (int)dtGrdEmployees.SelectedCells[6].Value;
            return employee;
        }
        #endregion

        #region Datagridviews cell click
        private void dtGrdCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdSection(dtGrdDivisions, OrganizationalLevel.Division, section.ID);
            dtGrdProjects.DataSource = null;
            dtGrdDepartments.DataSource = null;
            FillDtGrdEmployees(section.ID);
        }

        private void dtGrdDivisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdSection(dtGrdProjects, OrganizationalLevel.Project, section.ID);
            dtGrdDepartments.DataSource = null;
            FillDtGrdEmployees(section.ID);
        }

        private void dtGrdProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdSection(dtGrdDepartments, OrganizationalLevel.Department, section.ID);
            FillDtGrdEmployees(section.ID);
        }

        private void dtGrdDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Section section = ReadSectionFromDtGrd((DataGridView)sender);
            FillDtGrdEmployees(section.ID);
        }

        private void dtGrdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = ReadEmployeeFromDtGrd();
        }
        #endregion
    }
}

