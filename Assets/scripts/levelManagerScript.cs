using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManagerScript : MonoBehaviour
{

    int hearts;
    public Text heartcounter1;
    public static Text heartcounter;

    void Start()
    {
        hearts = 0;
    }

    // Update is called once per frame
    void Update()
    {
        heartcounter = heartcounter1;

        if(hearts == 3)
        {
            SceneManager.LoadScene(1);
            Debug.Log("win");
        }
    }

    public void IncHeartsCount()
    {
        hearts++;
        heartcounter.text = hearts.ToString("0");
        print("inc heart from lm");
    }
}
