using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager
{
    public static Vector3[] slotPositions = new Vector3[]
    {
        new Vector3(-535f, 335f, 1200f), new Vector3(-177.5f, 335f, 1200f), new Vector3(180f, 335f, 1200f),
        new Vector3(537.5f, 335f, 1200f), new Vector3(-535f, 112.5f, 1200f), new Vector3(-177.5f, 112.5f, 1200f),
        new Vector3(180f, 112.5f, 1200f), new Vector3(537.5f, 112.5f, 1200f), new Vector3(-535f, -110f, 1200f),
        new Vector3(-177.5f, -110f, 1200f), new Vector3(180f, -110f, 1200f), new Vector3(537.5f, -110f, 1200f),
        new Vector3(-535f, -332.5f, 1200f), new Vector3(-177.5f, -332.5f, 1200f), new Vector3(180f, -332.5f, 1200f),
        new Vector3(537.5f, -332.5f, 1200f)
    };

    public static Vector3 openSlotPosition = new Vector3(-535f, 335f, 1200f);

    public static Dictionary<string, bool> collectedDictionary = new Dictionary<string, bool>()
    {
        {"Chest Key", false}, {"Mermaid Statue", false}, {"Bottom Left Torn Paper", false},
        {"PlayerQuarters Apple", false}, {"Bird Statue", false}, {"Bottom Right Torn Paper", false},
        {"Arsenal Apple", false}, {"Crowbar", false}, {"Upper Left Torn Paper", false},
        {"CaptainHeadquarters Apple", false}, {"Anchor Statue", false}, {"Man Statue", false},
        {"Upper Right Torn Paper", false}, {"Deck Apple", false}
    };

    public static Dictionary<string, bool> usedDictionary = new Dictionary<string, bool>()
    {
        {"Chest Key", false}, {"Mermaid Statue", false}, {"Bottom Left Torn Paper", false},
        {"PlayerQuarters Apple", false}, {"Bird Statue", false}, {"Bottom Right Torn Paper", false},
        {"Arsenal Apple", false}, {"Crowbar", false}, {"Upper Left Torn Paper", false},
        {"CaptainHeadquarters Apple", false}, {"Anchor Statue", false}, {"Man Statue", false},
        {"Upper Right Torn Paper", false}, {"Deck Apple", false}
    };

    public static Dictionary<string, Vector3> positionDictionary = new Dictionary<string, Vector3>()
    {
        {"Chest Key", new Vector3(-1000, -500, 0)}, {"Mermaid Statue", new Vector3(-1000, -500, 0)},
        {"Bottom Left Torn Paper", new Vector3(-1000, -500, 0)}, {"PlayerQuarters Apple", new Vector3(-1000, -500, 0)},
        {"Bird Statue", new Vector3(-1000, -500, 0)}, {"Bottom Right Torn Paper", new Vector3(-1000, -500, 0)},
        {"Arsenal Apple", new Vector3(-1000, -500, 0)}, {"Crowbar", new Vector3(-1000, -500, 0)},
        {"Upper Left Torn Paper", new Vector3(-1000, -500, 0)},
        {"CaptainHeadquarters Apple", new Vector3(-1000, -500, 0)}, {"Anchor Statue", new Vector3(-1000, -500, 0)},
        {"Man Statue", new Vector3(-1000, -500, 0)}, {"Upper Right Torn Paper", new Vector3(-1000, -500, 0)},
        {"Deck Apple", new Vector3(-1000, -500, 0)}
    };

    public static bool holdingObject = false;

    public static string holdingObjectName = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    static public string chooseCurrentHint()
    {
        if (!PuzzleManager.canUseChest)
        {
            return "Try finding the key to open the chest";
        }
        else if (!PuzzleManager.canUseCrate)
        {
            return "Try finding something to open the crate";
        }
        else if (!PuzzleManager.canUsePaper)
        {
            return "Try finding all of the statues";
        }
        else if (!PuzzleManager.canUseParrot)
        {
            return "Try finding all of the apples";
        }
        else if (!PuzzleManager.canUseKeypad)
        {
            return "Try finding all of the pieces of the paper";
        }
        return "Just try harder mate";
    }
}