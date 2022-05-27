using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBlinding
{
    public partial class Binding_Navigator : Form
    {
        public Binding_Navigator()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Binding_Navigator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet4.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet4.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_utama kembali = new menu_utama();
            kembali.Show();
            this.Hide();
        }
    }
}
