using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static bool appear = false;
    public Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = this.gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (appear)
        {
            this.gameObject.transform.localScale = originalScale;
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
        }
    }

    void OnMouseDown()
    {
        if (PuzzleManager.canUseKeypad)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            if (appear)
            {
                appear = false;
            }
            else
            {
                appear = true;
            }
        }
    }
}
