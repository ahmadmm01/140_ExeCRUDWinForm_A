using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140_ExeCRUDWinForm_A
{
    public partial class Form_Users : Form
    {
        public Form_Users()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();

        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.todoDataSet.Users);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
