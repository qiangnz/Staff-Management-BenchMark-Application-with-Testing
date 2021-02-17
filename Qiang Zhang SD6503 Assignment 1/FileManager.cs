using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Qiang_Zhang_SD6503_Assignment_1
{
    //This class used by application to read and write object to Staffs.txt file
    public class FileManager
    {        
        //Read staff information from Staffs.txt
        public List<Staff> LoadStaffs()
        {
            try
            {
                List<Staff> staffList = new List<Staff>();
                StreamReader sr = new StreamReader("Staffs.txt");
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string[] values = temp.Split(',');
                    
                    Staff s = new Staff();
                    s.StaffId = values[0];
                    s.StaffName = values[1];
                    s.DateofBirth = values[2];
                    s.Email = values[3];
                    s.AnnualSalary = values[4];
                    s.Position = values[5];
                    s.Department = values[6];
                    staffList.Add(s);
                }
                sr.Dispose();
                return staffList;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
        //save staff information in Staffs.txt
        public bool SaveStaff(Staff s, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("STAFF DETAILS");
                sw.WriteLine("Staff ID: " + s.StaffId);
                sw.WriteLine("Staff Name: " + s.StaffName);
                sw.WriteLine("Data of Birth: " + s.DateofBirth);
                sw.WriteLine("Email: " + s.Email);
                sw.WriteLine("Annual Sarlary: " + s.AnnualSalary);
                sw.WriteLine("Position: " + s.Position);
                sw.WriteLine("Department: " + s.Department);
                sw.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }




    }


        




    

}
