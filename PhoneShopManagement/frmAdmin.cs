﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShopManagement
{
    public partial class frmAdmin : Form
    {
        public string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        public frmAdmin()
        {
            InitializeComponent();
        }
    }
}
