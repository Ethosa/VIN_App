using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WindowsApp.Database;
using System.Text.RegularExpressions;

namespace WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private Regex emailRule = new Regex(
            @".+?@(.+\..+)+", RegexOptions.IgnoreCase | RegexOptions.Compiled);


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet.drivers". При необходимости она может быть перемещена или удалена.
           driversTableAdapter.Fill(this.gibddDataSet.drivers);
            
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            driversBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.gibddDataSet);

        }

        
 //driverPhoto.Image = Image.FromStream(new MemoryStream(new WebClient().DownloadData("http://localhost:28712/driverPhotos/" + photoTextBox.Text)));    

        private void button2_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (emailRule.Match(emailTextBox.Text).Success)
                driversBindingNavigatorSaveItem.PerformClick();
            else
                MessageBox.Show("Не-а");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }
    }
}
