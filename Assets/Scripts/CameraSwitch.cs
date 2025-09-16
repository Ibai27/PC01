using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera MainCamera;
    public Camera Camera;

    private bool usingMainCamera = true;

    void Start()
    {
        MainCamera.enabled = true;
        Camera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            usingMainCamera = !usingMainCamera;

            MainCamera.enabled = usingMainCamera;
            Camera.enabled = !usingMainCamera;
        }
    }
}