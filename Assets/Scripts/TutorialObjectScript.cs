using System;
using System.Collections;
using UnityEngine;

public class TutorialObjectScript : MonoBehaviour {
    private void Start() {
        StartCoroutine(CheckForStopPosition());
    }

    IEnumerator CheckForStopPosition() {
        while (true) {
            if (transform.position.z <= -7.3f) {
                GameStateHandler.GamePause();
                break;
            }
            yield return null;
        }
    }
}
