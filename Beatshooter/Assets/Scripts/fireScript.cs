using UnityEngine;
using System.Collections;
public class ControllerManager : MonoBehaviour
{
    public bool triggerButtonDown = false;

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public AudioClip shoot;
    private SteamVR_Controller.Device controller
    {

        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);

        }

    }

    private SteamVR_TrackedObject trackedObj;

    void Start()
    {

        trackedObj = GetComponent<SteamVR_TrackedObject>();

    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (controller == null)
        {

            Debug.Log("Controller not initialized");

            return;

        }

        triggerButtonDown = controller.GetPressDown(triggerButton);

        if (triggerButtonDown)
        {
            

            // Create the Bullet from the Bullet Prefab
            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn.position,
                bulletSpawn.rotation);
                AudioClip.Instantiate(shoot);

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 10.0f);

        }

    }

}
