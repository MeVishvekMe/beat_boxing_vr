using System.Collections;
using UnityEngine;

public class TutorialObjectScript : MonoBehaviour {
    private void Start() {
        StartCoroutine(CheckForStopPosition());
    }

    IEnumerator CheckForStopPosition() {
        while (true) {
            if (transform.position.z <= -7.4f) {
                GameStateHandler.TutorialPause();
                break;
            }
            yield return null;
        }
    }
}
