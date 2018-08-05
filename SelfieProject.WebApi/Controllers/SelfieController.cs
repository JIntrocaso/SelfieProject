using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfieProject.WebApi.Models;
using SelfieProject.WebApi.Repositories;
using SelfieProject.WebApi.Services;

namespace SelfieProject.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SelfieController : ControllerBase
    {
        private readonly IVoteRepository _repository;
        private TextCamService _textCamService;

        public SelfieController(IVoteRepository repository, TextCamService textCamService)
        {
            _repository = repository;
            _textCamService = textCamService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Selfie>>> GetAllAsync()
        {
            List<TextCamImage> images = await _textCamService.GetAllAsync(null);
            IEnumerable<Tuple<string, int>> voteTallys = await _repository.GetVoteTallies();
            List<Selfie> selfies = Selfie.CreateSelfieListAsync(images);
            foreach(Selfie selfie in selfies)
            {
                selfie.VoteTotal = voteTallys.Where(t => t.Item1 == selfie.SelfieId).FirstOrDefault()?.Item2 ?? 0;
            }
            return selfies;
        }

        [HttpGet("leaderboard/{cameraId}")]
        public async Task<ActionResult<List<Selfie>>> GetTopSelfiesAsync(int? cameraId)
        {
            var topVoteEntries = _repository.GetTopEntriesAsync(5, cameraId);
            List<Selfie> topImages = new List<Selfie>();
            foreach(var entry in await topVoteEntries)
            {
                TextCamImage image = await _textCamService.GetImageAsync(entry);
                topImages.Add(new Selfie(image));
            }
            return topImages;
        }

    }
}