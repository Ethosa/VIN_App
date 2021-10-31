using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Modules;
namespace WindowsApp
{
    public partial class Auth : Form
    {
        OpenForms of = new OpenForms();
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            of.MainForm();
        }

    
    }
}
