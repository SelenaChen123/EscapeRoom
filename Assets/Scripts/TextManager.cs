using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public Text text;
    private float timer = 0f;
    private float maxTimer = 3f;
    private string currentMessage = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = currentMessage;
        if (GameManager.showingHint)
        {
            timer += Time.deltaTime;
            if (timer >= maxTimer)
            {
                GameManager.showingHint = false;
                timer = 0f;
                currentMessage = "";
            }
        }
        else
        {
            ShowUnlockMessage();
        }
    }

    void ShowUnlockMessage()
    {
        if (SceneManager.GetActiveScene().name.Equals("PlayerQuarters") && PuzzleManager.canUseChest && !PuzzleManager.unlockMessageShown["Chest"])
        {
            timer += Time.deltaTime;
            currentMessage = "The chest has been unlocked";
            if (timer >= maxTimer)
            {
                timer = 0f;
                currentMessage = "";
                PuzzleManager.unlockMessageShown["Chest"] = true;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Arsenal") && PuzzleManager.showCrowbar && !PuzzleManager.unlockMessageShown["Crowbar"])
        {
            timer += Time.deltaTime;
            currentMessage = "Something fell down from the ceiling";
            if (timer >= maxTimer)
            {
                timer = 0f;
                currentMessage = "";
                PuzzleManager.unlockMessageShown["Crowbar"] = true;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Arsenal") && PuzzleManager.canUseCrate && !PuzzleManager.unlockMessageShown["Crate"])
        {
            timer += Time.deltaTime;
            currentMessage = "The crate has been opened";
            if (timer >= maxTimer)
            {
                timer = 0f;
                currentMessage = "";
                PuzzleManager.unlockMessageShown["Crate"] = true;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("CaptainHeadquarters") && PuzzleManager.canUsePaper && !PuzzleManager.unlockMessageShown["Paper"])
        {
            timer += Time.deltaTime;
            currentMessage = "The statue moves aside, revealing a piece of paper on the floor";
            if (timer >= maxTimer)
            {
                timer = 0f;
                currentMessage = "";
                PuzzleManager.unlockMessageShown["Paper"] = true;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Deck") && PuzzleManager.canUseParrot && !PuzzleManager.unlockMessageShown["Parrot"])
        {
            timer += Time.deltaTime;
            currentMessage = "The parrot has something to say";
            if (timer >= maxTimer)
            {
                timer = 0f;
                currentMessage = "";
                PuzzleManager.unlockMessageShown["Parrot"] = true;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("EscapeDoor") && PuzzleManager.canUseKeypad && !PuzzleManager.unlockMessageShown["Keypad"])
        {
            timer += Time.deltaTime;
            currentMessage = "The keypad is now accessible";
            if (timer >= maxTimer)
            {
                timer = 0f;
                currentMessage = "";
                PuzzleManager.unlockMessageShown["Keypad"] = true;
            }
        }
        else
        {
            currentMessage = "";
        }
    }

    void OnMouseDown()
    {
        if (!InventoryButton.open)
        {
            if (this.gameObject.name.Equals("Hint Button"))
            {
                this.gameObject.GetComponent<AudioSource>().Play();
                timer = 0f;
                GameManager.showingHint = true;
                if (!PuzzleManager.canUseChest)
                {
                    currentMessage = "Try finding the key to the chest";
                }
                else if (!PuzzleManager.canUseCrate)
                {
                    currentMessage = "Try finding something to open the crate";
                }
                else if (!PuzzleManager.canUsePaper)
                {
                    currentMessage = "Try finding all of the statues";
                }
                else if (!PuzzleManager.canUseParrot)
                {
                    currentMessage = "Try finding all of the apples";
                }
                else if (!PuzzleManager.canUseKeypad)
                {
                    currentMessage = "Try finding all of the pieces of the paper";
                }
                else
                {
                    currentMessage = "Try figuring out the code to the keypad";
                }
            }
            else if (this.gameObject.name.Equals("Keypad") && !PuzzleManager.canUseKeypad)
            {
                GameManager.showingHint = true;
                currentMessage = "You can't use this yet";
            }
        }
    }
}
