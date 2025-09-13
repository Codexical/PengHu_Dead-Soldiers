using UnityEngine;
using UnityEngine.Video;
public class Videoplayer : MonoBehaviour
{
    [SerializeField] private GameObject videoPlayerObject;
    [SerializeField] private GameObject Background;
    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject WatchVideoButton;
    [SerializeField] private GameObject BackButton;
    private VideoPlayer videoPlayer;
    private bool isPlaying = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        videoPlayer = videoPlayerObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        

    }
    void OnEnable()
    {
        BackButton.SetActive(false);
        Background.SetActive(true);
        StartButton.SetActive(true);
        WatchVideoButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (videoPlayer.frame >= (long)videoPlayer.frameCount - 1 && isPlaying)
        {
            StopVideo();
        }
    }
    public void PlayVideo()
    {
        Background.SetActive(false);
        StartButton.SetActive(false);
        BackButton.SetActive(true);
        WatchVideoButton.SetActive(false);
        videoPlayer.Play();
        isPlaying = true;
    }
    public void StopVideo()
    {
        Background.SetActive(true);
        StartButton.SetActive(true);
        BackButton.SetActive(false);
        WatchVideoButton.SetActive(true);
        videoPlayer.Stop();
        isPlaying = false;
    }
}
