namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            contactBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            discordDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(ClassLibrary.Contact);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // discordDataGridViewTextBoxColumn
            // 
            discordDataGridViewTextBoxColumn.DataPropertyName = "Discord";
            discordDataGridViewTextBoxColumn.HeaderText = "Discord";
            discordDataGridViewTextBoxColumn.Name = "discordDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, lastNameDataGridViewTextBoxColumn1, phoneNumberDataGridViewTextBoxColumn1, emailDataGridViewTextBoxColumn1, discordDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = contactBindingSource;
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(758, 150);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // discordDataGridViewTextBoxColumn1
            // 
            discordDataGridViewTextBoxColumn1.DataPropertyName = "Discord";
            discordDataGridViewTextBoxColumn1.HeaderText = "Discord";
            discordDataGridViewTextBoxColumn1.Name = "discordDataGridViewTextBoxColumn1";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToToolStripMenuItem
            // 
            saveToToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLToolStripMenuItem });
            saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            saveToToolStripMenuItem.Size = new Size(112, 22);
            saveToToolStripMenuItem.Text = "Save to";
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(98, 22);
            xMLToolStripMenuItem.Text = "XML";
            xMLToolStripMenuItem.Click += xMLToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLToolStripMenuItem1 });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(112, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // xMLToolStripMenuItem1
            // 
            xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            xMLToolStripMenuItem1.Size = new Size(98, 22);
            xMLToolStripMenuItem1.Text = "XML";
            xMLToolStripMenuItem1.Click += xMLToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discordDataGridViewTextBoxColumn;
        private BindingSource contactBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn discordDataGridViewTextBoxColumn1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}