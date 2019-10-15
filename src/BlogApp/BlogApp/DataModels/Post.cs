using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.DataModels
{
    public class Post : BaseModel
    {
        public Post()
        {
            this.CreatedOf = DateTime.Now;
            this.LikePosts = new List<LikePost>();
        }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "dd:MM:yyyy")]
        [DataType(DataType.Date)]
        public DateTime CreatedOf { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "dd:MM:yyyy")]
        [DataType(DataType.Date)]
        public DateTime UpdatedOf { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public BlogUser Author { get; set; }

        public string AuthorId { get; set; }

        public BlogUser Publisher { get; set; }

        public string PublisherId { get; set; }

        public int ReadingMinutes { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<LikePost> LikePosts { get; set; }
    }
}
