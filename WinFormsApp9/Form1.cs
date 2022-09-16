using System.Data.SqlClient;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        class Author
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public override string ToString()
            {
                return $"{Id}. {Name} {Surname}";
            }
        }

        SqlConnection sqlConnection = new SqlConnection(connectionString);

        SqlDataReader reader = null;
        List<Author> authors = new List<Author>();

        public Form1()
        {
            InitializeComponent();         
        }

        static string connectionString = "Data Source=DESKTOP-DAG0R02; " +
                         "Initial Catalog=Library;" +
                         "User ID=admin; Password=admin";



        private void btn_add_Click(object sender, EventArgs e)
        {

            foreach (Author author in authors)
            {
                listView1.Items.Add(author.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Authors", sqlConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    authors.Add(new Author
                    {
                        Id = (int)(reader[0]),
                        Name = reader[1].ToString(),
                        Surname = reader[2].ToString()
                    });
                }
            }
            finally
            {
                if (reader != null) { reader.Close(); }
                if (sqlConnection != null) { sqlConnection.Close(); }
            }
        }
    }
}