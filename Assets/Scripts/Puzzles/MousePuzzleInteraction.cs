using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePuzzleInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (!PuzzleManager.canUseCrate && this.gameObject.name.EndsWith("Bell"))
        {
            if (this.gameObject.name.Equals("Light Bell"))
            {
                PuzzleManager.bellTolls += "1";
                this.gameObject.GetComponent<AudioSource>().Play();

            }
            else if (this.gameObject.name.Equals("Bottle Bell"))
            {
                PuzzleManager.bellTolls += "2";
                this.gameObject.GetComponent<AudioSource>().Play();
            }
            else
            {
                PuzzleManager.bellTolls += "3";
                this.gameObject.GetComponent<AudioSource>().Play();
            }

            if (PuzzleManager.bellTolls.Contains("1111122223333"))
            {
                PuzzleManager.showCrowbar = true;
            }
        }
    }
}
