using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadButton : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (this.gameObject.name.Equals("1") || this.gameObject.name.Equals("2") || this.gameObject.name.Equals("3") || this.gameObject.name.Equals("4") || this.gameObject.name.Equals("5") || this.gameObject.name.Equals("6") || this.gameObject.name.Equals("7") || this.gameObject.name.Equals("8") || this.gameObject.name.Equals("9") || this.gameObject.name.Equals("0"))
        {
            if (text.text.Length != 10)
            {
                text.color = new Color(140, 140, 140);
                text.text += this.gameObject.name + (text.text.Length != 9 ? "  " : "");
            }

            if (text.text.Length == 10)
            {
                if (!text.text.Contains("9  5  4  2")) // 4925 -> crate parrot chest paper
                {
                    text.color = new Color(140, 0, 0);
                }
                else
                {
                    text.color = new Color(0, 140, 0);
                    Keypad.passcodeCorrect = true;
                }
            }
        }
        else if (this.gameObject.name.Equals("Clear Button"))
        {
            text.text = "";
            text.color = new Color(140, 140, 140);
        }
    }
}
