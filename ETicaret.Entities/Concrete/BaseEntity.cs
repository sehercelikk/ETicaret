namespace ETicaret.Entities.Concrete;

public class BaseEntity
{
    public string Id { get; set; }=Guid.NewGuid().ToString();
    public DateTime CreateDate { get; set; }
    public DateTime DeleteDate { get; set; }
    public bool IsActive { get; set; } = true;
}
