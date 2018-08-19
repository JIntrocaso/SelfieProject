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

        internal async Task<Camera> GetCameraByCameraName(string cameraName)
        {
            return await _repository.GetCameraByCameraNameAsync(cameraName);
        }

        internal async Task<bool> ValidateVoteMessageAsync(string body)
        {
            if (_repository.GetCameraByCameraNameAsync(body.Substring(0, 2)) == null)
            {
                return false;
            }
            else if ((await _textCamService.GetImageByCameraNameImageIdAsync(body.Substring(0, 2), body.Substring(2))) == null)
            {
                return false;
            }
            return true;
        }
    }
}
