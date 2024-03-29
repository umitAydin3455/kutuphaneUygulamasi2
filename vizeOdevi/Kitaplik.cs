using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeOdevi
{
    public partial class Kitaplik : Form
    {
        public Kitaplik()
        {
            InitializeComponent();
        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void VeriGetir_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde otomatik olarak DataGridView'e veri getir
            VeriGetir();
        }

        private void VeriGetir()
        {
            string jsonFilePath = "members.json";

            string json = File.ReadAllText(@ C: \Users\umita\OneDrive\Belgeler\json);

            var members = JsonConvert.DeserializeObject<List<Kitap>>(json);

            dataGridView1.DataSource = members;
        }

    }
    public class Kitap
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MembershipNumber { get; set; }
    }
}
