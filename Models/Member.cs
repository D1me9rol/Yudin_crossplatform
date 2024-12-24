using System;
using System.Collections.Generic;

namespace Yudin_back.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime MembershipSince { get; set; }
        public List<int> BorrowedBookIds { get; set; } = new List<int>();
    }
}