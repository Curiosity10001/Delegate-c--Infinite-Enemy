using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KilCountDisplay : MonoBehaviour
{
    public int killCount = 0;
    TextMeshProUGUI text;
    GameObject event10Kill;

    // Start is called before the first frame update
    private void Awake()
    {
        event10Kill = GameObject.Find("Event10Kill");
    }
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = "Kill Count " + killCount;

        //if(killCount >0 && killCount % 10 == 0)
       // {
         //   event10Kill.SetActive(true);
        //    Time.timeScale = 0;
        //}
        


    }
    public void Ricochet()
    {
        event10Kill.SetActive(false);
        Time.timeScale = 1;
    }
    public void DoubleHit()
    {
        event10Kill.SetActive(false);
        Time.timeScale = 1;
    }
}
