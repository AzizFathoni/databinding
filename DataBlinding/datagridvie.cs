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
    public partial class datagridvie : Form
    {
        public datagridvie()
        {
            InitializeComponent();
        }

        private void datagridvie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet3.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter2.Fill(this.prodiTIDataSet3.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet2.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.prodiTIDataSet2.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa1' table. You can move, or remove it, as needed.
            this.mahasiswa1TableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa1);
            // TODO: This line of code loads data into the 'pRODIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.pRODIDataSet.mahasiswa);

            //Warna font pada satu kolom

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.YellowGreen;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.RosyBrown;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Yellow;

            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Brown;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.BlueViolet;

            //Warna kursor
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.BlueViolet;

            //Membuat data bagian jenis kelamin menjadi center
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void mahasiswa1BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_utama kembali = new menu_utama();
            kembali.Show();
            this.Hide();
        }
    }
}
