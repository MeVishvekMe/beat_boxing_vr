﻿using UnityEngine;


public abstract class SongTimestamps : MonoBehaviour {
    
    // Types of spawn boxes
    public GameObject singleHitBoxPrefab;
    public GameObject doubleHitBoxPrefab;
    public GameObject dodgeObject;
    public GameObject jumpObject;

    // Tutorial Objects
    public GameObject tutorialSingleLeftHitBoxPrefab;
    public GameObject tutorialSingleRightHitBoxPrefab;
    public GameObject tutorialDoubleHitBoxPrefab;
    public GameObject tutorialDodgeObject;
    public GameObject tutorialJumpObject;
    
    public Transform[] spawnPointsArray = new Transform[7];

    public abstract TimeStampDS[] ReturnTimeStampArray();
}
