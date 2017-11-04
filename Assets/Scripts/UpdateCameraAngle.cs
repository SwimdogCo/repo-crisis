using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCameraAngle : MonoBehaviour {

    public GameObject NewCameraPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (NewCameraPosition != null && other.CompareTag("Player"))
        {
            var mainCam = Camera.main;
            mainCam.transform.position = NewCameraPosition.transform.position;
            mainCam.transform.rotation = NewCameraPosition.transform.rotation;
        }
    }

}
