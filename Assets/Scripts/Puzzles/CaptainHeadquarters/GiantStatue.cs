using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiantStatue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals("CaptainHeadquarters") && this.gameObject.name.Equals("Giant Statue") && PuzzleManager.canUsePaper)
        {
            this.gameObject.transform.position = new Vector3(-250f, 0, 1600);
        }
    }
}
