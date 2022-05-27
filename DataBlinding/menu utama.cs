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
    public partial class menu_utama : Form
    {
        public menu_utama()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void menu_utama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa1' table. You can move, or remove it, as needed.
            this.mahasiswa1TableAdapter.Fill(this.prodiTIDataSet.Mahasiswa1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new datagridvie().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 kembali = new Form1();
            kembali.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Binding_Navigator().Show();
            this.Hide();
        }
    }
}
