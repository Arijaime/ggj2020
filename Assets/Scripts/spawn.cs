﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public int cont =0;
    public item[] prefab;
    private List<int> posb= new List<int>();

    public Transform[] pos;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < pos.Length; i++)
        {
            int p = 0;
            while (posb.Contains(p))
            {
                p = Random.Range(0, prefab.Length);
            }
            posb.Add(p);

            item ch1 = Instantiate(prefab[p]);
            ch1.transform.SetParent(pos[i].parent, false);           
            ch1.transform.localPosition = pos[i].localPosition;

            ch1.broken = gameObject;
            ch1.t = timer;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (cont>=3)
        {
            Object.Destroy(this.gameObject);
            Time.timeScale = 0;
        }
    }
}