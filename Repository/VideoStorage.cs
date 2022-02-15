using Automated_Car_Wash.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Automated_Car_Wash.Repository
{
    public class VideoStorage
    {
        private readonly Dictionary<int, Video> _Videos = new();

        public Video Create(Video video)
        {

            _Videos.Add(video.VideoId, video);
            return video;

        }

        public Video Read(int VideoId)
        {
            return _Videos[VideoId];
        }

        public Video Update(int VideoId, Video newVideo)
        {
            _Videos[VideoId] = newVideo;
            return _Videos[VideoId];
        }

        public bool Delete(int VideoId)
        {
            return _Videos.Remove(VideoId);
        }
    }
}