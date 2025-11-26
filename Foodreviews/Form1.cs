using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Foodreviews
{
    public partial class Form1 : Form
    {
        private const string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\FOOD REVIEWS\\Foodreviews\\Foodreviews\\Food Reviews DDL.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(CONNECT);
        }

        private void GetTags()
        {
            sqlConnection.Open();

            //setup query
            SqlCommand command = new SqlCommand("SELECT Tag FROM Tags ORDER BY Tag", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    restaurantType.Items.Add(reader["Tag"]);
 
                }
            }
            sqlConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(enterUsername.Text == "admin" &&  enterPassword.Text == "1234")
            {
                panelMain.Enabled = true;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetTags();
            panelMain.Enabled = false;
        }
    }
}
