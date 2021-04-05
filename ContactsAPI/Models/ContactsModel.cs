using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ContactsAPI.Model
{
    [DataContract]
    public class ContactsModel
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string FirstName { get; set; }

        [Required]
        [DataMember]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [DataMember]
        public string Email { get; set; }

        [Required]
        [DataMember]
        public string PhoneNumber { get; set; }

        [Required]
        [DataMember]
        public bool Status { get; set; }
    }
}
