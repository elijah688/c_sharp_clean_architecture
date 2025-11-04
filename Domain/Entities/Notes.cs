namespace Domain.Entities
{
    public class Note(string title, string content)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; private set; } = title;
        public string Content { get; private set; } = content;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; }

        public void Update(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
