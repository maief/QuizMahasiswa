using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuizMahasiswa
{
    public partial class MasterBarang032 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANIF\SQLEXPRESS;Initial Catalog=MyPractice;Integrated Security=True;");
        DatabaseDataContext db = new DatabaseDataContext();
        public MasterBarang032()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            var data = from tb in db.tbl_barangs select tb;
            dataGridView1.DataSource = data;
        }

        void autoid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)),0) + 1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TxtBoxID.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        void clear()
        {
            TxtBoxID.Clear();
            TxtBoxNamaBarang.Clear();
            TxtBoxNamaBarangCari.Clear();
            TxtBoxNamaSupplier.Clear();
            TxtBoxNamaSupplierCari.Clear();
            TxtBoxHarga.Clear();
            TxtBoxStock.Clear();
        }

        private void MasterBarang032_Load(object sender, EventArgs e)
        {
            autoid();
            LoadData();
        }

        

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtBoxID.Text);
            string namabarang = TxtBoxNamaBarang.Text;
            int harga = int.Parse(TxtBoxHarga.Text);
            int stock = int.Parse(TxtBoxStock.Text);
            string namasupplier = TxtBoxNamaSupplier.Text;

            var data = new tbl_barang
            {
                id_barang = id,
                nama_barang = namabarang,
                harga = harga,
                stock = stock,
                nama_supplier = namasupplier
            };

            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Succesfully");
            clear();
            LoadData();
            autoid();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            var data = from s in db.tbl_barangs where s.nama_barang == TxtBoxNamaBarangCari.Text || s.nama_supplier == TxtBoxNamaSupplierCari.Text select s;
            dataGridView1.DataSource = data;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtBoxID.Text);
            string namabarang = TxtBoxNamaBarang.Text;
            int harga = int.Parse(TxtBoxHarga.Text);
            int stock = int.Parse(TxtBoxStock.Text);
            string namasupplier = TxtBoxNamaSupplier.Text;

            var data = (from s in db.tbl_barangs where s.id_barang == int.Parse(TxtBoxID.Text) select s).First();

            data.nama_barang = namabarang;
            data.harga = harga;
            data.stock = stock;
            data.nama_supplier = namasupplier;
            db.SubmitChanges();
            MessageBox.Show("Update Succesfuly");
            clear();
            LoadData();
            autoid();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            var data = (from s in db.tbl_barangs where s.nama_barang == TxtBoxNamaBarangCari.Text select s).First();
            db.tbl_barangs.DeleteOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Delete Succesfully");
            clear();
            LoadData();
            autoid();
        }
    }
}
