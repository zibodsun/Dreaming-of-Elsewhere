using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    public List<AudioSource> playlist = new List<AudioSource>();
    public int currSongIndex;
    public float volume = 0.4f;
    private bool isPaused;

    void Start()
    {
        isPaused = false;
    }

    public void nextSong() {
        if (isPaused)               // return if song is paused
        {            
            return;
        }

        if (playlist.Count == 0)    // return if playlist has no songs
        { 
            return;
        }

        playlist[currSongIndex].volume = 0;
        currSongIndex = (currSongIndex + 1) % playlist.Count; // loop around playlist
        playlist[currSongIndex].volume = volume;
    }

    public void togglePauseSong() {
        // toggle pause/play
        if (isPaused)
        {
            playlist[currSongIndex].Play();
            isPaused = false;
        }
        else {
            playlist[currSongIndex].Pause();
            isPaused = true;
        }
    }
}
