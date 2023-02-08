using PracticomService.Common.DTOs;

namespace PracticomService.WebAPI.Models
{
    public class UserPostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime BornDate { get; set; }
        public int GenderId { get; set; }
        public Ehmo HMO { get; set; }
        public List<ChildPostModel> Children { get; set; }
    }
}
