using System;

namespace NameFormatter
{
    partial class nameDeclare
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
            this.exitButton = new System.Windows.Forms.Button();
            this.middleNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.preferredTitle = new System.Windows.Forms.Label();
            this.nameOutputTitle = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.fullNameButton = new System.Windows.Forms.Button();
            this.noTitleFullName = new System.Windows.Forms.Button();
            this.pickYourFormatLabel = new System.Windows.Forms.Label();
            this.firstLast = new System.Windows.Forms.Button();
            this.lastFirstMiddleTitle = new System.Windows.Forms.Button();
            this.lastFirstMiddle = new System.Windows.Forms.Button();
            this.lastNameFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(77, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.Location = new System.Drawing.Point(90, 56);
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Size = new System.Drawing.Size(127, 20);
            this.middleNameTextbox.TabIndex = 3;
            this.middleNameTextbox.TextChanged += new System.EventHandler(this.middleNameTextbox_TextChanged);
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(90, 83);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(127, 20);
            this.lastNameTextbox.TabIndex = 4;
            this.lastNameTextbox.TextChanged += new System.EventHandler(this.lastNameTextbox_TextChanged);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(23, 86);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(61, 13);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last Name:";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(12, 59);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(72, 13);
            this.middleName.TabIndex = 6;
            this.middleName.Text = "Middle Name:";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(90, 30);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(127, 20);
            this.firstNameTextbox.TabIndex = 2;
            this.firstNameTextbox.TextChanged += new System.EventHandler(this.firstNameTextbox_TextChanged);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(24, 33);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(60, 13);
            this.firstName.TabIndex = 8;
            this.firstName.Text = "First Name:";
            this.firstName.Click += new System.EventHandler(this.label3_Click);
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(90, 6);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(127, 20);
            this.titleTextbox.TabIndex = 1;
            this.titleTextbox.TextChanged += new System.EventHandler(this.titleTextbox_TextChanged);
            // 
            // preferredTitle
            // 
            this.preferredTitle.AutoSize = true;
            this.preferredTitle.Location = new System.Drawing.Point(54, 9);
            this.preferredTitle.Name = "preferredTitle";
            this.preferredTitle.Size = new System.Drawing.Size(30, 13);
            this.preferredTitle.TabIndex = 9;
            this.preferredTitle.Text = "Title:";
            this.preferredTitle.Click += new System.EventHandler(this.preferredTitle_Click);
            // 
            // nameOutputTitle
            // 
            this.nameOutputTitle.AutoSize = true;
            this.nameOutputTitle.Location = new System.Drawing.Point(12, 308);
            this.nameOutputTitle.Name = "nameOutputTitle";
            this.nameOutputTitle.Size = new System.Drawing.Size(71, 13);
            this.nameOutputTitle.TabIndex = 11;
            this.nameOutputTitle.Text = "Your name is:";
            this.nameOutputTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // nameOutput
            // 
            this.nameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutput.Location = new System.Drawing.Point(15, 321);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(202, 22);
            this.nameOutput.TabIndex = 14;
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameOutput.Click += new System.EventHandler(this.nameOutput_Click_1);
            // 
            // fullNameButton
            // 
            this.fullNameButton.Location = new System.Drawing.Point(54, 129);
            this.fullNameButton.Name = "fullNameButton";
            this.fullNameButton.Size = new System.Drawing.Size(121, 23);
            this.fullNameButton.TabIndex = 15;
            this.fullNameButton.Text = "Title First Middle Last";
            this.fullNameButton.UseVisualStyleBackColor = true;
            this.fullNameButton.Click += new System.EventHandler(this.fullNameButton_Click);
            // 
            // noTitleFullName
            // 
            this.noTitleFullName.Location = new System.Drawing.Point(64, 158);
            this.noTitleFullName.Name = "noTitleFullName";
            this.noTitleFullName.Size = new System.Drawing.Size(101, 23);
            this.noTitleFullName.TabIndex = 16;
            this.noTitleFullName.Text = "First Middle Last";
            this.noTitleFullName.UseVisualStyleBackColor = true;
            this.noTitleFullName.Click += new System.EventHandler(this.noTitleFullName_Click);
            // 
            // pickYourFormatLabel
            // 
            this.pickYourFormatLabel.AutoSize = true;
            this.pickYourFormatLabel.Location = new System.Drawing.Point(46, 111);
            this.pickYourFormatLabel.Name = "pickYourFormatLabel";
            this.pickYourFormatLabel.Size = new System.Drawing.Size(137, 13);
            this.pickYourFormatLabel.TabIndex = 17;
            this.pickYourFormatLabel.Text = "Choose your display output:";
            // 
            // firstLast
            // 
            this.firstLast.Location = new System.Drawing.Point(82, 187);
            this.firstLast.Name = "firstLast";
            this.firstLast.Size = new System.Drawing.Size(64, 23);
            this.firstLast.TabIndex = 18;
            this.firstLast.Text = "First Last";
            this.firstLast.UseVisualStyleBackColor = true;
            this.firstLast.Click += new System.EventHandler(this.firstLast_Click);
            // 
            // lastFirstMiddleTitle
            // 
            this.lastFirstMiddleTitle.Location = new System.Drawing.Point(52, 216);
            this.lastFirstMiddleTitle.Name = "lastFirstMiddleTitle";
            this.lastFirstMiddleTitle.Size = new System.Drawing.Size(124, 23);
            this.lastFirstMiddleTitle.TabIndex = 19;
            this.lastFirstMiddleTitle.Text = "Last, First Middle, Title";
            this.lastFirstMiddleTitle.UseVisualStyleBackColor = true;
            this.lastFirstMiddleTitle.Click += new System.EventHandler(this.lastFirstMiddleTitle_Click);
            // 
            // lastFirstMiddle
            // 
            this.lastFirstMiddle.Location = new System.Drawing.Point(63, 245);
            this.lastFirstMiddle.Name = "lastFirstMiddle";
            this.lastFirstMiddle.Size = new System.Drawing.Size(103, 23);
            this.lastFirstMiddle.TabIndex = 20;
            this.lastFirstMiddle.Text = "Last, First Middle";
            this.lastFirstMiddle.UseVisualStyleBackColor = true;
            this.lastFirstMiddle.Click += new System.EventHandler(this.lastFirstMiddle_Click);
            // 
            // lastNameFirst
            // 
            this.lastNameFirst.Location = new System.Drawing.Point(77, 274);
            this.lastNameFirst.Name = "lastNameFirst";
            this.lastNameFirst.Size = new System.Drawing.Size(75, 23);
            this.lastNameFirst.TabIndex = 21;
            this.lastNameFirst.Text = "Last, First";
            this.lastNameFirst.UseVisualStyleBackColor = true;
            this.lastNameFirst.Click += new System.EventHandler(this.lastNameFirst_Click);
            // 
            // nameDeclare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 381);
            this.Controls.Add(this.lastNameFirst);
            this.Controls.Add(this.lastFirstMiddle);
            this.Controls.Add(this.lastFirstMiddleTitle);
            this.Controls.Add(this.firstLast);
            this.Controls.Add(this.pickYourFormatLabel);
            this.Controls.Add(this.noTitleFullName);
            this.Controls.Add(this.fullNameButton);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.nameOutputTitle);
            this.Controls.Add(this.preferredTitle);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.middleNameTextbox);
            this.Controls.Add(this.exitButton);
            this.Name = "nameDeclare";
            this.Text = "Name Formatter!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nameOutput_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void titleTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void firstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void middleNameTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox middleNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label preferredTitle;
        private System.Windows.Forms.Label nameOutputTitle;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Button fullNameButton;
        private System.Windows.Forms.Button noTitleFullName;
        private System.Windows.Forms.Label pickYourFormatLabel;
        private System.Windows.Forms.Button firstLast;
        private System.Windows.Forms.Button lastFirstMiddleTitle;
        private System.Windows.Forms.Button lastFirstMiddle;
        private System.Windows.Forms.Button lastNameFirst;
    }
}

