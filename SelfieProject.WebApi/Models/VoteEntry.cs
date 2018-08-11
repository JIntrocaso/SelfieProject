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

        public string VoterPhoneNumber { get; set; }

        internal static VoteEntry CreateEntry(string body, string from, Camera camera)
        {
            VoteEntry voteEntry = new VoteEntry
            {
                CameraId = camera.Id,
                ImageId = Convert.ToInt32(body.Substring(2)),
                VoteDate = DateTime.Now,
                VoteMessage = body,
                VoterPhoneNumber = from
            };
            return voteEntry;
        }
    }
}
