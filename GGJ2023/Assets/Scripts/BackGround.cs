using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject bg1;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        // material = bg1.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            bg1.GetComponent<Renderer>().material.color = bg1.GetComponent<Renderer>().material.color - new Color32(0,0,0,1);
        }
    }
}
