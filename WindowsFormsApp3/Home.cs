using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Home : Form
    {

        private DataProvider dataProvider = new DataProvider();
        private int id;
        public Home()
        {
            InitializeComponent();
            init();
        }

        

        private void init()
        {
            initBook();
        }

        private void initBook()
        {
            loadDataBook();
        }

        private void loadDataBook()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT * FROM Sach");

            dt = dataProvider.execQuery(query.ToString());
            dataGridView1.DataSource = dt;

            

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void book_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_author_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId == dataGridView1.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = dataGridView1.Rows[rowId];
            id = (int)row.Cells[0].Value;
            book_name.Text = row.Cells[1].Value.ToString();

            book_author.Text = row.Cells[2].Value.ToString();
            book_price.Text = row.Cells[3].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_sach ");
            query.Append("@Ten = N'" + book_name.Text + "'");
            query.Append(",@TacGia = N'" + book_author.Text + "'");
            query.Append(",@Gia = '" + book_price.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if(result > 0)
            {
                loadDataBook();
                MessageBox.Show("Them sach thanh cong!", "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Them sach khong thanh cong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_sach ");
            query.Append("@ID = " + id);
            query.Append(",@Ten = N'" + book_name.Text + "'");
            query.Append(",@TacGia = N'" + book_author.Text + "'");
            query.Append(",@Gia = '" + book_price.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDataBook();
                MessageBox.Show("Cap nhat thanh cong!", "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Cap nhat khong thanh cong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Ban co chac chan muon xoa sach " + book_name.Text + " ?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                StringBuilder query = new StringBuilder("DELETE FROM Sach WHERE ID = " + id);

                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDataBook();
                    MessageBox.Show("Xoa thanh cong!", "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Xoa khong thanh cong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
