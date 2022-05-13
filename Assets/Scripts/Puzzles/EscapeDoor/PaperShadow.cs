using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaperShadow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals("EscapeDoor") && this.gameObject.name.EndsWith("Shadow"))
        {
            if (InventoryManager.usedDictionary[this.gameObject.name.Substring(0, this.gameObject.name.IndexOf(" Shadow"))])
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
            }
            else
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 0, 0, 0.5f);
            }
        }
    }

    void OnMouseDown()
    {
        if (PuzzleManager.canUseKeypad)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            if (Map.appear)
            {
                Map.appear = false;
            }
            else
            {
                Map.appear = true;
            }
        }
    }
}
