using UnityEngine;
using System.Collections;

public class FuelPickup : MonoBehaviour
{
    public GameObject fuel;

    private Collider fuelCollider;

    public PlayerManager playerManager;

    public UIManager uiManager;

	// Use this for initialization
	void Start ()
    {
        fuelCollider = GetComponent<Collider>();
	}

    void OnTriggerEnter(Collider fuelCollider)
    {
        if (fuelCollider.CompareTag("Player"))
        {
            Debug.Log("Got Fuel!");
            playerManager.AddFuel(1);
            uiManager.UpdateFuel();
            fuel.SetActive(false);
        }
    }
}
