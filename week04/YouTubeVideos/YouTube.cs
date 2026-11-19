public class YouTube
{
    List<Video> _videos;

    public YouTube()
    {
        _videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void DisplayVideo()
    {
        Console.WriteLine(" ");
        foreach (Video video in _videos)
        {
            Console.WriteLine(" ");
            video.DisplayVid();
            video.DisplayComment();
        }
    }
}