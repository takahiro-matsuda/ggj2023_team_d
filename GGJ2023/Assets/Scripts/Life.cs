using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValue(int value) {
        image1.SetActive(value > 0);
        image2.SetActive(value > 1);
        image3.SetActive(value > 2);
    }
}
