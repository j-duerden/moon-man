using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{

    public float cameraDistXOffset;
    public float cameraDistYOffset;
    public float cameraDistZOffset;
    private Camera mainCamera;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        player = GameObject.Find("Player");      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInfo = player.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x - cameraDistXOffset, playerInfo.y - cameraDistYOffset, playerInfo.z - cameraDistZOffset);
    }
}
