using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Foodreviews
{
    public partial class Form1 : Form
    {
        private const string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\FOOD REVIEWS\\Foodreviews\\Foodreviews\\Food Reviews DDL.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection sqlConnection;

        List<object> restaurants = new List<object>();

        private bool loggedIn;
        private string username;


        private void PopulateRestaurantList()
        {
            sqlConnection.Close();
            sqlConnection.Open();

            //setup query
            SqlCommand command = new SqlCommand("SELECT RestaurantName FROM Restaurants ORDER BY RestaurantName", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                checkedListBoxRN.Items.Clear();
                while (reader.Read())
                {
                    checkedListBoxRN.Items.Add(reader["RestaurantName"].ToString());
                }
            }
            sqlConnection.Close();
        }

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(CONNECT);
            incorrectPasswordWarning.Visible = false;
            restaurantNamesList.Visible = true;

            sqlConnection.Open();

            //setup query
            SqlCommand command = new SqlCommand("SELECT * FROM Users", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if ((string)reader["UserName"] == enterUsername.Text || (string)reader["UserEmail"] == enterUsername.Text)
                    {
                        if ((string)reader["UserPassword"] == enterPassword.Text)
                        {
                            loggedIn = true;
                            username = enterUsername.Text;
                            break;
                        }
                    }
                }
            }
            sqlConnection.Close();




        }

        private void GetTags()
        {
            sqlConnection.Open();

            //Tags query
            SqlCommand command = new SqlCommand("SELECT Tag FROM Tags ORDER BY Tag", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    restaurantType.Items.Add(reader["Tag"].ToString());
 
                }
            }

            
            //RESTAURANT NAME QUERY
            SqlCommand commandRestaurants = new SqlCommand("SELECT * FROM Restaurants", sqlConnection);

            using (SqlDataReader reader = commandRestaurants.ExecuteReader())
            {
                while (reader.Read())
                {
                    restaurants.Add(reader["RestaurantName"].ToString());
                }
            }
            sqlConnection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class restaurantDetails
        {
            public string RestaurantName { get; set; }
            public string Tags { get; set; }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            //setup query
            SqlCommand command = new SqlCommand("SELECT * FROM Users", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if ((string)reader["UserName"] == enterUsername.Text || (string)reader["UserEmail"] == enterUsername.Text)
                    {
                        if ((string)reader["UserPassword"] == enterPassword.Text)
                        {
                            loggedIn = true;
                            username = enterUsername.Text;
                            panelMain.Enabled = true;
                            incorrectPasswordWarning.Visible = false;
                            PopulateRestaurantList();
                            break;
                        }
                        else if ((string)reader["UserPassword"] != enterPassword.Text)
                        {
                        
                            incorrectPasswordWarning.Visible = true;
                        }
                    }
                }
            }
            sqlConnection.Close();

            if (loggedIn)
            {
                enterUsername.Hide();
                enterPassword.Hide();
                loginButton.Text = "Logout";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<restaurantDetails> restaurants = new List<restaurantDetails>();
            GetTags();
            panelMain.Enabled = false;
            restaurantNamesList.Enabled = false;
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void incorrectPasswordWarning_TextChanged(object sender, EventArgs e)
        {

        }

        private void restaurantType_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
