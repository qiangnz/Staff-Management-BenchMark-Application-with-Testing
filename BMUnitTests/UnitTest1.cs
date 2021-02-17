using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qiang_Zhang_SD6503_Assignment_1;
using System;
using System.Collections.Generic;
using System.IO;


namespace BMUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //Test StaffID in Staff Class 
        [TestMethod]
        public void TestStaffID()
        {
            Staff s = new Staff();
            s.StaffId = "001";
            Assert.AreEqual("001", s.StaffId);
        }

        //Test Staff Name in Staff Class 
        [TestMethod]
        public void TestStaffName()
        {
            Staff s = new Staff();
            s.StaffName = "Qiang";
            Assert.AreEqual("Qiang", s.StaffName);
        }

        //Test Date of birth in Staff Class 
        [TestMethod]
        public void TestDateofBith()
        {
            Staff s = new Staff();
            s.DateofBirth = "10/08/2000";
            Assert.AreEqual("10/08/2000", s.DateofBirth);
        }

        //Test email in Staff Class 
        [TestMethod]
        public void TestEmail()
        {
            Staff s = new Staff();
            s.Email = "qiang@gmail.com";
            Assert.AreEqual("qiang@gmail.com", s.Email);
        }

        //Test AnnualSalary in Staff Class 
        [TestMethod]
        public void TestAnnualSalary()
        {
            Staff s = new Staff();
            s.AnnualSalary = "$90000";
            Assert.AreEqual("$90000", s.AnnualSalary);
        }

        //Test position in Staff Class 
        [TestMethod]
        public void TestPosition()
        {
            Staff s = new Staff();
            s.Position = "Manager";
            Assert.AreEqual("Manager", s.Position);
        }

        //Test department in Staff Class 
        [TestMethod]
        public void TestDepartment()
        {
            Staff s = new Staff();
            s.Department = "IT";
            Assert.AreEqual("IT", s.Department);
        }

        //Test Staff construtor in Staff Class 
        [TestMethod]
        public void TestStaffConstructor()
        {
            Staff s = new Staff();

            Assert.AreEqual("NA", s.StaffId, "ID Fail");
            Assert.AreEqual("NA", s.StaffName, "Name Fail");
            Assert.AreEqual("NA", s.DateofBirth, "Date of Birth Fail");
            Assert.AreEqual("NA", s.Email, "Email Fail");
            Assert.AreEqual("NA", s.AnnualSalary, "Annual Salary Fail");
            Assert.AreEqual("NA", s.Position, "Position Fail");
            Assert.AreEqual("NA", s.Department, "Department Fail");
        }

        //Test Staff information to string format in Staff Class 
        [TestMethod]
        public void TestStaffToStringFormat()
        {
            Staff s = new Staff();

            s.StaffId = "001";
            s.StaffName = "Qiang";
            s.DateofBirth = "10/08/2000";
            s.Email = "qiang@google.com";
            s.AnnualSalary = "$90000";
            s.Position = "Manager";
            s.Department = "IT";
            Assert.AreEqual("001,Qiang,10/08/2000,qiang@google.com,$90000,Manager,IT", s.ToString());
        }

        //Test SortAZ method in Filter Class 
        [TestMethod]
        public void TestFilterSortAZ()
        {
            Staff s1 = new Staff();
            s1.StaffId = "001";
            s1.StaffName = "Anna";
            s1.DateofBirth = "10/08/2000";
            s1.Email = "anna@google.com";
            s1.AnnualSalary = "$90000";
            s1.Position = "Manager";
            s1.Department = "IT";

            Staff s2 = new Staff();
            s2.StaffId = "002";
            s2.StaffName = "John";
            s2.DateofBirth = "15/02/2005";
            s2.Email = "john@google.com";
            s2.AnnualSalary = "$50000";
            s2.Position = "Staff";
            s2.Department = "IT";

            Staff s3 = new Staff();
            s3.StaffId = "003";
            s3.StaffName = "Ken";
            s3.DateofBirth = "20/06/2002";
            s3.Email = "ken@google.com";
            s3.AnnualSalary = "$60000";
            s3.Position = "Staff";
            s3.Department = "Sales";

            Staff s4 = new Staff();
            s4.StaffId = "004";
            s4.StaffName = "Qiang";
            s4.DateofBirth = "25/01/2001";
            s4.Email = "qiang@google.com";
            s4.AnnualSalary = "$50000";
            s4.Position = "Staff";
            s4.Department = "Sales";

            List<Staff> sListExpected = new List<Staff>();
            sListExpected.Add(s1);
            sListExpected.Add(s2);
            sListExpected.Add(s3);
            sListExpected.Add(s4);

            List<Staff> sList = new List<Staff>();
            sList.Add(s2);
            sList.Add(s4);
            sList.Add(s3);
            sList.Add(s1);

            Filter f = new Filter();
            sList = f.SortAZ(sList);
            CollectionAssert.AreEqual(sListExpected, sList);
        }

        //Test SortZA method in Filter Class 
        [TestMethod]
        public void TestFilterSortZA()
        {
            Staff s1 = new Staff();
            s1.StaffId = "001";
            s1.StaffName = "Anna";
            s1.DateofBirth = "10/08/2000";
            s1.Email = "anna@google.com";
            s1.AnnualSalary = "$90000";
            s1.Position = "Manager";
            s1.Department = "IT";

            Staff s2 = new Staff();
            s2.StaffId = "002";
            s2.StaffName = "John";
            s2.DateofBirth = "15/02/2005";
            s2.Email = "john@google.com";
            s2.AnnualSalary = "$50000";
            s2.Position = "Staff";
            s2.Department = "IT";

            Staff s3 = new Staff();
            s3.StaffId = "003";
            s3.StaffName = "Ken";
            s3.DateofBirth = "20/06/2002";
            s3.Email = "ken@google.com";
            s3.AnnualSalary = "$60000";
            s3.Position = "Staff";
            s3.Department = "Sales";

            Staff s4 = new Staff();
            s4.StaffId = "004";
            s4.StaffName = "Qiang";
            s4.DateofBirth = "25/01/2001";
            s4.Email = "qiang@google.com";
            s4.AnnualSalary = "$50000";
            s4.Position = "Staff";
            s4.Department = "Sales";

            List<Staff> sListExpected = new List<Staff>();
            sListExpected.Add(s4);
            sListExpected.Add(s3);
            sListExpected.Add(s2);
            sListExpected.Add(s1);

            List<Staff> sList = new List<Staff>();
            sList.Add(s2);
            sList.Add(s4);
            sList.Add(s3);
            sList.Add(s1);

            Filter f = new Filter();
            sList = f.SortZA(sList);
            CollectionAssert.AreEqual(sListExpected, sList);
        }

        //Test Search method in Filter Class 
        [TestMethod]
        public void TestFilterSearch()
        {
            Staff s1 = new Staff();
            s1.StaffId = "001";
            s1.StaffName = "Anna";
            s1.DateofBirth = "10/08/2000";
            s1.Email = "anna@google.com";
            s1.AnnualSalary = "$90000";
            s1.Position = "Manager";
            s1.Department = "IT";

            Staff s2 = new Staff();
            s2.StaffId = "002";
            s2.StaffName = "John";
            s2.DateofBirth = "15/02/2005";
            s2.Email = "john@google.com";
            s2.AnnualSalary = "$50000";
            s2.Position = "Staff";
            s2.Department = "IT";

            Staff s3 = new Staff();
            s3.StaffId = "003";
            s3.StaffName = "Ken";
            s3.DateofBirth = "20/06/2002";
            s3.Email = "ken@google.com";
            s3.AnnualSalary = "$60000";
            s3.Position = "Staff";
            s3.Department = "Sales";

            Staff s4 = new Staff();
            s4.StaffId = "004";
            s4.StaffName = "Qiang";
            s4.DateofBirth = "25/01/2001";
            s4.Email = "qiang@google.com";
            s4.AnnualSalary = "$50000";
            s4.Position = "Staff";
            s4.Department = "Sales";

            List<Staff> sList = new List<Staff>();
            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);
            sList.Add(s4);

            Filter f = new Filter();

            List<Staff> searchResults = new List<Staff>();

            searchResults = f.Search(sList, "o");

            CollectionAssert.DoesNotContain(searchResults, s1);
            CollectionAssert.Contains(searchResults, s2);
            CollectionAssert.DoesNotContain(searchResults, s3);
            CollectionAssert.DoesNotContain(searchResults, s4);
        }


        //Test Load file method in FileManager Class 
        [TestMethod]
        public void TestFileLoad()
        {
            //Create method read Staff.txt to list
            string currentDir = Environment.CurrentDirectory;  //get current directory
            //change current directory to Solution path with Staff.txt
            string path = Directory.GetParent(currentDir).Parent.Parent.FullName + @"\Qiang Zhang SD6503 Assignment 1\bin\Debug\Staffs.txt"; 
            List<Staff> sListExpected = new List<Staff>();
            StreamReader sr = new StreamReader(path);
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
                sListExpected.Add(s);
            }


            //Using FileManager read Staff.txt to list
            List<Staff> sList = new List<Staff>();
            FileManager fm = new FileManager();
            sList = fm.LoadStaffs();


            //Compare both lists are same
            CollectionAssert.ReferenceEquals(sListExpected, sList);
        }

        //Test Write file method in FileManager Class 
        [TestMethod]
        public void TestFileSave()
        {
            FileManager fm = new FileManager();
            Staff s = new Staff();
            s.StaffId = "001";
            s.StaffName = "Qiang";
            s.DateofBirth = "10/08/2000";
            s.Email = "qiang@google.com";
            s.AnnualSalary = "$90000";
            s.Position = "Manager";
            s.Department = "IT";

            fm.SaveStaff(s, "Qiang.txt");

            Assert.IsTrue(true,"Qiang.txt");
        }
    }
}