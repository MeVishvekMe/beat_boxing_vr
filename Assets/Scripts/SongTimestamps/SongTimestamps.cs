using UnityEngine;

public abstract class SongTimestamps : MonoBehaviour {
    
    // Object references from ObjectReferencesTimeStampDS
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

    public ObjectReferencesTimeStampDS objectReferencesTimeStampDS;

    // Automatically called when the GameObject is created
    protected virtual void Awake() {
        objectReferencesTimeStampDS = GetComponent<ObjectReferencesTimeStampDS>();

        if (objectReferencesTimeStampDS == null) {
            Debug.LogError("ObjectReferencesTimeStampDS component is missing from this GameObject!");
            return;
        }

        // Assign references from ObjectReferencesTimeStampDS
        singleHitBoxPrefab = objectReferencesTimeStampDS.singleHitBoxPrefab;
        doubleHitBoxPrefab = objectReferencesTimeStampDS.doubleHitBoxPrefab;
        dodgeObject = objectReferencesTimeStampDS.dodgeObject;
        jumpObject = objectReferencesTimeStampDS.jumpObject;
        tutorialSingleLeftHitBoxPrefab = objectReferencesTimeStampDS.tutorialSingleLeftHitBoxPrefab;
        tutorialSingleRightHitBoxPrefab = objectReferencesTimeStampDS.tutorialSingleRightHitBoxPrefab;
        tutorialDoubleHitBoxPrefab = objectReferencesTimeStampDS.tutorialDoubleHitBoxPrefab;
        tutorialDodgeObject = objectReferencesTimeStampDS.tutorialDodgeObject;
        tutorialJumpObject = objectReferencesTimeStampDS.tutorialJumpObject;
        spawnPointsArray = objectReferencesTimeStampDS.spawnPointsArray;
    }

    public abstract TimeStampDS[] ReturnTimeStampArray();
}