
namespace HF1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label lastContactLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactsDataSet = new HF1.ContactsDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new HF1.ContactsDataSetTableAdapters.PeopleTableAdapter();
            this.tableAdapterManager = new HF1.ContactsDataSetTableAdapters.TableAdapterManager();
            this.peopleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.clientCheckBox = new System.Windows.Forms.CheckBox();
            this.lastContactDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            lastContactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).BeginInit();
            this.peopleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HF1.Properties.Resources.Genesis;
            this.pictureBox1.Location = new System.Drawing.Point(252, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactsDataSet
            // 
            this.contactsDataSet.DataSetName = "ContactsDataSet";
            this.contactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.contactsDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = this.peopleTableAdapter;
            this.tableAdapterManager.UpdateOrder = HF1.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleBindingNavigator
            // 
            this.peopleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peopleBindingNavigator.BindingSource = this.peopleBindingSource;
            this.peopleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peopleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.peopleBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.peopleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.peopleBindingNavigatorSaveItem});
            this.peopleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peopleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peopleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peopleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peopleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peopleBindingNavigator.Name = "peopleBindingNavigator";
            this.peopleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peopleBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.peopleBindingNavigator.TabIndex = 1;
            this.peopleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 25);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // peopleBindingNavigatorSaveItem
            // 
            this.peopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peopleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleBindingNavigatorSaveItem.Image")));
            this.peopleBindingNavigatorSaveItem.Name = "peopleBindingNavigatorSaveItem";
            this.peopleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.peopleBindingNavigatorSaveItem.Text = "Save Data";
            this.peopleBindingNavigatorSaveItem.Click += new System.EventHandler(this.peopleBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(118, 272);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 18);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(252, 269);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(313, 28);
            this.idTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(118, 318);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 18);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(252, 315);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(313, 28);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(118, 364);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(92, 18);
            companyLabel.TabIndex = 6;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(252, 361);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(313, 28);
            this.companyTextBox.TabIndex = 7;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(118, 410);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(98, 18);
            telephoneLabel.TabIndex = 8;
            telephoneLabel.Text = "Telephone:";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(252, 407);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(313, 28);
            this.telephoneTextBox.TabIndex = 9;
            this.telephoneTextBox.TextChanged += new System.EventHandler(this.telephoneTextBox_TextChanged);
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(123, 456);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(56, 18);
            eMailLabel.TabIndex = 10;
            eMailLabel.Text = "EMail:";
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "EMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(252, 453);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(313, 28);
            this.eMailTextBox.TabIndex = 11;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(123, 498);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(57, 18);
            clientLabel.TabIndex = 12;
            clientLabel.Text = "Client:";
            // 
            // clientCheckBox
            // 
            this.clientCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.peopleBindingSource, "Client", true));
            this.clientCheckBox.Location = new System.Drawing.Point(252, 499);
            this.clientCheckBox.Name = "clientCheckBox";
            this.clientCheckBox.Size = new System.Drawing.Size(104, 24);
            this.clientCheckBox.TabIndex = 13;
            this.clientCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastContactLabel
            // 
            lastContactLabel.AutoSize = true;
            lastContactLabel.Location = new System.Drawing.Point(118, 544);
            lastContactLabel.Name = "lastContactLabel";
            lastContactLabel.Size = new System.Drawing.Size(117, 18);
            lastContactLabel.TabIndex = 14;
            lastContactLabel.Text = "Last Contact:";
            // 
            // lastContactDateTimePicker
            // 
            this.lastContactDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peopleBindingSource, "LastContact", true));
            this.lastContactDateTimePicker.Location = new System.Drawing.Point(252, 541);
            this.lastContactDateTimePicker.Name = "lastContactDateTimePicker";
            this.lastContactDateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.lastContactDateTimePicker.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(lastContactLabel);
            this.Controls.Add(this.lastContactDateTimePicker);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.clientCheckBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.peopleBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).EndInit();
            this.peopleBindingNavigator.ResumeLayout(false);
            this.peopleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private ContactsDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private ContactsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peopleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton peopleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.CheckBox clientCheckBox;
        private System.Windows.Forms.DateTimePicker lastContactDateTimePicker;
    }
}

