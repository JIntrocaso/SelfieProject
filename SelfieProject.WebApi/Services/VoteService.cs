using SelfieProject.WebApi.Models;
using SelfieProject.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieProject.WebApi.Services
{
    public class VoteService
    {
        private readonly IVoteRepository _repository;
        private TextCamService _textCamService;

        public VoteService(IVoteRepository repository, TextCamService textCamService)
        {
            _repository = repository;
            _textCamService = textCamService;
        }

        public bool IsSpecialCommand(string message)
        {
            bool result = false;
            // todo: if we get to pushing cool images to webpage this is useful
            return result;
        }

        public async Task<bool> PhoneNumberHasVotedToday(string phoneNumber)
        {
            bool result = false;
            var voteEntries = await _repository.GetVoteEntriesForPhoneNumberAsync(phoneNumber);
            if (voteEntries.Any(e => e.VoteDate.Date == DateTime.Now.Date))
            {
                result = true;
            }
            return result;
        }

        internal async Task<Camera> GetCameraFromMessageBody(string message)
        {
            return await _repository.GetCameraByCameraNameAsync(message.Substring(0, 2));
        }

        internal async Task<bool> ValidateVoteMessageAsync(string body)
        {
            bool result = true;
            if (GetCameraFromMessageBody(body).Result == null)
            {
                result = false;
            }
            else if ((await _textCamService.GetImageByCameraNameImageIdAsync(body.Substring(0, 2), body.Substring(2))) == null)
            {
                result = false;
            }
            return result;
        }
    }
}
