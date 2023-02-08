using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Common.DTOs
{
    public class ChildDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornDate { get; set; }
        public string IdentityNumber { get; set; }

    }
}
