using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace Trees_Zaimov
{
    public partial class Form1 : Form
    {
        string connstr = "server=10.6.0.33;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;" +
        "database=trees_zaimov";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection new opened");


            string str = "Select * from class";

            MySqlCommand query = new MySqlCommand("Select * From otdel ", connect);
            MySqlDataReader readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items.Add(item);


            }
            readerCombo.Close();
            cmb1.DataSource = items;
            cmb1.DisplayMember = "Text";
            cmb1.ValueMember = "Value";
            //

            query = new MySqlCommand("Select * From class", connect);
            readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items2 = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items2.Add(item);


            }
            readerCombo.Close();
            cmb2.DataSource = items2;
            cmb2.DisplayMember = "Text";
            cmb2.ValueMember = "Value";
            //

            query = new MySqlCommand("Select * From razred", connect);
            readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items3 = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items3.Add(item);


            }
            readerCombo.Close();
            cmb3.DataSource = items3;
            cmb3.DisplayMember = "Text";
            cmb3.ValueMember = "Value";
            //

            query = new MySqlCommand("Select * From family", connect);
            readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items4 = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items4.Add(item);


            }
            readerCombo.Close();
            cmb4.DataSource = items4;
            cmb4.DisplayMember = "Text";
            cmb4.ValueMember = "Value";
            //

            query = new MySqlCommand("Select * From rod", connect);
            readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items5 = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items5.Add(item);


            }
            readerCombo.Close();
            cmb5.DataSource = items5;
            cmb5.DisplayMember = "Text";
            cmb5.ValueMember = "Value";
            //

            query = new MySqlCommand("Select * From type", connect);
            readerCombo = query.ExecuteReader();
            List<ComboBoxItem> items6 = new List<ComboBoxItem>();
            while (readerCombo.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = readerCombo[1].ToString();
                item.Value = (int)readerCombo[0];

                items6.Add(item);
            }
            readerCombo.Close();
            cmb6.DataSource = items6;
            cmb6.DisplayMember = "Text";
            cmb6.ValueMember = "Value";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `trees_zaimov`.`tree`" +
                "(`name`, imageURL, " +
                "`otdel_id`, `class_id`, `razred_id`," +
                "`family_id`, `rod_id`, `vid_id`" +
                "`description`, DateLastUpdate)" +
                "VALUES (@name, @img, @otdel, @class," +
                "@razred, @family, @rod, @vid, @info, dateReg);";

            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MySqlCommand query = new MySqlCommand(sql, connect);

            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("@otdel", cmb1.SelectedValue);
            query.Parameters.AddWithValue("class", cmb2.SelectedValue);
            query.Parameters.AddWithValue("@razred", cmb3.SelectedValue);
            query.Parameters.AddWithValue("family", cmb4.SelectedValue);
            query.Parameters.AddWithValue("rod", cmb5.SelectedValue);
            query.Parameters.AddWithValue("@vid", cmb6.SelectedValue);
            query.Parameters.AddWithValue("@img", txt5.Text);
            query.Parameters.AddWithValue("@info", txt4.Text);
            query.Parameters.AddWithValue("@dateReg", DateAndTime.Now);

            query.ExecuteNonQuery();
            MessageBox.Show("Input OK");

            connect.Close();








        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `trees_zaimov`.`tree`" +
                "(`name`, imageURL, " +
                "`otdel_id`, `class_id`, `razred_id`," +
                "`family_id`, `rod_id`, `vid_id`," +
                "`description`, DateLastUpdate)" +
                "VALUES (@name, @img, @otdel, @class," +
                "@razred, @family, @rod, @vid, @info, @dateReg);";

            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MySqlCommand query = new MySqlCommand(sql, connect);

            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("@otdel", cmb1.SelectedValue);
            query.Parameters.AddWithValue("class", cmb2.SelectedValue);
            query.Parameters.AddWithValue("@razred", cmb3.SelectedValue);
            query.Parameters.AddWithValue("family", cmb4.SelectedValue);
            query.Parameters.AddWithValue("rod", cmb5.SelectedValue);
            query.Parameters.AddWithValue("@vid", cmb6.SelectedValue);
            query.Parameters.AddWithValue("@img", txt5.Text);
            query.Parameters.AddWithValue("@info", txt4.Text);
            query.Parameters.AddWithValue("@dateReg", DateAndTime.Now);

            query.ExecuteNonQuery();
            MessageBox.Show("Input OK");

            connect.Close();
        }
    }
}
