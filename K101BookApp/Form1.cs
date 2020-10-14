using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using K101BookApp.Models;

namespace K101BookApp
{
    public partial class Form1 : Form
    {
        BOOKDBEntities db = new BOOKDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text;
            decimal count = nmCount.Value;
            DateTime pbDate = dtgPublish.Value;
            string authName = cmbAuthors.Text;
            if (bookName != string.Empty && authName!=string.Empty)
            {
                lblError.Visible = false;
                int authId=db.Authors.First(x=>x.Name==authName).ID;
                Book bk = new Book();
                bk.Name = bookName;
                bk.Amount = (int)count;
                bk.PublishDate = pbDate;
                bk.AuthorId = authId;
                db.Books.Add(bk);
                db.SaveChanges();
                MessageBox.Show("Book added successfully");
                BookFillData();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Book name Fiel!";
            }
          
        }
        public void BookFillData()
        {
            dtgBookList.DataSource = db.Books.Select(x => new {
                BookName = x.Name,
                x.PublishDate,
                x.Amount,
                AuthorName = x.Author.Name
            }).OrderBy(x => x.BookName).ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            cmbAuthors.Items.AddRange(db.Authors.Select(x => x.Name).ToArray());
            BookFillData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookListForm bkList = new BookListForm();
            bkList.ShowDialog();
        }
    }
}


//using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conLib))
//{
//    con.Open();
//    string comAuthCom = $"Select ID From Authors Where Name='{authName}'";
//    SqlCommand authcom = new SqlCommand(comAuthCom, con);
//    var autres = authcom.ExecuteReader();
//    while (autres.Read())
//    {
//        authId = Convert.ToInt32(autres["ID"]);
//    }
//}
//using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conLib))
//{
//    con.Open();
//    string comString = string.Format($"Insert into Books Values('{bookName}','{pbDate}',{authId},{count},NULL)");
//    SqlCommand com = new SqlCommand(comString, con);
//    int res = com.ExecuteNonQuery();
//    if (res >= 1)
//    {
//        MessageBox.Show("Book Added Successfully");
//        txtBookName.Text = "";
//        nmCount.Value = 1;
//        dtgPublish.Value = DateTime.Now;
//    }
//}
