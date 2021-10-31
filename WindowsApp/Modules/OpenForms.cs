using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Forms;

namespace WindowsApp.Modules
{
    class OpenForms
    {
        public void MainForm() 
        {
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
    }
}
