namespace SearchEngine.Models
{
    public class StoredLibraryModel
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? DateAdded { get; set; }
        public DateTime? LastEdited { get; set; }
        public bool? Isactive { get; set; }
        public string? Link { get; set; }
    }
}
