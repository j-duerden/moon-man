using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public RawImage backgroundImage;

    public Button playButton;

    public Button optionsButton;

    public Button quitButton;

    private int currentLevel;

    private float speed;

	// Use this for initialization
	void Start ()
    {
        speed = 0.5f;
        currentLevel = Application.loadedLevel;
        Button play = playButton.GetComponent<Button>();
        play.onClick.AddListener(Play);
	}
	
	// Update is called once per frame
	void Update ()
    {
        backgroundImage.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
	}

    public void Play()
    {
        Application.LoadLevel(currentLevel + 1);
    }
}
