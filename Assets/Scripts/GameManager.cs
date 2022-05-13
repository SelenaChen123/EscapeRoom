using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool menuShown = false;
    public static bool gameStarted = false;
    public static bool showingHint = false;
    public bool internalHoldingObject;
    public string internalHoldingObjectName;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("Menu"))
        {
            menuShown = true;
        }

        if (!SceneManager.GetActiveScene().name.Equals("Menu") && !gameStarted && !menuShown)
        {
            menuShown = true;
            SceneManager.LoadScene("Menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        internalHoldingObject = InventoryManager.holdingObject;
        internalHoldingObjectName = InventoryManager.holdingObjectName;
    }

    public void StartGame()
    {
        GameManager.gameStarted = true;
        SceneManager.LoadScene("PlayerQuarters");
    }

    public void ShowInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void UploadQuestions()
    {
        Application.OpenURL("https://arnavjulka.github.io/ersupport/#/upload-OP23NS679ASD");
    }
}
