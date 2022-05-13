using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public static bool open = false;

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
        this.gameObject.GetComponent<AudioSource>().Play();
        if (open)
        {
            open = false;
        }
        else
        {
            open = true;
        }
    }
}
