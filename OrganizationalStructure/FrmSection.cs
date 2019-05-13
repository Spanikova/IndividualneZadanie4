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

namespace OrganizationalStructure
{
    public partial class FrmSection : Form
    {
        private OrganizationalLevel _orgLevel;
        private ActionType _action;

        public FrmSection(OrganizationalLevel orgLevel, ActionType action)
        {
            _orgLevel = orgLevel;
            _action = action;
            InitializeComponent();
        }
    }
}
