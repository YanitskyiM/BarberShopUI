using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaWork
{
    public partial class WomenPage : UserControl
    {
        SqlConnection sqlConnection;
        public WomenPage()
        {
            InitializeComponent();
        }

        private async void WomenPage_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mushko\source\repos\DiplomaWork\DiplomaWork\Database1.mdf;Integrated Security=True";


              sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;

            SqlCommand commandWoMen = new SqlCommand("SELECT * FROM [Hairdressers] WHERE  Gender = 'Female' ", sqlConnection);

            try
            {
                sqlDataReader = await commandWoMen.ExecuteReaderAsync();

                while (await sqlDataReader.ReadAsync())
                {

                    comboBox1.Items.Add(Convert.ToString(sqlDataReader["Hairdressers_FName"]) + " " + Convert.ToString(sqlDataReader["Hairdressers_LName"]));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You choose {comboBox1.Text}, she will wait for you on {dateTimePicker1.Text}", "Done", MessageBoxButtons.OK);
        }
    }
}
