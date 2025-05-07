namespace TODOlist_forms.Models;

public class TodoTask
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public DateTime dateTime { get; set; }

    public User User { get; set; }
}
