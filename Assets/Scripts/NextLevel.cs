using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour
{

    public PlayerManager playerManager;

    private Collider exitCollider;

    private int currentLevel;

    private int fuelToNext;

	// Use this for initialization
	void Start ()
    {
        fuelToNext = 5;
        currentLevel = Application.loadedLevel;
        exitCollider = GetComponent<Collider>();
	}
	
	void OnTriggerEnter(Collider exitCollider)
    {
        if(exitCollider.CompareTag("Player"))
        {
           if(fuelToNext == playerManager.GetCurrentFuel())
            {
                Application.LoadLevel(currentLevel + 1);
            }
        }
    }
}
