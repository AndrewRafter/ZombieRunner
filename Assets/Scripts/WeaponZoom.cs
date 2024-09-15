using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] FirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 3f;
    [SerializeField] float zoomedInSensitivity = 1f;

    bool zoomedInToggle = false;

    void OnDisable() {
        ZoomOut();
    }

    void Update() {
        if(Input.GetMouseButtonDown(1)) {
            if(!zoomedInToggle) {
                ZoomIn();
            } else {
                ZoomOut();
            }
        }
    }

    private void ZoomIn() {
        zoomedInToggle = true;
        fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
        fpsController.RotationSpeed = zoomedInSensitivity;
    }

    private void ZoomOut() {
        zoomedInToggle = false;
        fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
        fpsController.RotationSpeed = zoomedOutSensitivity;
    }

    
}
