using System.Collections.Generic;

namespace BlogApp.DataModels
{
    public class Category : BaseModel
    {
        public Category()
        {
            this.Posts = new List<Post>();
        }

        public string Title { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
