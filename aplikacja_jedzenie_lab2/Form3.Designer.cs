namespace aplikacja_jedzenie_lab2
{
    partial class Form3
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Pizza margharita", "30" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Pizza pepperoni", "35" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Pizza capriciosa", "40" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Pizza salami pikantne", "35" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Spaghetti z krewetkami", "45" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Spaghetti bolognese", "40" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewItem1.Tag = "";
            listViewItem3.Tag = "";
            listViewItem4.Tag = "";
            listViewItem5.Tag = "";
            listViewItem6.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(273, 177);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "";
            columnHeader1.Text = "Nazwa Produktu";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cena";
            columnHeader2.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(12, 195);
            button1.Name = "button1";
            button1.Size = new Size(124, 66);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 195);
            button2.Name = "button2";
            button2.Size = new Size(143, 66);
            button2.TabIndex = 2;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 273);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}