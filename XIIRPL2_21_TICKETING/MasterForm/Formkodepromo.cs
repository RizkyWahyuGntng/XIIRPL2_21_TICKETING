using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL2_01_Ticketing;

namespace XIIRPL2_21_TICKETING.MasterForm
{
    public partial class Formkodepromo : Form
    {

        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public Formkodepromo()
        {
            InitializeComponent();
        }

        private void Formkodepromo_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_kode_promo" + "(kode,persentase_diskon,maksimum_diskon,berlaku_sampai,deskripsi)" + "VALUES" + "('" + txtkodepromo.Text + "','" + txtpersentasedskon.Text + "','" + txtmaksimumdskon.Text + "','" + txtberlakusmpai.Text + "','" + txtdeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Kode Promo");
                view_data();
                koneksi.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtberlakusmpai_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtkodepromo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter
            ("SELECT * FROM tbl_kode_promo", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete") ;
                {
                    int id;
                    id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    try
                    {
                        koneksi.conn.Open();
                        String sql = "DELETE FROM tbl_kode_promo WHERE id=@id";
                        cmd = new NpgsqlCommand(sql, koneksi.conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Berhasil Di Simpan");
                            view_data();
                        }
                        else
                        {
                            MessageBox.Show("Data Tidak Berhasil Dihapus");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        koneksi.conn.Close();
                    }

                }

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
