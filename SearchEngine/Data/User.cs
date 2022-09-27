using System;
using System.Collections.Generic;

namespace SearchEngine.Data
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
