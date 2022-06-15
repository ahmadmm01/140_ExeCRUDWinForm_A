namespace _140_ExeCRUDWinForm_A
{
    partial class Form_Todo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Todo));
            System.Windows.Forms.Label uR_IdLabel;
            System.Windows.Forms.Label uR_dateLabel;
            System.Windows.Forms.Label users_IdLabel;
            System.Windows.Forms.Label reminders_IdLabel;
            this.todoDataSet2 = new _140_ExeCRUDWinForm_A.TodoDataSet2();
            this.users_RemindersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_RemindersTableAdapter = new _140_ExeCRUDWinForm_A.TodoDataSet2TableAdapters.Users_RemindersTableAdapter();
            this.tableAdapterManager = new _140_ExeCRUDWinForm_A.TodoDataSet2TableAdapters.TableAdapterManager();
            this.users_RemindersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.users_RemindersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uR_IdTextBox = new System.Windows.Forms.TextBox();
            this.uR_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.users_IdTextBox = new System.Windows.Forms.TextBox();
            this.reminders_IdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            uR_IdLabel = new System.Windows.Forms.Label();
            uR_dateLabel = new System.Windows.Forms.Label();
            users_IdLabel = new System.Windows.Forms.Label();
            reminders_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_RemindersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_RemindersBindingNavigator)).BeginInit();
            this.users_RemindersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoDataSet2
            // 
            this.todoDataSet2.DataSetName = "TodoDataSet2";
            this.todoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users_RemindersBindingSource
            // 
            this.users_RemindersBindingSource.DataMember = "Users_Reminders";
            this.users_RemindersBindingSource.DataSource = this.todoDataSet2;
            // 
            // users_RemindersTableAdapter
            // 
            this.users_RemindersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _140_ExeCRUDWinForm_A.TodoDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_RemindersTableAdapter = this.users_RemindersTableAdapter;
            // 
            // users_RemindersBindingNavigator
            // 
            this.users_RemindersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.users_RemindersBindingNavigator.BindingSource = this.users_RemindersBindingSource;
            this.users_RemindersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.users_RemindersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.users_RemindersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.users_RemindersBindingNavigatorSaveItem});
            this.users_RemindersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.users_RemindersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.users_RemindersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.users_RemindersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.users_RemindersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.users_RemindersBindingNavigator.Name = "users_RemindersBindingNavigator";
            this.users_RemindersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.users_RemindersBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.users_RemindersBindingNavigator.TabIndex = 0;
            this.users_RemindersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // users_RemindersBindingNavigatorSaveItem
            // 
            this.users_RemindersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.users_RemindersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("users_RemindersBindingNavigatorSaveItem.Image")));
            this.users_RemindersBindingNavigatorSaveItem.Name = "users_RemindersBindingNavigatorSaveItem";
            this.users_RemindersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.users_RemindersBindingNavigatorSaveItem.Text = "Save Data";
            this.users_RemindersBindingNavigatorSaveItem.Click += new System.EventHandler(this.users_RemindersBindingNavigatorSaveItem_Click_1);
            // 
            // uR_IdLabel
            // 
            uR_IdLabel.AutoSize = true;
            uR_IdLabel.Location = new System.Drawing.Point(12, 37);
            uR_IdLabel.Name = "uR_IdLabel";
            uR_IdLabel.Size = new System.Drawing.Size(38, 13);
            uR_IdLabel.TabIndex = 1;
            uR_IdLabel.Text = "UR Id:";
            // 
            // uR_IdTextBox
            // 
            this.uR_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_RemindersBindingSource, "UR_Id", true));
            this.uR_IdTextBox.Location = new System.Drawing.Point(90, 34);
            this.uR_IdTextBox.Name = "uR_IdTextBox";
            this.uR_IdTextBox.Size = new System.Drawing.Size(392, 20);
            this.uR_IdTextBox.TabIndex = 2;
            // 
            // uR_dateLabel
            // 
            uR_dateLabel.AutoSize = true;
            uR_dateLabel.Location = new System.Drawing.Point(12, 64);
            uR_dateLabel.Name = "uR_dateLabel";
            uR_dateLabel.Size = new System.Drawing.Size(50, 13);
            uR_dateLabel.TabIndex = 3;
            uR_dateLabel.Text = "UR date:";
            // 
            // uR_dateDateTimePicker
            // 
            this.uR_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.users_RemindersBindingSource, "UR_date", true));
            this.uR_dateDateTimePicker.Location = new System.Drawing.Point(90, 60);
            this.uR_dateDateTimePicker.Name = "uR_dateDateTimePicker";
            this.uR_dateDateTimePicker.Size = new System.Drawing.Size(392, 20);
            this.uR_dateDateTimePicker.TabIndex = 4;
            // 
            // users_IdLabel
            // 
            users_IdLabel.AutoSize = true;
            users_IdLabel.Location = new System.Drawing.Point(12, 89);
            users_IdLabel.Name = "users_IdLabel";
            users_IdLabel.Size = new System.Drawing.Size(49, 13);
            users_IdLabel.TabIndex = 5;
            users_IdLabel.Text = "Users Id:";
            // 
            // users_IdTextBox
            // 
            this.users_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_RemindersBindingSource, "Users_Id", true));
            this.users_IdTextBox.Location = new System.Drawing.Point(90, 86);
            this.users_IdTextBox.Name = "users_IdTextBox";
            this.users_IdTextBox.Size = new System.Drawing.Size(392, 20);
            this.users_IdTextBox.TabIndex = 6;
            // 
            // reminders_IdLabel
            // 
            reminders_IdLabel.AutoSize = true;
            reminders_IdLabel.Location = new System.Drawing.Point(12, 115);
            reminders_IdLabel.Name = "reminders_IdLabel";
            reminders_IdLabel.Size = new System.Drawing.Size(72, 13);
            reminders_IdLabel.TabIndex = 7;
            reminders_IdLabel.Text = "Reminders Id:";
            // 
            // reminders_IdTextBox
            // 
            this.reminders_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.users_RemindersBindingSource, "Reminders_Id", true));
            this.reminders_IdTextBox.Location = new System.Drawing.Point(90, 112);
            this.reminders_IdTextBox.Name = "reminders_IdTextBox";
            this.reminders_IdTextBox.Size = new System.Drawing.Size(392, 20);
            this.reminders_IdTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 182);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(uR_IdLabel);
            this.Controls.Add(this.uR_IdTextBox);
            this.Controls.Add(uR_dateLabel);
            this.Controls.Add(this.uR_dateDateTimePicker);
            this.Controls.Add(users_IdLabel);
            this.Controls.Add(this.users_IdTextBox);
            this.Controls.Add(reminders_IdLabel);
            this.Controls.Add(this.reminders_IdTextBox);
            this.Controls.Add(this.users_RemindersBindingNavigator);
            this.Name = "Form_Todo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.Form_Todo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_RemindersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_RemindersBindingNavigator)).EndInit();
            this.users_RemindersBindingNavigator.ResumeLayout(false);
            this.users_RemindersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TodoDataSet2 todoDataSet2;
        private System.Windows.Forms.BindingSource users_RemindersBindingSource;
        private TodoDataSet2TableAdapters.Users_RemindersTableAdapter users_RemindersTableAdapter;
        private TodoDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator users_RemindersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton users_RemindersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox uR_IdTextBox;
        private System.Windows.Forms.DateTimePicker uR_dateDateTimePicker;
        private System.Windows.Forms.TextBox users_IdTextBox;
        private System.Windows.Forms.TextBox reminders_IdTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}