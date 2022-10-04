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
using BookBizManagementSystem.Validation;

namespace BookBizManagementSystem
{
    public partial class AddBookForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NQF55SP;Initial Catalog=bookBizDB;Integrated Security=True");

        public AddBookForm()
        {
            InitializeComponent();

            //Hide what is not used yet
            label9.Visible = false;
            comboBoxListAuthors.Visible = false;
            buttonAddAuthorBook.Visible = false;
            label1.Visible = false;
            label10.Visible = false;
            buttonAddNewAuthor.Visible = false;

            labelFN.Visible = false;
            textBoxFirstNameAuthor.Visible = false;
            labelLN.Visible = false;
            textBoxLastNameAuthor.Visible = false;
            labelEmail.Visible = false;
            textBoxEmailAuthor.Visible = false;
            buttonAddAuthorExtra.Visible = false;
            buttonResetAuthor.Visible = false;
        }


        //Adding a book, reeset button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            maskedTextBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxUnitPrice.Clear();
            textBoxQuantity.Clear();
            textBoxPublisher.Clear();
            textBoxCategory.Clear();
            textBoxPublishedYear.Clear();
        }

        //Load with the form
        private void AddBookForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(firstName,',',lastName) as 'Full Name' FROM author", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Full Name", typeof(string));
            dt.Load(rdr);
            comboBoxListAuthors.ValueMember = "Full Name";
            comboBoxListAuthors.DisplayMember = "Full Name";
            comboBoxListAuthors.DataSource = dt;
            con.Close();
        }


        //Add author to a book, button
        private void buttonAddAuthorBook_Click(object sender, EventArgs e)
        {
            if (comboBoxListAuthors.GetItemText(comboBoxListAuthors.SelectedItem).Length == 0)
            { 
                MessageBox.Show("Please select an author", "Select an author", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                String selected = comboBoxListAuthors.GetItemText(comboBoxListAuthors.SelectedItem);
                
                string[] fln = selected.Split(',');
                string fn = fln[0];
                string ln = fln[1];
                
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT authorID FROM author WHERE (firstName = '" + fn + "') AND (lastName = '" + ln + "')";
                int authorId = (int)(cmd1.ExecuteScalar());
                con.Close();

                con.Open();
                cmd1.CommandText = "INSERT INTO writtenBy (authorID,ISBN) VALUES ('" + authorId + "','" + maskedTextBoxISBN.Text + "') ";
                int affectedrow1 = cmd1.ExecuteNonQuery();
                if (affectedrow1 > 0) 
                { 
                    MessageBox.Show("Author has been added successfully to the Book", "Added Author to Book ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                con.Close();
            }
        }


        //Adding a book, button
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            //Validation
            float untPrice;
            if (maskedTextBoxISBN.Text.Length != 17) 
            { 
                MessageBox.Show("ISBN is invalid. Please enter a valid ISBN (ISBN is 10 digits)", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxISBN.Focus(); 
            }
            else if (!Validator.AlphaNuMwzSpaceIsValid(textBoxTitle,2,50)) 
            { 
                MessageBox.Show("Book Title is invalid. Please enter a valid Book Title (Min. 2 alphanumerical characters)", "Invalid Book Title", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxTitle.Focus(); 
            }
            else if (textBoxUnitPrice.Text.IndexOf(',') > 0 || !float.TryParse(textBoxUnitPrice.Text, out untPrice)) 
            { 
                MessageBox.Show("Unit price is invalid. Please enter a valid Unit price (Min. 1 digit (float))", "Invalid Unit Price", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxUnitPrice.Focus(); 
            }
            else if (!Validator.NumIsValid(textBoxPublishedYear,4,4) || Convert.ToInt16(textBoxPublishedYear.Text) < 1600 || Convert.ToInt16(textBoxPublishedYear.Text) > 2022) 
            { 
                MessageBox.Show("Year Published is invalid. Please enter a valid Year Published (Must have 4 digits, from 1600 to 2022)", "Invalid Year Published", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxPublishedYear.Focus(); 
            }
            else if (!Validator.AlphaNuMwzSpaceIsValid(textBoxCategory,2,50)) 
            { 
                MessageBox.Show("Category is invalid. Please enter a valid Category  (Min. 2 alphanumerical characters)", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCategory.Focus(); 
            }
            else if (!Validator.NumIsValid(textBoxQuantity,1,5)) 
            { 
                MessageBox.Show("Quantity is invalid. Please enter a valid Quantity (Quantity must have at least 1 digit)", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxQuantity.Focus(); 
            }            
            else if (!Validator.AlphaNuMwzSpaceIsValid(textBoxPublisher,2,50)) 
            { 
                MessageBox.Show("Publisher Name is invalid. Please enter a valid Publisher Name  (Min. 2 alphanumerical characters)", "Invalid Publisher Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxPublisher.Focus(); 
            }
            else
            {
                con.Open();
                float priceUnit = (float)Convert.ToDecimal(textBoxUnitPrice.Text.Trim());
                int publishedYear = Convert.ToInt32(textBoxPublishedYear.Text.Trim());
                int quantit = Convert.ToInt16(textBoxQuantity.Text.Trim());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO book (ISBN,bookTitle,unitPrice,yearPublished,quantityOnHand,publisherName,category) VALUES ('" + maskedTextBoxISBN.Text + "','" + textBoxTitle.Text + "','" + priceUnit + "','" + publishedYear + "','" + quantit + "','" + textBoxPublisher.Text + "','" + textBoxCategory.Text + "')";
                int flag = (int)cmd.ExecuteNonQuery();
                if (flag > 0) { MessageBox.Show("The Book has been added successfully", "Added Book", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                con.Close();
                //Add author part appears
                label9.Visible = true;
                comboBoxListAuthors.Visible = true;
                buttonAddAuthorBook.Visible = true;
                label1.Visible = true;
                label10.Visible = true;
                buttonAddNewAuthor.Visible = true;
            }
        }


        //Adding a new author to the DB
        private void buttonAddNewAuthor_Click(object sender, EventArgs e)
        {
            //Make the section needed to add a new author visible
            labelFN.Visible = true;
            textBoxFirstNameAuthor.Visible = true;
            labelLN.Visible = true;
            textBoxLastNameAuthor.Visible = true;
            labelEmail.Visible = true;
            textBoxEmailAuthor.Visible = true;
            buttonAddAuthorExtra.Visible = true;
            buttonResetAuthor.Visible = true;
        }

        //Add new author reset button
        private void buttonResetAuthor_Click(object sender, EventArgs e)
        {
            textBoxFirstNameAuthor.Clear();
            textBoxLastNameAuthor.Clear();
            textBoxEmailAuthor.Clear();
            textBoxFirstNameAuthor.Focus();
        }

        //Add a new author to the DB
        private void buttonAddAuthorExtra_Click(object sender, EventArgs e)
        {
            //Validation
            if (!Validator.AlphapetIsValid(textBoxFirstNameAuthor,2,50)) 
            { 
                MessageBox.Show("First Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstNameAuthor.Focus(); 
            }
            else if (!Validator.AlphapetIsValid(textBoxLastNameAuthor, 2, 50)) 
            { 
                MessageBox.Show("Last Name is invalid. Please enter a valid name (No numbers & Min. 2 letters)", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastNameAuthor.Focus(); 
            }
            else if (textBoxEmailAuthor.Text.Length == 0 || !Validator.EmailIsValid2(textBoxEmailAuthor.Text)) 
            { 
                MessageBox.Show("Email is invalid. Please enter a valid email (eg. xx@xx.xx)", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxEmailAuthor.Focus(); 
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO author (email,firstName,lastName) VALUES ('" + textBoxEmailAuthor.Text.Trim() + "','" + textBoxFirstNameAuthor.Text + "','" + textBoxLastNameAuthor.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Author has been added successfully to DB", "Added Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelFN.Visible = false;
                textBoxFirstNameAuthor.Visible = false;
                labelLN.Visible = false;
                textBoxLastNameAuthor.Visible = false;
                labelEmail.Visible = false;
                textBoxEmailAuthor.Visible = false;
                buttonAddAuthorExtra.Visible = false;
                buttonResetAuthor.Visible = false;
                AddBookForm_Load(sender, e);
            }
        }


        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
