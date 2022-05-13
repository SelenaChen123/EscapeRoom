using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPuzzleInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name.Equals("Crowbar") && PuzzleManager.showCrowbar && !PuzzleManager.crowbarDropSoundPlayed)
        {
            this.gameObject.GetComponents<AudioSource>()[1].Play();
            PuzzleManager.crowbarDropSoundPlayed = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name.Equals("Treasure Chest") && this.gameObject.name.Equals("Chest Key"))
        {
            InventoryManager.usedDictionary["Chest Key"] = true;
            InventoryManager.holdingObject = false;
            InventoryManager.holdingObjectName = "";
            PuzzleManager.canUseChest = true;
        }
        else if (collider.name.Equals("Crate Closed") && this.gameObject.name.Equals("Crowbar"))
        {
            InventoryManager.usedDictionary["Crowbar"] = true;
            InventoryManager.holdingObject = false;
            InventoryManager.holdingObjectName = "";
            PuzzleManager.canUseCrate = true;
        }
        else if (collider.name.EndsWith("Statue Shadow") && this.gameObject.name.EndsWith("Statue"))
        {
            InventoryManager.usedDictionary[this.gameObject.name] = true;
            InventoryManager.holdingObject = false;
            InventoryManager.holdingObjectName = "";
            PuzzleManager.canUsePaper = InventoryManager.usedDictionary["Mermaid Statue"] && InventoryManager.usedDictionary["Bird Statue"] && InventoryManager.usedDictionary["Anchor Statue"] && InventoryManager.usedDictionary["Man Statue"];
        }
        else if (collider.name.EndsWith("Paper Shadow") && this.gameObject.name.EndsWith("Paper"))
        {
            InventoryManager.usedDictionary[this.gameObject.name] = true;
            InventoryManager.holdingObject = false;
            InventoryManager.holdingObjectName = "";
            PuzzleManager.canUseKeypad = InventoryManager.usedDictionary["Bottom Left Torn Paper"] && InventoryManager.usedDictionary["Bottom Right Torn Paper"] && InventoryManager.usedDictionary["Upper Left Torn Paper"] && InventoryManager.usedDictionary["Upper Right Torn Paper"];
        }
        else if (collider.name.Equals("Parrot") && this.gameObject.name.EndsWith("Apple"))
        {
            InventoryManager.usedDictionary[this.gameObject.name] = true;
            InventoryManager.holdingObject = false;
            InventoryManager.holdingObjectName = "";
            PuzzleManager.canUseParrot = InventoryManager.usedDictionary["PlayerQuarters Apple"] && InventoryManager.usedDictionary["Arsenal Apple"] && InventoryManager.usedDictionary["CaptainHeadquarters Apple"] && InventoryManager.usedDictionary["Deck Apple"];
        }
    }
}
