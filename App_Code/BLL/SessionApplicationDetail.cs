using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class SessionApplicationDetail
    {

        public string ApplicationNo { get; set; }
        public int CurrentlevelNo { get; set; }
        public string Authority { get; set; }
        public string pendingWith { get; set; }
        public string MarkFrom { get; set; }
        public string CanGenerateNotice { get; set; }
        public string Service { get; set; }
        public string SubService { get; set; }
        public string ISLevelDscEnabled { get; set; }
        public int NumberOfNoticeNotReplied { get; set; }
        public int TotalNoticeGenerated { get; set; }
        public string ApplicantMobileNo { get; set; }
        public string ApplicantEmail { get; set; }
        public string ServiceFullName { get; set; }

    }
}
