using CalendarApp;
using System;

namespace Assignment3Tests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestInitialize]
        //public void initialize()
        //{
        //    int daunum = 8;
        //}
        [TestMethod]
        public void DateTest()
        {
            int daynum = 1;
            Date d = new Date(1);
            int result = d.GetDay();
            Assert.AreEqual(daynum, result);
            
        }

        [TestMethod]
        public void DateTest2()
        {
            int month = 1;
            Date d = new Date(1);
            int result = d.GetMonth();
            Assert.AreEqual(month, result);

        }

        [TestMethod]
        public void DateTest3()
        {
            int year = 1;
            Date d = new Date(1);
            int result = d.GetYear();
            Assert.AreEqual(year, result);

        }


      
          
        [TestMethod]
        public void LeapYear()
        {
            int year = 1999;
            bool ExpectedResult = false;
            bool Result = Date.IsLeapYear(year);
            Assert.AreEqual(ExpectedResult, Result);

        }

        [TestMethod]
        public void LeapYearTrue()
        {
            int year = 2000;
            bool ExpectedResult = true;
            bool Result = Date.IsLeapYear(year);
            Assert.AreEqual(ExpectedResult, Result);

        }
        [TestMethod]

        public void IsLeapYearException()
        {

            int year = 20000;
            var Date = new Date();

            Action CheckIsLeapYear = () => Date.IsLeapYear(year);

            Assert.ThrowsException<ArgumentException>(CheckIsLeapYear);
        }

        [TestMethod]
        public void DatInAYear()
        {
            int year = 2000;
            int ExpectedResult = 366;
            int Result = Date.DaysInYear(year);
            Assert.AreEqual(ExpectedResult, Result);

        }

        [TestMethod]
        public void DayInAYear2()
        {
            int year = 2001;
            int ExpectedResult = 365;
            int Result = Date.DaysInYear(year);
            Assert.AreEqual(ExpectedResult, Result);

        }


        [TestMethod]

        public void DaysInAMonth()
        {
            int month = 2;
            int year = 2000;
            int ExpectedResult = 29;
            int Result = Date.DaysInMonth(month, year);
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]

        public void DaysInAMonth2()
        {
            int month = 3;
            int year = 2002;
            int ExpectedResult = 31;
            int Result = Date.DaysInMonth(month, year);
            Assert.AreEqual(ExpectedResult, Result);

        }

        [TestMethod]

        public void DaysInAMonth2Exception()
        {
            int month = 0;
            int year = 2000;
            var Date = new Date();

            Action CheckDaysInAMonth = () => Date.DaysInMonth(month, year);

            Assert.ThrowsException<ArgumentException>(CheckDaysInAMonth);

        }

        [TestMethod]

        public void GetDayNum()
        {
            int day = 7;
            int month = 3;
            int year = 2002;
            int ExpectedResult = 730931;
            int Result = Date.GetDayNum(day, month, year);
            Assert.AreEqual(ExpectedResult, Result);
        }


        [TestMethod]

        public void GetDayNumDayIsHigher()
        {
            int day = 32;
            int month = 3;
            int year = 2002;
            var Date = new Date();

            Action DayNumNumberofDaysIsAboveLimit = () => Date.GetDayNum(day, month, year);

            Assert.ThrowsException<ArgumentException>(DayNumNumberofDaysIsAboveLimit);
        }

        [TestMethod]

        public void GetDayNumDayIsHigherMonthIssue()
        {
            int day = 30;
            int month = 2;
            int year = 2002;
            var Date = new Date();

            Action DayNumNumberofDayInTheMonthsIsAboveLimit = () => Date.GetDayNum(day, month, year);

            Assert.ThrowsException<ArgumentException>(DayNumNumberofDayInTheMonthsIsAboveLimit);
        }


        [TestMethod]

        public void GetDayString()
        {
            int day = 1;
            string ExpectedResult = "1st";
            string Result = Date.GetDayString(day);
            Assert.AreEqual(ExpectedResult, Result);
        }


        [TestMethod]
        public void GetDayString1()
        {
            int day = 11;
            string ExpectedResult = "11th";
            string Result = Date.GetDayString(day);
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GetDayString2()
        {
            int day = 22;
            string ExpectedResult = "22nd";
            string Result = Date.GetDayString(day);
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GetDayString3()
        {
            int day = 23;
            string ExpectedResult = "23rd";
            string Result = Date.GetDayString(day);
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GetDayString4()
        {
            int day = 9;
            string ExpectedResult = "9th";
            string Result = Date.GetDayString(day);
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GetDayString5()
        {
            int day = 32;
            string ExpectedResult = "32nd";
            var Date = new Date();

            Action DayNumNumberofDaysIsAboveLimit = () => Date.GetDayString(day);

            Assert.ThrowsException<ArgumentException>(DayNumNumberofDaysIsAboveLimit);
        }

        [TestMethod]
        public void GetMonthString()
        {
            int month = 7;
            string ExpectedResult = "July";
            string Result = Date.GetMonthString(month);
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GetMonthString1()
        {
            int month = 13;
            string ExpectedResult = "SomtoMonth";
            var Date = new Date();

            Action NumIsAboveNumOfMonths = () => Date.GetMonthString(month);

            Assert.ThrowsException<ArgumentException>(NumIsAboveNumOfMonths);

        }

        [TestMethod]

        public void operatortest()
        {
            Date LHs = new Date();
            Date Rhs= new Date();
          
            bool expected = false;
            bool result = LHs < Rhs;
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void operatortest2()
        {
            Date LHs = new Date();
            Date Rhs = new Date();

            bool expected = false;
            bool result = LHs > Rhs;
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void operatortest3()
        {
            Date LHs = new Date();
            Date Rhs = new Date();

            bool expected = true;
            bool result = LHs <= Rhs;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest4()
        {
            Date LHs = new Date();
            Date Rhs = new Date();

            bool expected = true;
            bool result = LHs >= Rhs;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest5()
        {
            Date LHs = new Date();
            Date Rhs = new Date();

            bool expected = true;
            bool result = LHs == Rhs;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest6()
        {
            Date LHs = new Date();
            Date Rhs = new Date();

            bool expected = false;
            bool result = LHs != Rhs;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest7()
        {
            Date date = new Date();
            int value = 1;
         

            Date expected = date;
            Date result = date -= value;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest8()
        {
            Date date = new Date();
            int value = 1;

            Date expected = date;
            Date result = date += value;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest9()
        {
            Date date = new Date();
          
            Date expected = date;
            Date result = date++;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void operatortest10()
        {
            Date date = new Date();

            Date expected = date;
            Date result = date--;
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void settersTest()
        {
            Date d = new Date();
            d.DayNum = 10;

            Assert.AreEqual(10, d.DayNum);
        }


        [TestMethod]
        public void Equals()
        {
            object obj = new object();
            bool expected = false;
            bool result = Equals(obj);
            Assert.AreEqual(expected, result);
        }
        


            //[TestMethod]
            //public void DayNumToArray()
            //{
            //    int dayNumber = 1;
            //    int[] ExpectedResult = { 1, 1, 1 };
            //    int[] Result = Date.DayNumToArray(dayNumber);
            //    Assert.AreEqual(ExpectedResult, Result);
            //}

            //[TestMethod]
            //public void DayNumTostring()
            //{
            //    int month = 7;
            //    string ExpectedResult = "July";
            //    string Result = Date.GetMonthString(month);
            //    Assert.AreEqual(ExpectedResult, Result);
            //}



        }
}