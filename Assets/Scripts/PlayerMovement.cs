using UnityEngine;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5.0f;

    private Transform transformComponent;

    public PlayerManager playerManager;

    public Rigidbody characterBody;

    public Collider playerCollider;

    // Use this for initialization
    void Start()
    {
        transformComponent = GetComponent<Transform>();
        characterBody = GetComponent<Rigidbody>();
        playerCollider = GetComponent<Collider>();

        updatePos = new UpdatingPosition();
        updatePos.Init(speed, transformComponent, characterBody);
    }

    [SerializeField]
    private UpdatingPosition updatePos;
    // Update is called once per frame
    void Update()
    {
        updatePos.UpdateUp();
        updatePos.UpdateRight();
        updatePos.UpdateSprint();
    }
}

[Serializable]
class UpdatingPosition
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpHeight;
    [SerializeField]
    private Transform transformComp;

    public Rigidbody characterBody;

    public void Init(float s, Transform t, Rigidbody rb)
    {
        speed += s;

        transformComp = t;

        characterBody = rb;
    }

    public void UpdateUp()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transformComp.position += transformComp.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transformComp.position -= transformComp.forward * speed * Time.deltaTime;
        }

    }

    public void UpdateRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transformComp.Rotate(Vector3.up * 90 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transformComp.Rotate(Vector3.down * 90 * Time.deltaTime);
        }
    }

    public void UpdateSprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 3;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 3;
        }
    }
}
