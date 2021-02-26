using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0.\nWritten by : Jeonjh", "About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactsDataSet.People);

        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDataSet);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
