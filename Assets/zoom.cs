using UnityEngine;
using UnityEngine.InputSystem;

public class MicroscopeZoom : MonoBehaviour
{
    public float zoomSpeed = 20f;
    public float minFOV = 5f;
    public float maxFOV = 60f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            cam.fieldOfView -= zoomSpeed * Time.deltaTime;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            cam.fieldOfView += zoomSpeed * Time.deltaTime;
        }

        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minFOV, maxFOV);
    }
}