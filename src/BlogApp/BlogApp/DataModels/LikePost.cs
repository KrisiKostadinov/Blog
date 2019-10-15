namespace BlogApp.DataModels
{
    public class LikePost
    {
        public virtual Post Post { get; set; }

        public int PostId { get; set; }

        public virtual BlogUser User { get; set; }

        public string UserId { get; set; }
    }
}
