using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusCaseReportFormApp.Models
{
    public class Form1
    {
        string OSAUseOnly{ get; set; }
        string StudentName { get; set; }
        string StudentID { get; set; }
        string StudentEmail { get; set; }
        string FacultyMemberName { get; set; }
        DateTime Date { get; set; }
        string Course { get; set; }
        string Assignment { get; set; }
        string Department { get; set; }
        string Term { get; set; }
        string ViolatedDescription { get; set; }
        bool IsSupportPersonChecked { get; set; }
        bool IsWritenStatementChecked { get; set; }
        string Signature { get; set; }
        string SignName { get; set; }
        string SignDate { get; set; }

    }
}
