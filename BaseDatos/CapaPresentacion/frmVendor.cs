using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNego;

namespace CapaPresentacion
{
    public partial class frmVendor : Form
    {
        ManttoVendor mntt = new ManttoVendor();
        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
