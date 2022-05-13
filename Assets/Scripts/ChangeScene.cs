using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
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
        if (!InventoryButton.open)
        {
            if (this.gameObject.tag.Equals("LeftArrow"))
            {
                this.gameObject.GetComponent<AudioSource>().Play();
                if (SceneManager.GetActiveScene().name.Equals("PlayerQuarters"))
                {
                    SceneManager.LoadScene("EscapeDoor");
                }
                else if (SceneManager.GetActiveScene().name.Equals("Arsenal"))
                {
                    SceneManager.LoadScene("PlayerQuarters");
                }
                else if (SceneManager.GetActiveScene().name.Equals("CaptainHeadquarters"))
                {
                    SceneManager.LoadScene("Arsenal");
                }
                else if (SceneManager.GetActiveScene().name.Equals("Deck"))
                {
                    SceneManager.LoadScene("CaptainHeadquarters");
                }
                else if (SceneManager.GetActiveScene().name.Equals("EscapeDoor"))
                {
                    SceneManager.LoadScene("Deck");
                }
            }
            else if (this.gameObject.tag.Equals("RightArrow"))
            {
                this.gameObject.GetComponent<AudioSource>().Play();
                if (SceneManager.GetActiveScene().name.Equals("PlayerQuarters"))
                {
                    SceneManager.LoadScene("Arsenal");
                }
                else if (SceneManager.GetActiveScene().name.Equals("Arsenal"))
                {
                    SceneManager.LoadScene("CaptainHeadquarters");
                }
                else if (SceneManager.GetActiveScene().name.Equals("CaptainHeadquarters"))
                {
                    SceneManager.LoadScene("Deck");
                }
                else if (SceneManager.GetActiveScene().name.Equals("Deck"))
                {
                    SceneManager.LoadScene("EscapeDoor");
                }
                else if (SceneManager.GetActiveScene().name.Equals("EscapeDoor"))
                {
                    SceneManager.LoadScene("PlayerQuarters");
                }
            }
        }
    }
}
