using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<CategoryItem>();

    }

    public int CategoryId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get; set; }
  }
}
