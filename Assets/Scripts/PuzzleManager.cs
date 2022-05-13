using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    private string chestUrl = "https://arnavjulka.github.io/ersupport/#/insideChest-AS22ASD";
    private string crateUrl = "https://arnavjulka.github.io/ersupport/#/crate-FHGU56G";
    private string paperUrl = "https://arnavjulka.github.io/ersupport/#/behindStatue-ERT89OP";
    private string parrotUrl = "https://arnavjulka.github.io/ersupport/#/parrotAsking-MNB567P";
    public static bool canUseChest = false;
    public static bool canUseCrate = false;
    public static bool canUsePaper = false;
    public static bool canUseParrot = false;
    public static bool canUseKeypad = false;
    public static bool showCrowbar = false;
    public static bool crowbarDropSoundPlayed = false;
    public static string bellTolls = "";
    public static Dictionary<string, bool> unlockMessageShown = new Dictionary<string, bool>() { { "Chest", false }, { "Crowbar", false }, { "Crate", false }, { "Paper", false }, { "Parrot", false }, { "Keypad", false } };

    void Start()
    {

    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals("Arsenal") && this.gameObject.name.StartsWith("Crate"))
        {
            if (!canUseCrate)
            {
                if (this.gameObject.name.Equals("Crate Closed"))
                {
                    this.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
                }
            }
            else
            {
                if (this.gameObject.name.Equals("Crate Open"))
                {
                    this.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
                }
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("CaptainHeadquarters") && this.gameObject.name.Equals("Puzzle Paper"))
        {
            if (!canUsePaper)
            {
                this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            }
            else
            {
                this.gameObject.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }

    void OnMouseDown()
    {
        if (canUseChest && this.gameObject.name.Equals("Treasure Chest"))
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Application.OpenURL(chestUrl);
        }
        if (canUseCrate && this.gameObject.name.Equals("Crate Open"))
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Application.OpenURL(crateUrl);
        }
        if (canUsePaper && this.gameObject.name.Equals("Puzzle Paper"))
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Application.OpenURL(paperUrl);
        }
        if (canUseParrot && this.gameObject.name.Equals("Parrot"))
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            Application.OpenURL(parrotUrl);
        }
    }
}
