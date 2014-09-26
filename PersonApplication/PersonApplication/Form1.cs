using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApplication
{
    public partial class PersonAppsForm : Form
    {
        public PersonAppsForm()
        {
            InitializeComponent();
        }
        Persons p = new Persons();
        private void fullButton_Click(object sender, EventArgs e)
        {
            p.fName = firstTextBox.Text;
            p.mName = middleTextBox.Text;
            p.lName = lastTextBox.Text;

            fullTextBox.Text = p.getFullName();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            reverseTextBox.Text = p.getReverseName();
        }
    }
}
