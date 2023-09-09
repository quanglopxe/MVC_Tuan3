using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai1_B.Models
{
    public class Information
    {
        public string FullName { get; set; }
        public string IdStudent { get; set; }
        public string Email { get; set; }
        public string FileImage { get; set; }
        public string Note { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
        public string ChooseWorkTime { get; set; }
        public int SelectCourse { get; set; }
        public Information():this("Duong Thuan Quang",123,"quanglopxe@gmail.com","","",true,true,false,)
        { }
        public Information(string FullName, string IdStudent, string Email, string FileImage, string Note, bool Check1, bool Check2, bool Check3, string ChooseWorkTime, int SelectCourse)
        {

        }
    }
}