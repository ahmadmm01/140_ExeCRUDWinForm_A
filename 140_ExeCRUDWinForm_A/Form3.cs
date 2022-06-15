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
    public partial class Form_Reminders : Form
    {
        public Form_Reminders()
        {
            InitializeComponent();
        }

        private void remindersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.remindersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.todoDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoDataSet1.Reminders' table. You can move, or remove it, as needed.
            this.remindersTableAdapter.Fill(this.todoDataSet1.Reminders);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_Menu().Show();
            this.Close();
        }
    }
}
