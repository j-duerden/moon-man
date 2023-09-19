using UnityEngine;
using System.Collections;

public class PlayerHealthLight : MonoBehaviour
{

    public Material black;
    public Material red;
    public Material yellow;
    public Material green;

    public PlayerManager playerManager;

    public int health;

    public MeshRenderer lightRenderer;

    // Use this for initialization
    void Start ()
    {
        black = Instantiate(Resources.Load("Empty", typeof(Material))) as Material;
        red = Instantiate(Resources.Load("Low", typeof(Material))) as Material;
        yellow = Instantiate(Resources.Load("Mid", typeof(Material))) as Material;
        green = Instantiate(Resources.Load("Full", typeof(Material))) as Material;
        lightRenderer = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        health = playerManager.GetHealth();
        HealthRemaining(health);
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            health--;
            playerManager.SetHealth(health);   
        }
	}

    public void HealthRemaining(int lightStatus)
    {

        lightStatus = playerManager.GetHealth();
        switch(lightStatus)
        {
            case 0:
                lightRenderer.material = black;
                break;
            case 1:
                lightRenderer.material = red;
                break;
            case 2:
                lightRenderer.material = yellow;
                break;
            case 3:
                lightRenderer.material = green;
                break;
        }
    }
}
