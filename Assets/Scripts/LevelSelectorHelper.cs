using System;
using UnityEngine;
using System.Collections.Generic;

public class LevelSelectorHelper : MonoBehaviour {
    public AudioClip[] audioClips;
    public static int selectedSongIndex = 0;
    public static List<SongTimestamps> songs = new List<SongTimestamps>();

    private void Start() {
        songs.Add(GetComponent<DemoSongTimeStamps>());
    }
}
