﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kigg.Infrastructure.EF.POCO
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string UniqueName { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<UserTag> UserTags { get; set; }
        public ICollection<StoryTag> StoryTags { get; set; }
    }
}