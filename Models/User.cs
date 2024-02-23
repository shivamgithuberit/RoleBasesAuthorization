using System.ComponentModel.DataAnnotations;

namespace RoleBasesAuthorization.Models
{
    public class User
    {
        


            [Key]
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Email { get; set; }
            public long? salary { get; set; }

            public string? DateOfBirth { get; set; }

            public string? Department { get; set; }



        
    }
}
