﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Camera2D : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cameraVirtual;

    private void Start()
    {
        cameraVirtual.Priority = 0;
        cameraVirtual.enabled = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(SwitchToEnableCamera(other));
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            cameraVirtual.Priority = 11;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            other.GetComponent<PlayerMovement>().SetPlayer2D(false);
            StartCoroutine(SwitchToDisableCamera(other));

        }
    }

    IEnumerator SwitchToEnableCamera(Collider other)
    {
        yield return new WaitForSeconds(1f);
        other.GetComponent<PlayerMovement>().SetPlayer2D(true);
        cameraVirtual.enabled = true;
        cameraVirtual.Priority = 11;
        yield return new WaitForSeconds(1);
        cameraVirtual.Follow = other.transform;
    }
    IEnumerator SwitchToDisableCamera(Collider other)
    {
        yield return new WaitForSeconds(0.5f);
        cameraVirtual.Follow = null;
        cameraVirtual.Priority = 0;
        cameraVirtual.enabled = false;
        yield return null;
    }
}
