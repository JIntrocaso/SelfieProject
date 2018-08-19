using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfieProject.WebApi.Filters;
using SelfieProject.WebApi.Models;
using SelfieProject.WebApi.Repositories;
using SelfieProject.WebApi.Services;
using System.Threading.Tasks;
using Twilio.TwiML;

namespace SelfieProject.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("text/xml")]
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
        public async Task<IActionResult> Index()
        {
            try
            {
                string body = Request.Form["Body"];
                string from = Request.Form["From"];
                _logger.LogWarning(body + " | " + body.Substring(0, 2));
                var responseMessage = new MessagingResponse();
                if (!_voteService.IsSpecialCommand(body))
                {
                    if (await _voteService.PhoneNumberHasVotedToday(from))
                    {
                        textResponse = responseMessage.Message($"You have already voted today. Please vote again tomorrow. {messageEnding}").ToString();
                    }
                    else
                    {
                        bool isValidMessage = await _voteService.ValidateVoteMessageAsync(body);
                        if (!isValidMessage)
                        {
                            textResponse = responseMessage.Message($"This is an invalid vote. Please check the entry ID and try again. {messageEnding}").ToString();
                        }
                        else
                        {
                            Camera camera = await _voteService.GetCameraByCameraName(body.Substring(0, 2).ToUpper());
                            VoteEntry voteEntry = VoteEntry.CreateEntry(body, from, camera);
                            _repository.AddAsync(voteEntry);
                            _repository.SaveAsync();

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
