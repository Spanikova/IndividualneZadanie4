using OrganizationalStructure.Data.Enums;
//using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationalStructure
{
    public partial class FrmStructure : Form
    {
        private OrganizationalLevel _orgLevel;
        private ActionType _action;


        public FrmStructure()
        {
            InitializeComponent();
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            _orgLevel =(OrganizationalLevel) ((Button)sender).Tag;
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

        private void OpenFrmSection(OrganizationalLevel orgLevel, ActionType action)
        {
            using (FrmSection newForm = new FrmSection(orgLevel, action))
            {
                newForm.ShowDialog();
            }
        }
    }
}
