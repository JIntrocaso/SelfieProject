﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfieProject.WebApi.Models;
using SelfieProject.WebApi.Repositories;
using SelfieProject.WebApi.Services;
using System.Threading.Tasks;
using Twilio.TwiML;

namespace SelfieProject.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class VoteController : ControllerBase
    {
        private readonly VoteService _voteService;
        private readonly IVoteRepository _repository;
        private readonly ILogger _logger;
        private string textResponse;
        const string messageEnding = " Thank you for visiting theClubhou.se tent at Arts In The Heart of Augusta!";

        public VoteController(VoteService voteService, IVoteRepository repository, ILogger<VoteController> logger)
        {
            _voteService = voteService;
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Index(string body, string from)
        {
            try
            {
                string incomingMessage = body;
                var responseMessage = new MessagingResponse();
                if (!_voteService.IsSpecialCommand(body))
                {
                    if (await _voteService.PhoneNumberHasVotedToday(from))
                    {
                        _logger.LogWarning("Phone number has voted today.");
                        textResponse = responseMessage.Message($"You have already voted today. Please vote again tomorrow. {messageEnding}").ToString();
                    }
                    else
                    {
                        _logger.LogWarning("Phone number did not vote today.");
                        bool isValidMessage = await _voteService.ValidateVoteMessageAsync(incomingMessage);
                        if (!isValidMessage)
                        {
                            textResponse = responseMessage.Message($"This is an invalid vote. Please check the entry ID and try again. {messageEnding}").ToString();
                        }
                        else
                        {
                            _logger.LogWarning("Getting camera by camera name");
                            Camera camera = await _voteService.GetCameraByCameraName(incomingMessage.Substring(0, 2).ToUpper());
                            _logger.LogWarning("Creating vote entry object");
                            VoteEntry voteEntry = VoteEntry.CreateEntry(incomingMessage, from, camera);
                            _repository.AddAsync(voteEntry);
                            _logger.LogWarning("Saving vote entry object");
                            _repository.SaveAsync();
                            _logger.LogWarning("Creating response message");

                            textResponse = responseMessage.Message($"Your vote is in!!. You may only vote once per day. {messageEnding}").ToString();
                        }
                    }
                }
                else
                {

                }
                return Content(textResponse, "application/xml");
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
