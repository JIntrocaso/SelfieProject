using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfieProject.WebApi.Models
{
    public class Selfie
    {

        public Selfie()
        {

        }

        public Selfie(TextCamImage image)
        {
            ImageId = image.Id;
            DateTaken = image.DateTaken;
            ImageThumbnailUrl = image.ThumbnailUrl;
            ImageUrl = image.Url;
            CameraName = image.Camera.CameraName;
        }

        public int ImageId { get; set; }

        public string CameraName { get; set; }

        public int VoteTotal { get; set; }

        public DateTime DateTaken { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public string ImageUrl { get; set; }

        public string SelfieId
        {
            get
            {
                return CameraName + ImageId.ToString();
            }
        }

        internal static List<Selfie> CreateSelfieListAsync(IEnumerable<TextCamImage> images)
        {
            List<Selfie> list = new List<Selfie>();
            foreach (TextCamImage image in images)
            {
                list.Add(new Selfie(image));
            }
            return list;
        }

    }
}
