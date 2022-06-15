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
    public partial class Form_Todo : Form
    {
        public Form_Todo()
        {
            InitializeComponent();
        }

        private void users_RemindersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.users_RemindersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.todoDataSet2);

        }

        private void users_RemindersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.users_RemindersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.todoDataSet2);

        }

        private void Form_Todo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoDataSet2.Users_Reminders' table. You can move, or remove it, as needed.
            this.users_RemindersTableAdapter.Fill(this.todoDataSet2.Users_Reminders);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_Menu().Show();
            this.Close();
        }
    }
}
