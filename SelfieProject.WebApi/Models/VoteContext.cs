using Microsoft.EntityFrameworkCore;
using System;

namespace SelfieProject.WebApi.Models
{
    public class VoteContext : DbContext
    {
        public VoteContext(DbContextOptions<VoteContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Camera>().HasData(
                new Camera { Id = 1, CameraId_API = "10000", CameraName = "AR" },
                new Camera { Id = 2, CameraId_API = "20000", CameraName = "MI" },
                new Camera { Id = 3, CameraId_API = "30000", CameraName = "SF" }
            );

            builder.Entity<VoteEntry>().HasData(
                new VoteEntry { Id = 1, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 2, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 3, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 4, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 5, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 6, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 7, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 8, ImageId = 305, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR305" },
                new VoteEntry { Id = 9, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 10, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 11, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 12, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 13, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 14, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 15, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 16, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 17, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 18, ImageId = 307, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR307" },
                new VoteEntry { Id = 19, ImageId = 309, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR309" },
                new VoteEntry { Id = 20, ImageId = 309, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR309" },
                new VoteEntry { Id = 21, ImageId = 309, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR309" },
                new VoteEntry { Id = 22, ImageId = 309, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR309" },
                new VoteEntry { Id = 23, ImageId = 309, CameraId = 1, VoteDate = DateTime.Now.AddMinutes(-10), VoteMessage = "AR309" }
            );
        }

        public DbSet<VoteEntry> VoteEntries { get; set; }
        public DbSet<Camera> Cameras { get; set; }
    }
}
