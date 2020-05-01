using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Person
    {

        private static int personCount = 1;
        #region Variables
        private string myName;
        private int personId;
        private string myGender;
        private double testResult;

        #endregion

        #region Properties
        public string MyName
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }
        public int PersonId
        {
            get
            {
                return personId;
            }
            set
            {
                personId = value;
            }
        }
        public string MyGender
        {
            get
            {
                return myGender;
            }
            set
            {
                myGender = value;
            }
        }
        public double TestResult
        {
            get
            {
                return testResult;
            }
            set
            {
                testResult = value;
            }
        }

        #endregion


        #region Constructor
        public Person(string myname, double testresult)
        {
            this.MyName = myname;
            this.TestResult = testresult;
            this.PersonId = personCount++;

        }
        #endregion

        public string getName()
        {
            return this.MyName;
        }
        public int getPeronId()
        {
            return this.PersonId;
        }
        // Method return test results
        public double takeTest()
        {
            return this.TestResult;
        }
        // This method returns the student's test results
        public String toString()
        {
            return this.MyName + " " + this.TestResult;
        }

        public abstract string personStatus();
    }
}
