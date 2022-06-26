namespace FormUI
{
    partial class Dashboard
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.InsertRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 15;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(28, 84);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(586, 244);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(116, 27);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(319, 23);
            this.NameText.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(28, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(473, 31);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(116, 349);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(319, 23);
            this.FirstNameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(116, 393);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(319, 23);
            this.LastNameText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address";
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.Location = new System.Drawing.Point(116, 434);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(319, 23);
            this.EmailAddressText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(116, 476);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(319, 23);
            this.PhoneNumberText.TabIndex = 10;
            // 
            // InsertRecord
            // 
            this.InsertRecord.Location = new System.Drawing.Point(143, 530);
            this.InsertRecord.Name = "InsertRecord";
            this.InsertRecord.Size = new System.Drawing.Size(189, 23);
            this.InsertRecord.TabIndex = 12;
            this.InsertRecord.Text = "Insert";
            this.InsertRecord.UseVisualStyleBackColor = true;
            this.InsertRecord.Click += new System.EventHandler(this.InsertRecord_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 600);
            this.Controls.Add(this.InsertRecord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailAddressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Name = "Dashboard";
            this.Text = "SQL Access (Dapper)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PeopleFoundListBox;
        private TextBox NameText;
        private Label NameLabel;
        private Button SearchButton;
        private Label label1;
        private TextBox FirstNameText;
        private Label label2;
        private TextBox LastNameText;
        private Label label3;
        private TextBox EmailAddressText;
        private Label label4;
        private TextBox PhoneNumberText;
        private Button InsertRecord;
    }
}