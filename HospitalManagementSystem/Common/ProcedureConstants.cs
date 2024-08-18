using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Common
{
    public class ProcedureConstants
    {
        #region User

        public static string SP_LoginByUserNameAndPassword = "SP_LoginByUserNameAndPassword";
        public static string SP_GetAllUserComboData = "SP_GetAllUserComboData";
        public static string SP_GetAllUserData = "SP_GetAllUserData";
        public static string SP_SaveUserData = "SP_SaveUserData";
        public static string SP_UpdateUserData = "SP_UpdateUserData";
        public static string SP_DeleteUserData = "SP_DeleteUserData";

        #endregion

        #region Registration

        public static string SP_GetAllRegistrationComboData = "SP_GetAllRegistrationComboData";
        public static string SP_SaveRegistration = "SP_SaveRegistration";
        public static string SP_GetAllRegistrationData = "SP_GetAllRegistrationData";
        public static string SP_UpdateRegistration = "SP_UpdateRegistration";
        public static string SP_DeleteRegistration = "SP_DeleteRegistration";

        #endregion

        #region Doctor

        public static string SP_SaveDoctorData = "SP_SaveDoctorData";
        public static string SP_GetAllDoctorData = "SP_GetAllDoctorData";
        public static string SP_UpdateDoctorData = "SP_UpdateDoctorData";
        public static string SP_DeleteDoctorData = "SP_DeleteDoctorData";
        public static string SP_GetSpecialityComboData = "SP_GetSpecialityComboData";

        #endregion

        #region NameType

        public static string SP_GetAllNameType = "SP_GetAllNameType";
        public static string SP_SaveNameType = "SP_SaveNameType";
        public static string SP_UpdateNameType = "SP_UpdateNameType";
        public static string SP_DeleteNameType = "SP_DeleteNameType";

        #endregion

        #region MaritalStatus

        public static string SP_GetAllMaritalStatus = "SP_GetAllMaritalStatus";
        public static string SP_SaveMaritalStatus = "SP_SaveMaritalStatus";
        public static string SP_UpdateMaritalStatus = "SP_UpdateMaritalStatus";
        public static string SP_DeleteMaritalStatus = "SP_DeleteMaritalStatus";

        #endregion

        #region Speciality

        public static string SP_GetAllSpeciality = "SP_GetAllSpeciality";
        public static string SP_SaveSpeciality = "SP_SaveSpeciality";
        public static string SP_UpdateSpeciality = "SP_UpdateSpeciality";
        public static string SP_DeleteSpeciality = "SP_DeleteSpeciality";

        #endregion

        #region Booking

        public static string SP_GetAllBookingComboData = "SP_GetAllBookingComboData";
        public static string SP_GetAllBookingData = "SP_GetAllBookingData";
        public static string SP_SaveBooking = "SP_SaveBooking";
        public static string SP_UpdateBooking = "SP_UpdateBooking";
        public static string SP_UpdateBookingStatus = "SP_UpdateBookingStatus";
        public static string SP_DeleteBooking = "SP_DeleteBooking";

        #endregion

        #region Menu

        public static string SP_GetAllMenuByRoleId = "SP_GetAllMenuByRoleId ";

        #endregion
    }
}
