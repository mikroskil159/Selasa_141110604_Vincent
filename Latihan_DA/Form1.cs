using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Latihan_DA
{
    public partial class Latihan_DA : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter customerDA;
        // DataSet ds;
        DataTable dt;

        public Latihan_DA()
        {
            InitializeComponent();
        }

        private void Latihan_DA_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=testing;Uid=root;Pwd=;";
            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            // ds = new DataSet();
            dt = new DataTable();
            initializeDA();
            customerDA.SelectCommand.ExecuteScalar();
            // customerDA.Fill(ds, "customer");
            customerDA.Fill(dt);
            dgvDaftar.ReadOnly = true;
            dgvDaftar.AllowUserToAddRows = false;
            dgvDaftar.AllowUserToDeleteRows = false;
            dgvDaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingSource bs = new BindingSource();
            // bs.DataSource = ds.Tables["customer"];
            bs.DataSource = dt;
            dgvDaftar.DataSource = bs;
            // dgvDaftar.DataSource = ds.Tables["customer"];
        }

        private void initializeDA()
        {
            customerDA = new MySqlDataAdapter();

            // SELECT
            string customerSelectSql = String.Concat("SELECT * FROM customer");
            customerDA.SelectCommand = new MySqlCommand(customerSelectSql, conn);

            // INSERT
            string customerInsertSql = String.Concat("INSERT INTO customer (name, address, zip_code, phone_number, email,created_at,updated_at) VALUES (@name, @address, @zip_code, @phone_number, @email,@created_at,@updated_at)");
            /*string sql = "INSERT into customer (name,address,zip_code,phone_number,email,create_at,update_at)";
            sql += "VALUES(@name,@address,@zip_code,@phone_number,@email)";*/
            MySqlCommand customerInsertCommand = new MySqlCommand(customerInsertSql, conn);

            customerInsertCommand.Parameters.AddWithValue("@name", txName.Text);
            customerInsertCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerInsertCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerInsertCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerInsertCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerInsertCommand.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            customerInsertCommand.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            customerDA.InsertCommand = customerInsertCommand;
            //MessageBox.Show(sql);

            // UPDATE
            string customerUpdateSql = String.Concat("UPDATE customer SET name = @name, address = @address, zip_code = @zip_code, phone_number = @phone_number, email = @email, updated_at = @updated_at WHERE id = @id");
            MySqlCommand customerUpdateCommand = new MySqlCommand(customerUpdateSql, conn);
            customerUpdateCommand.Parameters.AddWithValue("@id", txId.Text);
            customerUpdateCommand.Parameters.AddWithValue("@name", txName.Text);
            customerUpdateCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerUpdateCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerUpdateCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerUpdateCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerUpdateCommand.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            customerDA.UpdateCommand = customerUpdateCommand;

            // DELETE
            

        }

        private void saveDB_Click(object sender, EventArgs e)
        {
            initializeDA();
            string pesan = "";
            if (txId.Text == "")
            {
                pesan = String.Concat(customerDA.InsertCommand.ExecuteNonQuery(), " Record succesfully saved.");
            }
            else
            {
                pesan = String.Concat(customerDA.UpdateCommand.ExecuteNonQuery(), " Record succesfully updated.");
            }
            MessageBox.Show(pesan, "Save Information");
            customerDA.SelectCommand.ExecuteScalar();
            dt.Clear();
            customerDA.Fill(dt);
        }

        private void resetForm_Click(object sender, EventArgs e)
        {
            txId.Clear();
            txName.Clear();
            txAddress.Clear();
            txZipCode.Clear();
            txPhoneNumber.Clear();
            txEmail.Clear();
        }

        private void deleteDB_Click(object sender, EventArgs e)
        {
            initializeDA();
            string pesan = "";
            if (dgvDaftar.SelectedRows.Count > 0)
            {
                string customerDeleteSql = String.Concat("DELETE FROM customer WHERE ID = @id");
                MySqlCommand customerDeleteCommand = new MySqlCommand(customerDeleteSql, conn);
                customerDeleteCommand.Parameters.AddWithValue("@id", dgvDaftar.SelectedCells[0].Value);
                customerDA.DeleteCommand = customerDeleteCommand;
                pesan = String.Concat(customerDA.DeleteCommand.ExecuteNonQuery(), " Record succesfully deleted.");
                customerDA.SelectCommand.ExecuteScalar();
                MessageBox.Show(pesan, "Save Information");
                dt.Clear();
                customerDA.Fill(dt);
            }
            else
            {
                MessageBox.Show("Nothing to Delete !");
            }
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Latihan_DA_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }

        private void dgvDaftar_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txId.Text = dgvDaftar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txName.Text = dgvDaftar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txAddress.Text = dgvDaftar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txZipCode.Text = dgvDaftar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txPhoneNumber.Text = dgvDaftar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txEmail.Text = dgvDaftar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
