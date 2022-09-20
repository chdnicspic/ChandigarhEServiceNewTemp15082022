using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class SessionPortal
    {
        #region MY_Portal_User_Properties
        public string PortalUserId { get; set; }
        public string PortalUserMobile { get; set; }
        public string PortalUserEmail { get; set; }
        public DateTime? PortalUserRegisterDate { get; set; }
        
        public Int32 PortalUserLoginAttempt { get; set; }
        public string IPAddress { get; set; }
        public string PortalUserPassword { get; set; }
        public string PortalUserPassword1 { get; set; }
        public string PortalUserPassword2 { get; set; }
        public string PortalUserIsActive { get; set; }
        
        public DateTime? PortalUserLastSLogin { get; set; }
        public DateTime? PortalUserLastFLogin { get; set; }
        public DateTime? PortalUserActivationDate { get; set; }
        public string PortalUserIsVerified { get; set; }
        #endregion

        #region My_Administration_User_Properties
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public DateTime? UserDOB { get; set; }
        public string UserParentDept { get; set; }
        public string UserParentOffice { get; set; }
        public string UserMobile { get; set; }
        public DateTime? UserEntryDate { get; set; }
        public DateTime? UserDeActiveDate { get; set; }
        public string UserPassword { get; set; }
        public string LoginName { get; set; }
        public string UserIsActive { get; set; }
        public string UserEmailId { get; set; }
        public Int32 LoginAttempt { get; set; }
        
        public string UserIsDSCEnabled { get; set; }
        public string UserIsVerified { get; set; }
        public DateTime? UserActivationDate { get; set; }
        public DateTime? UserLastSLogin { get; set; }
        public DateTime? UserLastFLogin { get; set; }
        public string UserPassword1 { get; set; }
        public string UserPassword2 { get; set; }
        public string UserIpAddress { get; set; }
        public string DSCTHUMB { get; set; }
        public Int64 DSCId { get; set; }
        public string DSCSerialNumber { get; set; }
        public string UserRole { get; set; }
        public string UserWorkingOfficeName { get; set; }
        public string UserWorkingDeptName { get; set; }
        public string UserWorkingOfficeCode { get; set; }
        public string UserWorkingDeptCode { get; set; }
        public string ServiceOwnerOfficeName { get; set; }
        public string ServiceOwnerDeptName { get; set; }
	public string DSCEXP { get; set; }
	public Int32 WorkingUserDesignationCode { get; set; }
        public string WorkingUserDesignationName { get; set; }
        #endregion



        #region Misc_Property
        public DateTime? CurrentDate { get; set; }
        public String UserType { get; set; }
        #endregion

    }
}
