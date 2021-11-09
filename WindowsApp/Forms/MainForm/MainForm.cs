using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WindowsApp.Database;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Linq;

namespace WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        internal gibddEntities db = new gibddEntities();
        private readonly Regex emailRule = new Regex(
            @".+?@(.+\..+)+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private readonly Regex phoneRule = new Regex(
            @"(?<phone>^\d[\s\-]{0,1}\d{3}[\s\-]{0,1}\d{3}[\s\-]{0,1}\d{2}[\s\-]{0,1}\d{2}$)",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet.drivers". При необходимости она может быть перемещена или удалена.
           driversTableAdapter.Fill(this.gibddDataSet.drivers);
            driverPhoto ph = db.driverPhoto.AsNoTracking().FirstOrDefault();
            string result = ph.image_data.Replace("\x99\x11", "\x00");
            byte photo = Convert.ToByte(result);
            using (var ms = new MemoryStream(photo))
            {
                Image pic = Image.FromStream(ms);
                pictureBox2.Image = pic;
            }
            
          // MessageBox.Show();
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
            if (!emailRule.Match(emailTextBox.Text).Success)
                MessageBox.Show("E-mail is wrong!");
            if (!phoneRule.Match(phoneTextBox.Text).Success)
                MessageBox.Show("Phone number is wrong!");
            else
                driversBindingNavigatorSaveItem.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void doGET_button_Click(object sender, EventArgs e)
        {
            string url = $"http://solutions2019.hakta.pro/api/getFines?participant={partBox.Text}&modified={modifedDate.Value.ToString()}";
            getUrl.Text = url;
            dynamic stuff = JsonConvert.DeserializeObject(HttpGet(url));
            respOut.Text = stuff.data.ToString();

        }
        public string HttpGet(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string resp_out = sr.ReadToEnd(); 
            sr.Close();

            return resp_out;
           
        }

        public string HttpPost(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string resp_out = sr.ReadToEnd();

            sr.Close();

            return resp_out;
        }

        private void doPOST_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
