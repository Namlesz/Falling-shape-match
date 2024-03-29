﻿using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform camTransform;
    Vector3 originalPos;

    public float shakeDuration = 0f;
    private float shakeTime;
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
        shakeTime = shakeDuration;
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        ShakeCam();
    }

    void ShakeCam()
    {
        if (Variable.shakeCam == true)
        {
            if (shakeDuration > 0)
            {
                camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

                shakeDuration -= Time.deltaTime * decreaseFactor;
            }
            else
            {
                Variable.shakeCam = false;
                shakeDuration = shakeTime;
                camTransform.localPosition = originalPos;
            }
        }
    }
}
