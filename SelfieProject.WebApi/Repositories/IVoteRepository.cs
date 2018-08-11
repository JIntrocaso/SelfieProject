using SelfieProject.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieProject.WebApi.Repositories
{
    public interface IVoteRepository
    {
        Task<int> GetVoteTallyAsync(string selfieId);
        Task<IEnumerable<Tuple<string, int>>> GetTopEntriesAsync(int topX, int? camId);
        Task<IEnumerable<Tuple<string, int>>> GetVoteTallies();
        Task<List<Selfie>> CreateSelfieListAsync(IEnumerable<TextCamImage> images, int cameraId);
        Task<Camera> GetCameraByCameraNameAsync(string cameraName);
        Task<Camera> GetCameraByCameraAbbreviationAsync(string cameraId);
        Task<List<Camera>> GetCamerasAsync(int? cameraId);
        Task<IEnumerable<VoteEntry>> GetVoteEntriesForPhoneNumberAsync(string phoneNumber);
        void AddAsync(VoteEntry entry);
        void SaveAsync();
    }

}
