using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace rick_forms
{
    public partial class Student_Page_Ricky : Form
    {
        public Student_Page_Ricky()
        {
            InitializeComponent();
        }

        public void UpdateProfile(string name, string age, string address, string contactNumber, string email, string course, string year, string parent, string parentContact, string hobby, string nickname)
        {
            NameContent.Text = name;
            AgeContent.Text = age;
            AddressContent.Text = address;
            ContactNumberContent.Text = contactNumber;
            EmailContent.Text = email;
            CourseContent.Text = course;
            YearContent.Text = year;
            ParentContent.Text = parent;
            ParentContactNumberContent.Text = parentContact;
            HobbyContent.Text = hobby;
            NickanmeContent.Text = nickname;
        }

        private void ProfileEditButton_Click(object sender, EventArgs e)
        {
            Edit_Page editForm = new Edit_Page(this);
            editForm.Show();
        }
    }
}
