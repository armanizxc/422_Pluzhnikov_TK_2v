using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ExamResultsAppTests
    {
        [TestMethod]
        public void GetGrade_Excellent()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(60);
            Assert.AreEqual("5 (Отлично)", grade);
        }

        [TestMethod]
        public void GetGrade_Good()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(40);
            Assert.AreEqual("4 (Хорошо)", grade);
        }

        [TestMethod]
        public void GetGrade_Satisfactory()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(20);
            Assert.AreEqual("3 (Удовлетворительно)", grade);
        }

        [TestMethod]
        public void GetGrade_Unsatisfactory()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(10);
            Assert.AreEqual("2 (Неудовлетворительно)", grade);
        }

        [TestMethod]
        public void GetGrade_Boundary_Excellent_Lower()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(56);
            Assert.AreEqual("5 (Отлично)", grade);
        }

        [TestMethod]
        public void GetGrade_Boundary_Good_Upper()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(55);
            Assert.AreEqual("4 (Хорошо)", grade);
        }

        [TestMethod]
        public void GetGrade_Boundary_Good_Lower()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(32);
            Assert.AreEqual("4 (Хорошо)", grade);
        }

        [TestMethod]
        public void GetGrade_Boundary_Satisfactory_Upper()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(31);
            Assert.AreEqual("3 (Удовлетворительно)", grade);
        }

        [TestMethod]
        public void GetGrade_Boundary_Satisfactory_Lower()
        {
            MainWindow form = new MainWindow();
            string grade = form.GetGrade(16);
            Assert.AreEqual("3 (Удовлетворительно)", grade);
        }
    }
}
