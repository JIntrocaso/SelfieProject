using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieProject.WebApi.Models
{
    public class TextCamImage
    {
        public TextCamImage()
        {

        }

        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateTaken { get; set; }

        public string ThumbnailUrl { get; set; }

        public string Url { get; set; }

        public Camera Camera { get; set; }

    }
}
