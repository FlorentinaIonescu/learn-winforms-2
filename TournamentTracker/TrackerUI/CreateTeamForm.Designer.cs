﻿namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailAddressValue = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.cellphoneNumberValue = new System.Windows.Forms.TextBox();
            this.cellphoneNumberLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(22, 108);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(336, 34);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamNameLabel.Location = new System.Drawing.Point(22, 68);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(160, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 17);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(202, 47);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addTeamMemberButton.Location = new System.Drawing.Point(104, 244);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(232, 47);
            this.addTeamMemberButton.TabIndex = 19;
            this.addTeamMemberButton.Text = "Add Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(22, 202);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(336, 36);
            this.selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(25, 162);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(266, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.cellphoneNumberValue);
            this.groupBox1.Controls.Add(this.cellphoneNumberLabel);
            this.groupBox1.Controls.Add(this.emailAddressValue);
            this.groupBox1.Controls.Add(this.emailAddressLabel);
            this.groupBox1.Controls.Add(this.lastNameValue);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.firstNameValue);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 313);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(166, 54);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(258, 43);
            this.firstNameValue.TabIndex = 10;
            this.firstNameValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(166, 102);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(258, 43);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 102);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailAddressValue
            // 
            this.emailAddressValue.Location = new System.Drawing.Point(166, 150);
            this.emailAddressValue.Name = "emailAddressValue";
            this.emailAddressValue.Size = new System.Drawing.Size(258, 43);
            this.emailAddressValue.TabIndex = 14;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAddressLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emailAddressLabel.Location = new System.Drawing.Point(16, 153);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(82, 37);
            this.emailAddressLabel.TabIndex = 13;
            this.emailAddressLabel.Text = "Email";
            // 
            // cellphoneNumberValue
            // 
            this.cellphoneNumberValue.Location = new System.Drawing.Point(166, 198);
            this.cellphoneNumberValue.Name = "cellphoneNumberValue";
            this.cellphoneNumberValue.Size = new System.Drawing.Size(258, 43);
            this.cellphoneNumberValue.TabIndex = 16;
            // 
            // cellphoneNumberLabel
            // 
            this.cellphoneNumberLabel.AutoSize = true;
            this.cellphoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneNumberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cellphoneNumberLabel.Location = new System.Drawing.Point(16, 198);
            this.cellphoneNumberLabel.Name = "cellphoneNumberLabel";
            this.cellphoneNumberLabel.Size = new System.Drawing.Size(138, 37);
            this.cellphoneNumberLabel.TabIndex = 15;
            this.cellphoneNumberLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createMemberButton.Location = new System.Drawing.Point(88, 247);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(232, 39);
            this.createMemberButton.TabIndex = 21;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 28;
            this.teamMembersListBox.Location = new System.Drawing.Point(466, 108);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(332, 506);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(804, 333);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(103, 87);
            this.deleteSelectedMemberButton.TabIndex = 22;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTeamButton.Location = new System.Drawing.Point(291, 632);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(365, 70);
            this.createTeamButton.TabIndex = 22;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 733);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropdown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private TextBox cellphoneNumberValue;
        private Label cellphoneNumberLabel;
        private TextBox emailAddressValue;
        private Label emailAddressLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}