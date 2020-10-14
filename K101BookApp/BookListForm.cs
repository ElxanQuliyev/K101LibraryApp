using K101BookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K101BookApp
{
    public partial class BookListForm : Form
    {
        BOOKDBEntities db = new BOOKDBEntities();

        public BookListForm()
        {
            InitializeComponent();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {

            //using (SqlConnection con =new SqlConnection(Properties.Settings.Default.conLib))
            //{
            //    con.Open();
            //    string conQuery = "select bs.Name[Book Name],bs.Amount,ath.Name[Author Name],bs.PublishDate from Books bs " +
            //        "Join Authors ath " +
            //        "on ath.ID=bs.AuthorId";
            //    SqlDataAdapter da = new SqlDataAdapter(conQuery, con);
            //    DataSet dt = new DataSet();
            //    da.Fill(dt);
            //    dtgBookList.DataSource = dt.Tables[0];
            //}

        }
    }
}
