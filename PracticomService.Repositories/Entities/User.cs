using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Repositories.Entities
{
    public enum EHMO
    {
        מכבי = 1, לאומית = 1, מאוחדת = 3, כללית = 4
    }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime BornDate { get; set; }
        public int GenderId { get; set; }
        public EHMO HMO { get; set; }
        public List<Child> Children { get; set; }
    }
}
