using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qiang_Zhang_SD6503_Assignment_1
{
    //This class is the GUI for the application
    public partial class Form1 : Form
    {
        List<Staff> staffs = new List<Staff>();

        public Form1()
        {
            InitializeComponent();
        }

        //To clear Textbox after click a button
        public void clearTextBox()
        {
            tbxStaffID.Clear();
            tbxName.Clear();
            tbxDateofBirth.ResetText();
            tbxEmail.Clear();
            tbxAnnualSalary.Clear();
            tbxPosition.Clear();
            tbxDepartment.Clear();
        }

        //To add a new staff when input vaild information in Staff.txt
        //Validation input information, if invalid error message
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //regex pattern for validate each information
            Regex checkStaffID = new Regex(@"^[0-9]*$");
            Regex checkName = new Regex(@"^[A-Za-z]+$");
            Regex checkDateofBirth = new Regex("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$");
            Regex checkEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            Regex checkAnnualSalary = new Regex(@"^[0-9]*$");
            Regex checkPosition = new Regex(@"^[A-Za-z]+$");
            Regex checkDepartment = new Regex(@"^[A-Za-z]+$");

            string staffId = tbxStaffID.Text;
            string staffName = tbxName.Text;
            string dateofBirth = tbxDateofBirth.Text;
            string email = tbxEmail.Text;
            string annualSalary = tbxAnnualSalary.Text;
            string position = tbxPosition.Text;
            string department = tbxDepartment.Text;

            //validate each information client inputed
            //if inputed staff id not number or inputed nothing
            if (!checkStaffID.IsMatch(tbxStaffID.Text) || string.IsNullOrEmpty(tbxStaffID.Text))
            {
                MessageBox.Show("Please input 3 digital numbers as staff ID", "Input Error");
            }
            //if inputed staff name not characters or inputed nothing
            else if (!checkName.IsMatch(tbxName.Text) || string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Please input characters as staff name", "Input Error");
            }
            //if inputed staff date of birth not DD/MM/YYYY format or inputed nothing
            else if (!checkDateofBirth.IsMatch(tbxDateofBirth.Text) || string.IsNullOrEmpty(tbxDateofBirth.Text))
            {
                MessageBox.Show("Please input valid date format\n ex 21/05/2002", "Input Error");
            }
            //if inputed email adress not email address format or inputed nothing
            else if (!checkEmail.IsMatch(tbxEmail.Text) || string.IsNullOrEmpty(tbxEmail.Text))
            {
                MessageBox.Show("Please input valid Email address", "Input Error");
            }
            //if inputed annual salary not numbers or inputed nothing
            else if (!checkAnnualSalary.IsMatch(tbxAnnualSalary.Text) || string.IsNullOrEmpty(tbxAnnualSalary.Text))
            {
                MessageBox.Show("Please input number as annual salary", "Input Error");
            }
            //if inputed position not characters or inputed nothing
            else if (!checkPosition.IsMatch(tbxPosition.Text) || string.IsNullOrEmpty(tbxPosition.Text))
            {
                MessageBox.Show("Please input characters as position", "Input Error");
            }
            //if inputed department not characters or inputed nothing
            else if (!checkDepartment.IsMatch(tbxDepartment.Text) || string.IsNullOrEmpty(tbxDepartment.Text))
            {
                MessageBox.Show("Please input characters as department", "Input Error");
            }
            //all information inputed valid and save the new staff in to Staffs.txt
            else
            {
                StreamWriter myInfoWriter = new StreamWriter("Staffs.txt", true);
                myInfoWriter.WriteLine(staffId + "," + staffName + "," + dateofBirth + "," + email.ToLower() + "," + "$" + annualSalary + "," + position + "," + department);
                clearTextBox();
                myInfoWriter.Close();
                MessageBox.Show("A new staff added", "Save Successful");
            }
            
        }

        //Load staff information and display in the  display staff listbox when click Load button
        private void btnLoad_Click(object sender, EventArgs e)
        {
            staffs.Clear();

            FileManager fm = new FileManager();
            staffs = fm.LoadStaffs();

            //If Staff.txt file empty or not found, Error message appare
            if (staffs == null)
            {
                MessageBox.Show("Error Loading Staffs", "File IO Error");
            }
            else
            {
                //display in the display staffs listbox
                lbxDisplayStaffs.Items.Clear();
                lbxDisplayStaffs.Items.AddRange(staffs.ToArray());
            }
        }
        //Sort staffs name first letter from A to Z when click AZ button and display in the search listbox
        private void btnAZ_Click(object sender, EventArgs e)
        {
            Filter sFilter = new Filter();
            staffs = sFilter.SortAZ(staffs);
            //update search listbox
            lbxDisplayStaffs.Items.Clear();
            lbxDisplayStaffs.Items.AddRange(staffs.ToArray());
        }
        //Sort staffs name first letter from Z to A when click ZA button and display in the search listbox
        private void btnZA_Click(object sender, EventArgs e)
        {
            Filter sFilter = new Filter();
            staffs = sFilter.SortZA(staffs);
            //update search listbox
            lbxDisplayStaffs.Items.Clear();
            lbxDisplayStaffs.Items.AddRange(staffs.ToArray());
        }

        //search staff name by inputed in search textbox when click Search button and display result in the search listbox
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Staff> results = new List<Staff>();
            Filter sFilter = new Filter();
            string term = tbxSearch.Text;
            results = sFilter.Search(staffs, term);

            //update search listbox
            lbxSearch.Items.Clear();
            lbxSearch.Items.AddRange(results.ToArray());
        }

        //when select a staff in the search listbox, then display each information in each textbox
        private void lbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Staff s = (Staff)lbxSearch.SelectedItem;

                tbxStaffID.Text = s.StaffId;
                tbxName.Text = s.StaffName;
                tbxDateofBirth.Text = s.DateofBirth;
                tbxEmail.Text = s.Email;
                tbxAnnualSalary.Text = s.AnnualSalary;
                tbxPosition.Text = s.Position;
                tbxDepartment.Text = s.Department; 
            }
            catch (Exception)
            {              
            }
        }

        //Delect select staff from search listbox and display staffs listbox also remove from Staff.txt
        //when click Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxSearch.SelectedIndex != -1)
            {
                //warning make sure to delete selected staff
                if (MessageBox.Show("Do you want to delete a staff?", "Warning!",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    //remove selected staff from search listbox and display staffs listbox
                    StreamWriter sw = new StreamWriter("Staffs.txt");
                    Staff s = (Staff)lbxSearch.SelectedItem;
                    lbxSearch.Items.Remove(s);
                    lbxDisplayStaffs.Items.Remove(s);
                    
                    //save Staff.txt after remove the selected staff
                    for(int i=0; lbxDisplayStaffs.Items.Count > i; i++)
                    {
                        sw.WriteLine(lbxDisplayStaffs.Items[i]);
                    }
                    sw.Close();
                    clearTextBox();
                    tbxSearch.Clear();
                }
            }
            //If not select a staff in the search listbox error message
            else
            {
                MessageBox.Show("Please selete a staff");
            }

        }


        //Save a selected staff information to a txt file
        //the file name is the staff name selected
        //when click Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileManager fm = new FileManager();
                Staff s = (Staff)lbxSearch.SelectedItem;

                string fileName = s.StaffName+".txt";

                bool result = fm.SaveStaff(s, fileName);
                if (result == false)
                {
                    MessageBox.Show("Error Saving Staff", "File IO Error");
                }
                else
                {
                    //Message save the select staff to a file or not
                    DialogResult dr = MessageBox.Show("View File?", "Save Success", MessageBoxButtons.YesNo);

                    if (dr.Equals(DialogResult.Yes))
                    {
                        MessageBox.Show("Save Successful", "Success");
                        System.Diagnostics.Process.Start(fileName);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select a Staff", "Error");
            }
        }


    }
    
    
}
