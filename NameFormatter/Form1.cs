using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameFormatter
{
    public partial class nameDeclare : Form
    {
        public nameDeclare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the program on user input
            Close();
        }

        private void changeFormatButton_Click(object sender, EventArgs e)
        {
         
                    

        }

        private void preferredTitle_Click(object sender, EventArgs e)
        {

        }

        private void fullNameButton_Click(object sender, EventArgs e)
        {
            // Declaring variables from the text input by the user
            string title = titleTextbox.Text,
                   firstName = firstNameTextbox.Text,
                   middleName = middleNameTextbox.Text,
                   lastName = lastNameTextbox.Text;

            // Displays the full name with the title
            nameOutput.Text = title + " " + firstName + " " + middleName + " " + lastName;
        }

        private void noTitleFullName_Click(object sender, EventArgs e)
        {
            // Declaring variables from the text input by the user
            string firstName = firstNameTextbox.Text,
                   middleName = middleNameTextbox.Text,
                   lastName = lastNameTextbox.Text;

            // Displays the full name without the user's title
            nameOutput.Text = firstName + " " + middleName + " " + lastName;
        }

        private void firstLast_Click(object sender, EventArgs e)
        {
            // Declaring variables from the text input by the user
            string firstName = firstNameTextbox.Text,
                   lastName = lastNameTextbox.Text;

            // Displays only the first and last name of the user
            nameOutput.Text = firstName + " " + lastName;

        }

        private void lastFirstMiddleTitle_Click(object sender, EventArgs e)
        {
            // Declaring variables from the text input by the user
            string title = titleTextbox.Text,
                   firstName = firstNameTextbox.Text,
                   middleName = middleNameTextbox.Text,
                   lastName = lastNameTextbox.Text;

            // Displays last name, first name middle name, and then title
            nameOutput.Text = lastName + ", " + firstName + " " + middleName + ", " + title;
        }

        private void lastFirstMiddle_Click(object sender, EventArgs e)
        {
            // Declaring variables from the text input by the user
            string firstName = firstNameTextbox.Text,
                   middleName = middleNameTextbox.Text,
                   lastName = lastNameTextbox.Text;

            // Displays last name, first name and then middle name
            nameOutput.Text = lastName + ", " + firstName + " " + middleName;

        }

        private void lastNameFirst_Click(object sender, EventArgs e)
        {
            // Declaring variables from the text input by the user
            string firstName = firstNameTextbox.Text,
                   lastName = lastNameTextbox.Text;

            // Displays last name, first name
            nameOutput.Text = lastName + ", " + firstName;

        }
    }
}
