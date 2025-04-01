using System;
using UnityEngine;
using System.Collections.Generic;

public class LevelSelectorHelper : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public static int selectedSongIndex = 2;
    public static List<SongTimestamps> songs = new List<SongTimestamps>();

    private void Start() {
        if (audioSource == null) {
            audioSource = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
        }
        
        songs.Add(GetComponent<DemoSongTimeStamps>());
        songs.Add(GetComponent<EasySongTimeStamps>());
        songs.Add(GetComponent<MediumSongTimeStamps>());
        songs.Add(GetComponent<HardSongTimeStamps>());
        
        audioSource.clip = audioClips[selectedSongIndex];
        audioSource.Play();
    }
}
