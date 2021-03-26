using System;
using System.Collections.Generic;
using System.Text;

namespace MSCA_Uni
{
    enum monthofadmission {Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec};
    enum acdMajor {Engineering=1, SocialScience, Business, Communication, PreLaw};

    struct Student
    {
        public int studID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public monthofadmission joinMonth { get; set; }
        public acdMajor studMajor { get; set; }
        public string grade { get; set; }

        public Student (int stID, string fName, string lName, string addr, monthofadmission m, acdMajor a, string grade)
        {
            this.studID = stID;
            this.firstName = fName;
            this.lastName = lName;
            this.address = addr;
            this.joinMonth = m;
            this.studMajor = a;
            this.grade = grade;
        }

    }
}
