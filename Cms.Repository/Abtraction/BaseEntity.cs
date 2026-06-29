namespace Cms.Repository.Abtraction;

public abstract class BaseEntity<Tkey>
{
    public Tkey Id { get; set; } = default!;
    public bool IsDeleted { get; set; }
}
