using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject DeathPnl;
    // Start is called before the first frame update
    void Start()
    {
        DeathPnl = GameObject.Find("DeathCanvas");
        DeathPnl.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            Time.timeScale = 0;
            DeathPnl.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

}
