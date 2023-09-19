using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public PlayerManager playerManager;

    public GameObject[] pauseMenuObjects;

    public Text fuelText;

    public Button resumeButton;

    public Button optionsButton;

    public Button quitButton;

    private bool isPaused;

	// Use this for initialization
	void Start ()
    {
        pauseMenuObjects = GameObject.FindGameObjectsWithTag("Pause Menu");
        HideMenu();
        isPaused = false;
	}

    void Update()
    {     
        if(isPaused)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                HideMenu();
                Resume();
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                ShowMenu();
                Pause();
            }
        }
    }

    public void UpdateFuel()
    {
        int currentFuel = playerManager.GetCurrentFuel();
        fuelText.text = "Current Fuel: " + currentFuel.ToString();
    }

    public void ShowMenu()
    {
       foreach (GameObject toShow in pauseMenuObjects)
       {
           toShow.SetActive(true);
       }
       Time.timeScale = 0.0f;
    }

    public void HideMenu()
    {
        foreach (GameObject toShow in pauseMenuObjects)
        {
            toShow.SetActive(false);
        }
       Time.timeScale = 1.0f;
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Paused");
            isPaused = true;
        }
    }
}
