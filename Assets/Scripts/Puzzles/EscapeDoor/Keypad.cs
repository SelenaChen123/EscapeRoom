using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public static bool appear = false;
    public Vector3 originalScale;

    public static bool passcodeCorrect = false;
    private float timer = 0f;
    private float maxTimer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = this.gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name.Equals("Keypad Zoom"))
        {
            if (passcodeCorrect)
            {
                timer += Time.deltaTime;
                if (timer >= maxTimer)
                {
                    appear = false;
                }
            }

            if (appear)
            {
                this.gameObject.transform.localScale = originalScale;
            }
            else
            {
                this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            }
        }
    }

    void OnMouseDown()
    {
        if (PuzzleManager.canUseKeypad && this.gameObject.name.Equals("Keypad"))
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            if (Keypad.appear)
            {
                Keypad.appear = false;
            }
            else
            {
                Keypad.appear = true;
            }
        }
    }
}
