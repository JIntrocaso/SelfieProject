using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieProject.WebApi.Models
{
    public class VoteEntry
    {
        public int Id { get; set; }

        public int ImageId { get; set; }

        public int? CameraId { get; set; }

        public DateTime VoteDate { get; set; }

        public string VoteMessage { get; set; }
    }
}
