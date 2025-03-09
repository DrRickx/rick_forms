namespace rick_forms
{
    partial class Edit_Page
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
            components = new System.ComponentModel.Container();
            EditNameLabel = new Label();
            EditNameInput = new TextBox();
            EditProfileSubmitButton = new Button();
            EditAgeLabel = new Label();
            EditAgeInput = new TextBox();
            EditAddressInput = new TextBox();
            EditAddressLabel = new Label();
            EditContactNumberInput = new TextBox();
            EditContactNumberLabel = new Label();
            EditEmailInput = new TextBox();
            EditEmailLabel = new Label();
            EditNicknameInput = new TextBox();
            EditNicknameLabel = new Label();
            EditHobbyInput = new TextBox();
            EditHobbyLabel = new Label();
            EditParentInput = new TextBox();
            EditParentLabel = new Label();
            EditYearLabel = new Label();
            CourseLabel = new Label();
            EditCourseDropDown = new ComboBox();
            EditYearDropDown = new ComboBox();
            EditParentContact = new TextBox();
            EditParentContactLabel = new Label();
            AgeErrorProvider = new ErrorProvider(components);
            ContactErrorProvider = new ErrorProvider(components);
            ValidationErrorProvider = new ErrorProvider(components);
            ParentContactErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)AgeErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContactErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValidationErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ParentContactErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // EditNameLabel
            // 
            EditNameLabel.AutoSize = true;
            EditNameLabel.Font = new Font("Century Gothic", 9F);
            EditNameLabel.Location = new Point(92, 61);
            EditNameLabel.Name = "EditNameLabel";
            EditNameLabel.Size = new Size(57, 20);
            EditNameLabel.TabIndex = 0;
            EditNameLabel.Text = "Name:";
            // 
            // EditNameInput
            // 
            EditNameInput.Location = new Point(245, 58);
            EditNameInput.Name = "EditNameInput";
            EditNameInput.Size = new Size(140, 26);
            EditNameInput.TabIndex = 1;
            // 
            // EditProfileSubmitButton
            // 
            EditProfileSubmitButton.Location = new Point(372, 328);
            EditProfileSubmitButton.Name = "EditProfileSubmitButton";
            EditProfileSubmitButton.Size = new Size(106, 29);
            EditProfileSubmitButton.TabIndex = 2;
            EditProfileSubmitButton.Text = "Submit";
            EditProfileSubmitButton.UseVisualStyleBackColor = true;
            EditProfileSubmitButton.Click += EditProfileSubmitButton_Click;
            // 
            // EditAgeLabel
            // 
            EditAgeLabel.AutoSize = true;
            EditAgeLabel.Font = new Font("Century Gothic", 9F);
            EditAgeLabel.Location = new Point(92, 95);
            EditAgeLabel.Name = "EditAgeLabel";
            EditAgeLabel.Size = new Size(44, 20);
            EditAgeLabel.TabIndex = 3;
            EditAgeLabel.Text = "Age:";
            // 
            // EditAgeInput
            // 
            EditAgeInput.Location = new Point(245, 95);
            EditAgeInput.Name = "EditAgeInput";
            EditAgeInput.Size = new Size(140, 26);
            EditAgeInput.TabIndex = 4;
            EditAgeInput.KeyPress += EditAgeInput_KeyPress;
            // 
            // EditAddressInput
            // 
            EditAddressInput.Location = new Point(245, 138);
            EditAddressInput.Name = "EditAddressInput";
            EditAddressInput.Size = new Size(140, 26);
            EditAddressInput.TabIndex = 6;
            // 
            // EditAddressLabel
            // 
            EditAddressLabel.AutoSize = true;
            EditAddressLabel.Font = new Font("Century Gothic", 9F);
            EditAddressLabel.Location = new Point(92, 138);
            EditAddressLabel.Name = "EditAddressLabel";
            EditAddressLabel.Size = new Size(75, 20);
            EditAddressLabel.TabIndex = 5;
            EditAddressLabel.Text = "Address: ";
            // 
            // EditContactNumberInput
            // 
            EditContactNumberInput.Location = new Point(245, 182);
            EditContactNumberInput.Name = "EditContactNumberInput";
            EditContactNumberInput.Size = new Size(140, 26);
            EditContactNumberInput.TabIndex = 8;
            EditContactNumberInput.KeyPress += EditContactNumberInput_KeyPress;
            // 
            // EditContactNumberLabel
            // 
            EditContactNumberLabel.AutoSize = true;
            EditContactNumberLabel.Font = new Font("Century Gothic", 9F);
            EditContactNumberLabel.Location = new Point(92, 182);
            EditContactNumberLabel.Name = "EditContactNumberLabel";
            EditContactNumberLabel.Size = new Size(136, 20);
            EditContactNumberLabel.TabIndex = 7;
            EditContactNumberLabel.Text = "Contact Number:";
            // 
            // EditEmailInput
            // 
            EditEmailInput.Location = new Point(245, 231);
            EditEmailInput.Name = "EditEmailInput";
            EditEmailInput.Size = new Size(140, 26);
            EditEmailInput.TabIndex = 10;
            // 
            // EditEmailLabel
            // 
            EditEmailLabel.AutoSize = true;
            EditEmailLabel.Font = new Font("Century Gothic", 9F);
            EditEmailLabel.Location = new Point(92, 231);
            EditEmailLabel.Name = "EditEmailLabel";
            EditEmailLabel.Size = new Size(112, 20);
            EditEmailLabel.TabIndex = 9;
            EditEmailLabel.Text = "Email Address:";
            // 
            // EditNicknameInput
            // 
            EditNicknameInput.Location = new Point(512, 266);
            EditNicknameInput.Name = "EditNicknameInput";
            EditNicknameInput.Size = new Size(318, 26);
            EditNicknameInput.TabIndex = 20;
            // 
            // EditNicknameLabel
            // 
            EditNicknameLabel.AutoSize = true;
            EditNicknameLabel.Font = new Font("Century Gothic", 9F);
            EditNicknameLabel.Location = new Point(417, 269);
            EditNicknameLabel.Name = "EditNicknameLabel";
            EditNicknameLabel.Size = new Size(87, 20);
            EditNicknameLabel.TabIndex = 19;
            EditNicknameLabel.Text = "Nickname:";
            // 
            // EditHobbyInput
            // 
            EditHobbyInput.Location = new Point(512, 224);
            EditHobbyInput.Name = "EditHobbyInput";
            EditHobbyInput.Size = new Size(318, 26);
            EditHobbyInput.TabIndex = 18;
            // 
            // EditHobbyLabel
            // 
            EditHobbyLabel.AutoSize = true;
            EditHobbyLabel.Font = new Font("Century Gothic", 9F);
            EditHobbyLabel.Location = new Point(417, 227);
            EditHobbyLabel.Name = "EditHobbyLabel";
            EditHobbyLabel.Size = new Size(72, 20);
            EditHobbyLabel.TabIndex = 17;
            EditHobbyLabel.Text = "Hobbies:";
            // 
            // EditParentInput
            // 
            EditParentInput.Location = new Point(611, 142);
            EditParentInput.Name = "EditParentInput";
            EditParentInput.Size = new Size(219, 26);
            EditParentInput.TabIndex = 16;
            // 
            // EditParentLabel
            // 
            EditParentLabel.AutoSize = true;
            EditParentLabel.Font = new Font("Century Gothic", 9F);
            EditParentLabel.Location = new Point(417, 142);
            EditParentLabel.Name = "EditParentLabel";
            EditParentLabel.Size = new Size(187, 20);
            EditParentLabel.TabIndex = 15;
            EditParentLabel.Text = "Parent/ Guardian name:";
            // 
            // EditYearLabel
            // 
            EditYearLabel.AutoSize = true;
            EditYearLabel.Font = new Font("Century Gothic", 9F);
            EditYearLabel.Location = new Point(417, 99);
            EditYearLabel.Name = "EditYearLabel";
            EditYearLabel.Size = new Size(45, 20);
            EditYearLabel.TabIndex = 13;
            EditYearLabel.Text = "Year:";
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Century Gothic", 9F);
            CourseLabel.Location = new Point(417, 65);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(61, 20);
            CourseLabel.TabIndex = 11;
            CourseLabel.Text = "Course";
            // 
            // EditCourseDropDown
            // 
            EditCourseDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            EditCourseDropDown.FormattingEnabled = true;
            EditCourseDropDown.Items.AddRange(new object[] { "BSIT", "BPA", "BPED", "BSBA" });
            EditCourseDropDown.Location = new Point(611, 62);
            EditCourseDropDown.Name = "EditCourseDropDown";
            EditCourseDropDown.Size = new Size(219, 28);
            EditCourseDropDown.TabIndex = 21;
            // 
            // EditYearDropDown
            // 
            EditYearDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            EditYearDropDown.FormattingEnabled = true;
            EditYearDropDown.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth" });
            EditYearDropDown.Location = new Point(611, 99);
            EditYearDropDown.Name = "EditYearDropDown";
            EditYearDropDown.Size = new Size(219, 28);
            EditYearDropDown.TabIndex = 22;
            // 
            // EditParentContact
            // 
            EditParentContact.Location = new Point(690, 185);
            EditParentContact.Name = "EditParentContact";
            EditParentContact.Size = new Size(140, 26);
            EditParentContact.TabIndex = 24;
            EditParentContact.KeyPress += EditParentContact_KeyPress;
            // 
            // EditParentContactLabel
            // 
            EditParentContactLabel.AutoSize = true;
            EditParentContactLabel.Font = new Font("Century Gothic", 9F);
            EditParentContactLabel.Location = new Point(417, 185);
            EditParentContactLabel.Name = "EditParentContactLabel";
            EditParentContactLabel.Size = new Size(268, 20);
            EditParentContactLabel.TabIndex = 23;
            EditParentContactLabel.Text = "Parent/ Guardian Contact Number:";
            // 
            // AgeErrorProvider
            // 
            AgeErrorProvider.ContainerControl = this;
            // 
            // ContactErrorProvider
            // 
            ContactErrorProvider.ContainerControl = this;
            // 
            // ValidationErrorProvider
            // 
            ValidationErrorProvider.ContainerControl = this;
            // 
            // ParentContactErrorProvider
            // 
            ParentContactErrorProvider.ContainerControl = this;
            // 
            // Edit_Page
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(EditParentContact);
            Controls.Add(EditParentContactLabel);
            Controls.Add(EditYearDropDown);
            Controls.Add(EditCourseDropDown);
            Controls.Add(EditNicknameInput);
            Controls.Add(EditNicknameLabel);
            Controls.Add(EditHobbyInput);
            Controls.Add(EditHobbyLabel);
            Controls.Add(EditParentInput);
            Controls.Add(EditParentLabel);
            Controls.Add(EditYearLabel);
            Controls.Add(CourseLabel);
            Controls.Add(EditEmailInput);
            Controls.Add(EditEmailLabel);
            Controls.Add(EditContactNumberInput);
            Controls.Add(EditContactNumberLabel);
            Controls.Add(EditAddressInput);
            Controls.Add(EditAddressLabel);
            Controls.Add(EditAgeInput);
            Controls.Add(EditAgeLabel);
            Controls.Add(EditProfileSubmitButton);
            Controls.Add(EditNameInput);
            Controls.Add(EditNameLabel);
            Font = new Font("Century Gothic", 9F);
            Name = "Edit_Page";
            Text = "Edit_Page";
            ((System.ComponentModel.ISupportInitialize)AgeErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContactErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValidationErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ParentContactErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditNameLabel;
        private TextBox EditNameInput;
        private Button EditProfileSubmitButton;
        private Label EditAgeLabel;
        private TextBox EditAgeInput;
        private TextBox EditAddressInput;
        private Label EditAddressLabel;
        private TextBox EditContactNumberInput;
        private Label EditContactNumberLabel;
        private TextBox EditEmailInput;
        private Label EditEmailLabel;
        private TextBox EditNicknameInput;
        private Label EditNicknameLabel;
        private TextBox EditHobbyInput;
        private Label EditHobbyLabel;
        private TextBox EditParentInput;
        private Label EditParentLabel;
        private Label EditYearLabel;
        private Label CourseLabel;
        private ComboBox EditCourseDropDown;
        private ComboBox EditYearDropDown;
        private TextBox EditParentContact;
        private Label EditParentContactLabel;
        private ErrorProvider AgeErrorProvider;
        private ErrorProvider ContactErrorProvider;
        private ErrorProvider ValidationErrorProvider;
        private ErrorProvider ParentContactErrorProvider;
    }
}