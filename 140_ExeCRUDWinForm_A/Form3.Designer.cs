namespace _140_ExeCRUDWinForm_A
{
    partial class Form_Reminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reminders));
            System.Windows.Forms.Label reminders_IdLabel;
            System.Windows.Forms.Label reminders_NameLabel;
            System.Windows.Forms.Label reminders_descriptionLabel;
            this.todoDataSet1 = new _140_ExeCRUDWinForm_A.TodoDataSet1();
            this.remindersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remindersTableAdapter = new _140_ExeCRUDWinForm_A.TodoDataSet1TableAdapters.RemindersTableAdapter();
            this.tableAdapterManager = new _140_ExeCRUDWinForm_A.TodoDataSet1TableAdapters.TableAdapterManager();
            this.remindersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.remindersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reminders_IdTextBox = new System.Windows.Forms.TextBox();
            this.reminders_NameTextBox = new System.Windows.Forms.TextBox();
            this.reminders_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            reminders_IdLabel = new System.Windows.Forms.Label();
            reminders_NameLabel = new System.Windows.Forms.Label();
            reminders_descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remindersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remindersBindingNavigator)).BeginInit();
            this.remindersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoDataSet1
            // 
            this.todoDataSet1.DataSetName = "TodoDataSet1";
            this.todoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remindersBindingSource
            // 
            this.remindersBindingSource.DataMember = "Reminders";
            this.remindersBindingSource.DataSource = this.todoDataSet1;
            // 
            // remindersTableAdapter
            // 
            this.remindersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RemindersTableAdapter = this.remindersTableAdapter;
            this.tableAdapterManager.UpdateOrder = _140_ExeCRUDWinForm_A.TodoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // remindersBindingNavigator
            // 
            this.remindersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.remindersBindingNavigator.BindingSource = this.remindersBindingSource;
            this.remindersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.remindersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.remindersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.remindersBindingNavigatorSaveItem});
            this.remindersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.remindersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.remindersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.remindersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.remindersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.remindersBindingNavigator.Name = "remindersBindingNavigator";
            this.remindersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.remindersBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.remindersBindingNavigator.TabIndex = 0;
            this.remindersBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // remindersBindingNavigatorSaveItem
            // 
            this.remindersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.remindersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("remindersBindingNavigatorSaveItem.Image")));
            this.remindersBindingNavigatorSaveItem.Name = "remindersBindingNavigatorSaveItem";
            this.remindersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.remindersBindingNavigatorSaveItem.Text = "Save Data";
            this.remindersBindingNavigatorSaveItem.Click += new System.EventHandler(this.remindersBindingNavigatorSaveItem_Click);
            // 
            // reminders_IdLabel
            // 
            reminders_IdLabel.AutoSize = true;
            reminders_IdLabel.Location = new System.Drawing.Point(12, 69);
            reminders_IdLabel.Name = "reminders_IdLabel";
            reminders_IdLabel.Size = new System.Drawing.Size(72, 13);
            reminders_IdLabel.TabIndex = 1;
            reminders_IdLabel.Text = "Reminders Id:";
            // 
            // reminders_IdTextBox
            // 
            this.reminders_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindersBindingSource, "Reminders_Id", true));
            this.reminders_IdTextBox.Location = new System.Drawing.Point(132, 66);
            this.reminders_IdTextBox.Name = "reminders_IdTextBox";
            this.reminders_IdTextBox.Size = new System.Drawing.Size(348, 20);
            this.reminders_IdTextBox.TabIndex = 2;
            // 
            // reminders_NameLabel
            // 
            reminders_NameLabel.AutoSize = true;
            reminders_NameLabel.Location = new System.Drawing.Point(12, 95);
            reminders_NameLabel.Name = "reminders_NameLabel";
            reminders_NameLabel.Size = new System.Drawing.Size(91, 13);
            reminders_NameLabel.TabIndex = 3;
            reminders_NameLabel.Text = "Reminders Name:";
            // 
            // reminders_NameTextBox
            // 
            this.reminders_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindersBindingSource, "Reminders_Name", true));
            this.reminders_NameTextBox.Location = new System.Drawing.Point(132, 92);
            this.reminders_NameTextBox.Name = "reminders_NameTextBox";
            this.reminders_NameTextBox.Size = new System.Drawing.Size(348, 20);
            this.reminders_NameTextBox.TabIndex = 4;
            // 
            // reminders_descriptionLabel
            // 
            reminders_descriptionLabel.AutoSize = true;
            reminders_descriptionLabel.Location = new System.Drawing.Point(12, 121);
            reminders_descriptionLabel.Name = "reminders_descriptionLabel";
            reminders_descriptionLabel.Size = new System.Drawing.Size(114, 13);
            reminders_descriptionLabel.TabIndex = 5;
            reminders_descriptionLabel.Text = "Reminders description:";
            // 
            // reminders_descriptionTextBox
            // 
            this.reminders_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindersBindingSource, "Reminders_description", true));
            this.reminders_descriptionTextBox.Location = new System.Drawing.Point(132, 118);
            this.reminders_descriptionTextBox.Name = "reminders_descriptionTextBox";
            this.reminders_descriptionTextBox.Size = new System.Drawing.Size(348, 20);
            this.reminders_descriptionTextBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 204);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(reminders_IdLabel);
            this.Controls.Add(this.reminders_IdTextBox);
            this.Controls.Add(reminders_NameLabel);
            this.Controls.Add(this.reminders_NameTextBox);
            this.Controls.Add(reminders_descriptionLabel);
            this.Controls.Add(this.reminders_descriptionTextBox);
            this.Controls.Add(this.remindersBindingNavigator);
            this.Name = "Form_Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remindersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remindersBindingNavigator)).EndInit();
            this.remindersBindingNavigator.ResumeLayout(false);
            this.remindersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TodoDataSet1 todoDataSet1;
        private System.Windows.Forms.BindingSource remindersBindingSource;
        private TodoDataSet1TableAdapters.RemindersTableAdapter remindersTableAdapter;
        private TodoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator remindersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton remindersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reminders_IdTextBox;
        private System.Windows.Forms.TextBox reminders_NameTextBox;
        private System.Windows.Forms.TextBox reminders_descriptionTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}