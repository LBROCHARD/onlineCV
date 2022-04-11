using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;
    public VideoPlayer videoEmissionPlayer;
    public string videoName;
    
    void Start()
    {
        myVideoPlayer.url  = System.IO.Path.Combine (Application.streamingAssetsPath, videoName );
        myVideoPlayer.Play();
        videoEmissionPlayer.url  = System.IO.Path.Combine (Application.streamingAssetsPath, videoName );
        videoEmissionPlayer.Play();
    }
}
