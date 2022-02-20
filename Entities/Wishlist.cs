using System;
using System.Collections.Generic;

#nullable disable

namespace MySQL_Database_Generator.Entities
{
    public partial class Wishlist
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
