using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WindowsApp.Database;

namespace WindowsApp.Forms
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet.drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.gibddDataSet.drivers);
            
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gibddDataSet);

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
            driversBindingNavigatorSaveItem.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }
    }
}
