using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{

    [SerializeField]
    private float jumpHeight = 500;

    private Transform transformComponent;

    public Rigidbody characterBody;

    public bool isJumping = false;


    // Use this for initialization
    void Start()
    {
        transformComponent = GetComponent<Transform>();
        characterBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                characterBody.AddForce(transformComponent.up * jumpHeight);
                isJumping = true;
            }
        }
    }

    void OnTriggerEnter(Collider playerCollider)
    {

        if (playerCollider.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }
}

