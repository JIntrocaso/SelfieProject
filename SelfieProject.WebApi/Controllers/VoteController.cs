using Microsoft.AspNetCore.Mvc;
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
        private string textResponse;
        const string messageEnding = " Thank you for visiting theClubhou.se tent at Arts In The Heart of Augusta!";

        public VoteController(VoteService voteService, IVoteRepository repository)
        {
            _voteService = voteService;
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Index(string body, string from)
        {
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
                        Camera camera = await _voteService.GetCameraFromMessageBody(body.Substring(0, 2));
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
            return Content(textResponse, "text/xml");
        }
    }
}
