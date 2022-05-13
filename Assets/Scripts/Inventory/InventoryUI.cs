using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = this.gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryButton.open)
        {
            this.gameObject.transform.localScale = originalScale;
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(.001f, .001f, .001f);
        }

        for (int i = 0; i < InventoryManager.slotPositions.Length; i++)
        {
            if (Physics2D.OverlapCircle(new Vector2(InventoryManager.slotPositions[i].x, InventoryManager.slotPositions[i].y), 1, 8) == null)
            {
                InventoryManager.openSlotPosition = InventoryManager.slotPositions[i];
                break;
            }
        }
    }
}
