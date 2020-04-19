﻿using Sintagri.UI.UsersControl;
using System.Windows.Forms;

namespace Sintagri
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, System.EventArgs e)
        {
            var _ordenIngreso = new IngresoOrdenControl(1);
            _ordenIngreso.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(_ordenIngreso);
        }
    }
}