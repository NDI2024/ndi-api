namespace NoteTonRu.Api.Domain.Entities.Interfaces;

public class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTimeOffset.Now;
        UpdatedAt = DateTimeOffset.Now;
    }
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}