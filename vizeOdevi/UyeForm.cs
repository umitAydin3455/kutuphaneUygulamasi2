using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace vizeOdevi
{
    public partial class UyeForm : Form
    {
        public UyeForm()
        {
            InitializeComponent();
        }
        public void UyeForm_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
        private void VeriGetir()
        {

            string jsonFilePath = "members.json";

            string json = File.ReadAllText(@ C: \Users\umita\OneDrive\Belgeler\json);

            var members = JsonConvert.DeserializeObject<List<Uye>>(json);

            dataGridView1.DataSource = members;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string email = emailTextBox.Text;
            string tc = tcnoTextBox.Text;
            string sifre = textBoxSifre.Text;


            Uye uye = new Uye
            {
                Ad = ad,
                Soyad = soyad,
                Email = email,
                Sifre = sifre,
                Tc = tc,
            };

            string json = JsonConvert.SerializeObject(member, Formatting.Indented);

            string filePath = "members.json";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(json);
            }

            MessageBox.Show("Veri başarıyla dosyaya kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public class Uye
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Gmail { get; set; }
            public double Tc { get; set; }
            public double Sifre { get; set; }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
