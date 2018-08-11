using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SelfieProject.WebApi.Models;

namespace SelfieProject.WebApi.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        private readonly VoteContext _context;

        public VoteRepository(VoteContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Tuple<string, int>>> GetTopEntriesAsync(int topX, int? camId)
        {
            var result = _context.VoteEntries.Where(e => e.CameraId != null).GroupBy(e => e.VoteMessage).Select(g => new Tuple<string, int>(g.Key, g.Count())).OrderBy(t => t.Item2).Take(topX).ToListAsync();
            return await result;
        }

        public Task<int> GetVoteTallyAsync(string selfieId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Selfie>> CreateSelfieListAsync(IEnumerable<TextCamImage> images, int cameraId)
        {
            List<Selfie> list = new List<Selfie>();
            foreach (TextCamImage image in images)
            {
                Selfie selfie = new Selfie(image)
                {
                    VoteTotal = await _context.VoteEntries.Where(e => e.ImageId == image.Id && e.CameraId == image.CameraId).CountAsync()
                };
                list.Add(new Selfie(image));
            }
            return list;
        }

        public async Task<Camera> GetCameraByCameraNameAsync(string cameraName)
        {
            return await _context.Cameras.Where(c => c.CameraName == cameraName).FirstOrDefaultAsync();
        }

        public async Task<Camera> GetCameraByCameraAbbreviationAsync(string cameraId_api)
        {
            return await _context.Cameras.Where(c => c.CameraId_API == cameraId_api).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Tuple<string, int>>> GetVoteTallies()
        {
            return await _context.VoteEntries.GroupBy(e => e.VoteMessage).Select(g => new Tuple<string, int>(g.Key, g.Count())).ToListAsync();
        }

        public async Task<List<Camera>> GetCamerasAsync(int? cameraId)
        {
            return await _context.Cameras.Where(c => cameraId == null || c.Id == cameraId).ToListAsync();
        }

        public async Task<IEnumerable<VoteEntry>> GetVoteEntriesForPhoneNumberAsync(string phoneNumber)
        {
            return await _context.VoteEntries.Where(e => e.VoterPhoneNumber == phoneNumber).ToListAsync();
        }

        public void AddAsync(VoteEntry entry)
        {
            _context.VoteEntries.AddAsync(entry);
        }

        public void SaveAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
