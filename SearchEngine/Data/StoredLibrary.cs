using System;
using System.Collections.Generic;

namespace SearchEngine.Data
{
    public partial class StoredLibrary
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? DateAdded { get; set; }
        public DateTime? LastEdited { get; set; }
        public bool? Isactive { get; set; }
        public string? Link { get; set; }
    }
}
