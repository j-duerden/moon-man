using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{ 
    private int health;

    private float stamina;

    private int currentFuel;

    public void SetPlayerStats()
    {
        health = 3;
        stamina = 100;
        currentFuel = 0;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
    }

    public float GetStamina()
    {
        return stamina;
    }

    public int GetCurrentFuel()
    {
        return currentFuel;
    }

    public void AddFuel(int newFuel)
    {
        currentFuel = currentFuel + newFuel;
    }
	
    void Start()
    {
        SetPlayerStats();
    }
}
