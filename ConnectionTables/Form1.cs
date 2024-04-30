using MySql.Data.MySqlClient;

namespace ConnectionTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "server=10.6.0.127;" +
            "port=3306;" +
            "user=PC1;" +
            "password=1111;"+
        "database=trees_zaimov";

       

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect=new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection new opened!");
            string insertSQL="INSERT INTO trees_zaimov.rod"+
                "(`name`, `name_bg`)"+
                "Values(@name,@name_bg)";
            MySqlCommand query =new MySqlCommand(insertSQL, connect);
            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("@name", txt2.Text);
            query.ExecuteNonQuery();
            MessageBox.Show("Dobavih");
            connect.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
