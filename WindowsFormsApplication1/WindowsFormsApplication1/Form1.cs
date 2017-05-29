using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userInput.Text;
            string password = passInput.Text;
            Console.Out.Write("user name is:" + username);
            ValidateStringInput validater = new ValidateStringInput();
            if (validater.validateStringInput(username) || validater.validateStringInput(password))
            {
                Console.Out.Write("String input is valid");
                server serverTo = new server();
                //serverTo.connectServer(username,password);
                Hide();
                (new accountLoginHome()).Show();

                
            }
            else
            {
                userInput.Text = "";
                passInput.Text = "";
                errorLabel.Text = "Sorry your username is or password violates the rules";
                return;
            }
             
        }
    }
}
