using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SelfieProject.WebApi.Models;
using SelfieProject.WebApi.Repositories;

namespace SelfieProject.WebApi.Services
{
    public class TextCamService
    {
        private readonly IVoteRepository _repository;
        private HttpClient client = new HttpClient();

        public TextCamService(IVoteRepository repository)
        {
            _repository = repository;
            client.BaseAddress = new Uri("http://txtcamapi.bldrdash.com");
        }

        internal async Task<List<TextCamImage>> GetAllAsync(int? cameraId)
        {
            List<TextCamImage> images = new List<TextCamImage>();
            var cameras = await _repository.GetCamerasAsync(cameraId);
            foreach(Camera camera in cameras)
            {
                var cameraImages = await GetCameraImagesAsync(camera);
                images.AddRange(cameraImages);
            }
            return images.OrderByDescending(i => i.DateTaken).ToList();
        }

        internal async Task<TextCamImage> GetImageAsync(Tuple<string, int> entry)
        {
            TextCamImage image = null;
            var camera =  _repository.GetCameraByCameraNameAsync(entry.Item1.Substring(0, 2));
            var imageId = entry.Item1.Substring(2);
            HttpResponseMessage response = await client.GetAsync($"/images/camera/{camera.Result.CameraId_API}/{imageId}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(jsonResult);
                JToken result = apiResponse["image"].Children().FirstOrDefault();
                image = result.ToObject<TextCamImage>();
                image.CameraId = camera.Id;
            }
            return image;
        }

        internal async Task<TextCamImage> GetImageByCameraNameImageIdAsync(string cameraName, string imageId)
        {
            var camera = await _repository.GetCameraByCameraNameAsync(cameraName);
            var images = await GetCameraImagesAsync(camera);
            return images.Where(i => i.Id == Convert.ToInt32(imageId)).FirstOrDefault();
        }

        internal async Task<List<TextCamImage>> GetCameraImagesAsync(Camera camera)
        {
            List<TextCamImage> camImages = new List<TextCamImage>();
            HttpResponseMessage response = await client.GetAsync($"/images/camera/{camera.CameraId_API}/vote");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                JObject apiResponse = JObject.Parse(jsonResult);
                IList<JToken> results = apiResponse["images"].Children().ToList();
                foreach(JToken result in results)
                {
                    TextCamImage image = result.ToObject<TextCamImage>();
                    image.CameraId = camera.Id;
                    camImages.Add(image);
                }
            }
            return camImages;
        }
    }
}
