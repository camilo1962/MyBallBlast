﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorFissionable : Meteor
{
    [SerializeField] GameObject[] splitsPrefabs;

    protected override void Die()
    {
        SplitMeteor();
        Destroy(gameObject);
    }
    void SplitMeteor()
    {
        GameObject g;

        for(int i=0 ; i<2;i++)
        {
          g=Instantiate(splitsPrefabs[i] , transform.position , Quaternion.identity , MeteorSpawner.Instance.transform);
          g.GetComponent<Rigidbody2D>().velocity=new Vector2(leftAndRight[i],5f);
        }
    
    }
}
