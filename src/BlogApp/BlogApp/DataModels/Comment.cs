using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.DataModels
{
    public class Comment : BaseModel
    {
        public Comment()
        {
            this.CreatedOn = DateTime.Now;
            this.LikeComments = new List<LikeComment>();
            this.ChildComments = new List<Comment>();
        }

        public int? CommentId { get; set; }

        public Comment ParentComment { get; set; }

        public ICollection<Comment> ChildComments { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public BlogUser User { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "dd:MM:yyyy")]
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "dd:MM:yyyy")]
        [DataType(DataType.Date)]
        public DateTime UpdatedOn { get; set; }

        public int Likes { get; set; }

        public ICollection<LikeComment> LikeComments { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }
    }
}