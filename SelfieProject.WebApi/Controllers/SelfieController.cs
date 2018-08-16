using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfieProject.WebApi.Models;
using SelfieProject.WebApi.Repositories;
using SelfieProject.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SelfieProject.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SelfieController : ControllerBase
    {
        private readonly IVoteRepository _repository;
        private TextCamService _textCamService;
        private readonly ILogger _logger;

        public SelfieController(IVoteRepository repository, TextCamService textCamService, ILogger<SelfieController> logger)
        {
            _repository = repository;
            _textCamService = textCamService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Selfie>>> GetAllAsync()
        {
            Trace.WriteLine("Getting Images");
            List<TextCamImage> images = await _textCamService.GetAllAsync(null);
            IEnumerable<Tuple<string, int>> voteTallys = await _repository.GetVoteTallies();
            Trace.WriteLine("Creating Selfie List");
            List<Selfie> selfies = Selfie.CreateSelfieListAsync(images);
            foreach(Selfie selfie in selfies)
            {
                selfie.VoteTotal = voteTallys.Where(t => t.Item1 == selfie.SelfieId).FirstOrDefault()?.Item2 ?? 0;
            }
            return selfies;
        }

        [HttpGet("leaderboard/{cameraId:int?}")]
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