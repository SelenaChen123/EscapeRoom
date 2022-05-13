using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryCollect : MonoBehaviour
{// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("/Hidden/" + this.gameObject.name))
        {
            if (!InventoryManager.holdingObjectName.Equals(this.gameObject.name))
            {
                this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
                this.gameObject.transform.position = InventoryManager.positionDictionary[this.gameObject.name];
            }
        }

        if (SceneManager.GetActiveScene().name.Equals("Arsenal") && this.gameObject.name.Equals("Crowbar"))
        {
            if (!PuzzleManager.showCrowbar)
            {
                this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            }
            else if (!PuzzleManager.canUseCrate && !InventoryManager.collectedDictionary["Crowbar"] && !InventoryButton.open)
            {
                this.gameObject.transform.localScale = new Vector3(1, 1, 1);
                this.gameObject.transform.position = new Vector3(384, -203, 1600);
            }
        }

        if (InventoryManager.collectedDictionary[this.gameObject.name])
        {
            if (!InventoryManager.holdingObjectName.Equals(this.gameObject.name))
            {
                this.gameObject.transform.position = InventoryManager.positionDictionary[this.gameObject.name];
            };

            if (this.gameObject.GetComponentInChildren<SpriteRenderer>())
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255, 1);
            }
        }

        if (InventoryButton.open)
        {
            if (InventoryManager.usedDictionary[this.gameObject.name])
            {
                this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            }
            else if (InventoryManager.collectedDictionary[this.gameObject.name])
            {
                if (this.gameObject.name.Equals("Mermaid Statue"))
                {
                    this.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                }
                else if (this.gameObject.name.Equals("Upper Left Torn Paper"))
                {
                    this.gameObject.transform.localScale = new Vector3(2, 2, 2);
                }
                else if (!InventoryManager.usedDictionary[this.gameObject.name])
                {
                    this.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
            }
        }
        else
        {
            if ((InventoryManager.usedDictionary[this.gameObject.name] && InventoryManager.holdingObjectName.Equals(this.gameObject.name)) || (InventoryManager.collectedDictionary[this.gameObject.name] && !InventoryManager.holdingObjectName.Equals(this.gameObject.name)))
            {
                this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
            }
        }
    }

    void OnMouseDown()
    {
        if (!InventoryButton.open && !InventoryManager.collectedDictionary[this.gameObject.name])
        {
            InventoryManager.collectedDictionary[this.gameObject.name] = true;
            InventoryManager.positionDictionary[this.gameObject.name] = InventoryManager.openSlotPosition;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            if (InventoryButton.open)
            {
                InventoryButton.open = false;
            }

            if (!InventoryManager.holdingObject)
            {
                InventoryManager.holdingObject = true;
                InventoryManager.holdingObjectName = this.gameObject.name;
            }
            else
            {
                InventoryManager.holdingObject = false;
                InventoryManager.holdingObjectName = "";
            }
        }
    }
}
