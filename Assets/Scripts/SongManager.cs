using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    public List<AudioSource> playlist = new List<AudioSource>();
    public int currSongIndex;

    void Update()
    {

    }

    public void previousSong() {
        if (playlist.Count == 0) {
            return;
        }
        playlist[currSongIndex].gameObject.SetActive(false);
        currSongIndex = currSongIndex - 1;
        playlist[currSongIndex].gameObject.SetActive(true);
    }
}
