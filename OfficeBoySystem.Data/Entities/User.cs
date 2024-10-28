
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace OfficeBoySystem.Data.Entities
{
    public class User: IdentityUser
    {
       
        public string FirstNameAr { get; set; }
        public string LastNameAr { get; set; }

        public string FirstNameEn { get; set; }

        public string LastNameEn { get; set; }

        public string PhoneNumber { get; set; }

        
       

        public int ShiftId { get; set; }
        public int LocationId { get; set; }
        public int UserTypeId { get; set; }

        //Navigation prop
        

    }
}
