namespace OutdoorStroe.API.Models
{
    public class User
    {
        public User(int id, string name, string email, string passwordHash, DateTime createdAt, DateTime? updatedAt, ICollection<Post>? posts)
        {
            Id = id;
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Posts = posts;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}
