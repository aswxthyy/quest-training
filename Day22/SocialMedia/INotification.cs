namespace SocialMedia
{
    public interface INotification
    {
         public void Notification(string notification);
    }

    public interface ILike : INotification
    {
        public void Notification(string notification);
        
        public void LikeNotif(string username);
    }

    public interface IComment : INotification
    {
        public void Notification(string notification);
        
        public void CommentNotif(string username, string comment);
    }

    public interface IFollow : INotification
    {
        public void Notification(string notification);
        
        public void FollowNotif(string username);
    }

    
}