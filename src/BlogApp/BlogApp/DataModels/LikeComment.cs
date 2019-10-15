namespace BlogApp.DataModels
{
    public class LikeComment
    {
        public Comment Comment { get; set; }

        public int CommentId { get; set; }

        public BlogUser User { get; set; }

        public string UserId { get; set; }
    }
}
