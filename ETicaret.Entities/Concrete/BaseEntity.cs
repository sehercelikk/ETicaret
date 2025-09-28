namespace ETicaret.Entities.Concrete;

public class BaseEntity
{
    public string Id { get; set; }=Guid.NewGuid().ToString();
    public DateTime CreateDate { get; set; }=DateTime.Now;
    public DateTime DeleteDate { get; set; }
    public bool IsActive { get; set; } = true;
}
