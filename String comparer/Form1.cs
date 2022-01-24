using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_comparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxStringX_TextChanged(object sender, EventArgs e)
        {
            ValidationResult checker = new ValidationResult();
            if(checker.ValidateUserInput(tbxStringX.Text))
            {
                lblResult.Text = "String X is valid" + checker.Message;
            } else
            {
                lblResult.Text = "String X is invalid " + checker.Message;
            }
        }
    }
}
