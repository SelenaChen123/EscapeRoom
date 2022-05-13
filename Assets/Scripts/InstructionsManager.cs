using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionsManager : MonoBehaviour
{
    public Text text;
    private Vector3 originalScale;
    private string[] instructions = new string[] { "You're trapped on a pirate ship and need to find a way to escape. There's a small boat hidden in locked in a room that you can use to get off of the ship.", "Collect specific items and use them to unlock puzzles around the ship. Solve the puzzles through your web browser to figure out a way to escape!" };

    // Start is called before the first frame update
    void Start()
    {
        originalScale = this.gameObject.transform.localScale;
        text.text = instructions[0];
        if (this.gameObject.name.Equals("Left Arrow"))
        {
            this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (this.gameObject.name.Equals("Right Arrow"))
        {
            text.text = instructions[1];
            this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            GameObject.Find("Left Arrow").gameObject.transform.localScale = originalScale;
        }
        else if (this.gameObject.name.Equals("Left Arrow"))
        {
            text.text = instructions[0];
            this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            GameObject.Find("Right Arrow").gameObject.transform.localScale = originalScale;
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
