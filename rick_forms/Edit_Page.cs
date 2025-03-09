using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rick_forms
{
    public partial class Edit_Page : Form
    {
        private Student_Page_Ricky profileForm;

        public Edit_Page(Student_Page_Ricky studentForm)
        {
            InitializeComponent();
            profileForm = studentForm;
        }

        private void EditAgeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                AgeErrorProvider.SetError(EditAgeInput, "Only numbers are allowed for Age!");
            }
            else
            {
                AgeErrorProvider.SetError(EditAgeInput, ""); // Clear error if input is valid
            }
        }

        private void EditContactNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                ContactErrorProvider.SetError(EditContactNumberInput, "Only numbers are allowed for contact number!");
            }
            else
            {
                ContactErrorProvider.SetError(EditContactNumberInput, ""); // Clear error if input is valid
            }
        }

        private void EditParentContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
                ParentContactErrorProvider.SetError(EditParentContact, "Only numbers are allowed for contact number!");
            }
            else
            {
                ParentContactErrorProvider.SetError(EditParentContact, ""); // Clear error if input is valid
            }
        }

        private void EditProfileSubmitButton_Click(object sender, EventArgs e)
        {

            TextBox[] inputFields = { EditNameInput, EditAgeInput, EditAddressInput, EditContactNumberInput, EditEmailInput, EditParentInput, EditParentContact, EditHobbyInput, EditNicknameInput };
            string[] fieldNames = { "name", "age", "address", "contact number", "email", "parent name", "parent contact", "hobby", "nickname" };

            ValidationErrorProvider.Clear();
            bool hasError = false;

            for (int i = 0; i < inputFields.Length; i++)
            {
                if (string.IsNullOrEmpty(inputFields[i].Text))
                {
                    ValidationErrorProvider.SetError(inputFields[i], $"{fieldNames[i]} is required");
                    hasError = true;
                }
            }

            if (EditCourseDropDown.SelectedItem == null)
            {
                ValidationErrorProvider.SetError(EditCourseDropDown, "Please select a Course.");
                hasError = true;
            }

            if (EditYearDropDown.SelectedItem == null)
            {
                ValidationErrorProvider.SetError(EditYearDropDown, "Please select a Year Level.");
                hasError = true;
            }

            if (hasError) return;

            string updatedName = EditNameInput.Text;
            string updatedAge = EditAgeInput.Text.ToString();
            string updatedAddress = EditAddressInput.Text;
            string updatedContactNumber = EditContactNumberInput.Text.ToString();
            string updatedEmail = EditEmailInput.Text;
            string updatedCourse = EditCourseDropDown.SelectedItem?.ToString();
            string updatedYear = EditYearDropDown.SelectedItem?.ToString();
            string updatedParent = EditParentInput.Text;
            string updatedParentContact = EditParentContact.Text.ToString();
            string updatedHobby = EditHobbyInput.Text;
            string updateNickname = EditNicknameInput.Text;

            profileForm.UpdateProfile(updatedName, updatedAge, updatedAddress, updatedContactNumber, updatedEmail, updatedCourse, updatedYear, updatedParent, updatedParentContact, updatedHobby, updateNickname);

            this.Close();
        }
    }
}
