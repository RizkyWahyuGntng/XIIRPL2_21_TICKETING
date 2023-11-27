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
    public partial class Formmasterlistpenerbangan1 : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public Formmasterlistpenerbangan1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Formmasterlistpenerbangan1_Load(object sender, EventArgs e)
        {
            view_data();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter
            ("SELECT * FROM tbl_listpenerbangan", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                                String sql = "DELETE FROM tbl_listpenerbangan WHERE id=@id";
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
        }
    }
    
}
