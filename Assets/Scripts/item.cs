﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public bool click;
    public GameObject broken;
    public GameObject t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (click)
        {
            broken.GetComponent<spawn>().cont++;
            t.GetComponent<Image>().fillAmount = t.GetComponent<Image>().fillAmount + 0.2f;

            transform.localPosition = new Vector3(0, 0, 0);
        }
        else
        {
            t.GetComponent<Image>().fillAmount = t.GetComponent<Image>().fillAmount - 0.2f;

        }

        //Object.Destroy(this.gameObject);
    }
}
