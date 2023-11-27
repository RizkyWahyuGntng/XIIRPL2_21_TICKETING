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
    public partial class Formmasterjadwalpenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public Formmasterjadwalpenerbangan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_jadwal_penerbangan" + "(kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_waktu_penerbangan,durasi_penerbangan,harga_per_tiket)" + "VALUES" + "('" + txtDari.Text + "','" + txtDari.Text + "','" + txtKe.Text + "','" + txtMaskapai.Text + "','" + txtTanggal.Text + "','" + txtWaktuPenerbangan.Text + "','" + txtDurasiPenerbangan + "','" + txtHargaPerTiket + "')";
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

        private void Formmasterjadwalpenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter
            ("SELECT * FROM tbl_jadwal_penerbangan", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                {
                    if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete") ;
                    {
                        int id;
                        id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        try
                        {
                            koneksi.conn.Open();
                            String sql = "DELETE FROM tbl_jadwal_penerbangan WHERE id=@id";
                            cmd = new NpgsqlCommand(sql, koneksi.conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Data Berhasil Di hapus");
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
