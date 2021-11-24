using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collections : MonoBehaviour
{

    public static int hearts = 0;
    public Text heartcounter1;
    public static Text heartcounter;
    public GameObject lm;
    public levelManagerScript lms;

    void Start()
    {
        //hearts = 0;
        lm =  GameObject.Find("levelManager");
        lms = lm.GetComponent<levelManagerScript>();
        
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            lms.IncHeartsCount();
            //hearts++;
            heartcounter.text = hearts.ToString("0");
            Destroy(gameObject);
        }
    }
}
