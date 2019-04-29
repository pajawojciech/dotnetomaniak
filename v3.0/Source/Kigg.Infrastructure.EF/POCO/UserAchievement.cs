﻿namespace Kigg.Infrastructure.EF.POCO
{
    public class UserAchievement
    {
        public System.DateTime DateAchieved { get; set; }

        public System.Guid AchievementId { get; set; }
        public Achievement Achievement { get; set; }

        public System.Guid UserId { get; set; }
        public User User { get; set; }

        public bool Displayed { get; set; }
    }
}