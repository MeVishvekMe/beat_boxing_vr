using System;
using UnityEngine;

public class InitialSceneSetup : MonoBehaviour {

    public GameObject pLeft;
    public GameObject pRight;
    public GameObject pLeftLeft;
    public GameObject pRightRight;
    public GameObject pMiddle;
    public GameObject pMiddleMiddle;

    private void Start() {
        pLeft.transform.position = new Vector3(pLeft.transform.position.x, PlayerHeight.PlayerHeightValue - 0.2f,
            pLeft.transform.position.z);
        pRight.transform.position = new Vector3(pRight.transform.position.x, PlayerHeight.PlayerHeightValue - 0.2f,
            pRight.transform.position.z);
        pLeftLeft.transform.position = new Vector3(pLeftLeft.transform.position.x, PlayerHeight.PlayerHeightValue - 0.2f,
            pLeftLeft.transform.position.z);
        pRightRight.transform.position = new Vector3(pRightRight.transform.position.x, PlayerHeight.PlayerHeightValue - 0.2f,
            pRightRight.transform.position.z);
        pMiddle.transform.position = new Vector3(pMiddle.transform.position.x, PlayerHeight.PlayerHeightValue - 0.2f,
            pMiddle.transform.position.z);
        pMiddleMiddle.transform.position = new Vector3(pMiddleMiddle.transform.position.x, PlayerHeight.PlayerHeightValue - 0.4f,
            pMiddleMiddle.transform.position.z);
    }
}
