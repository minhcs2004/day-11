using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelButton : MonoBehaviour
{
    public GameObject curentSence;
    public GameObject nextSence;
    public void click()
    {
        curentSence.SetActive(false);
        nextSence.SetActive(true);

    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
