using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(ParticleSystem))]
public class Particles : MonoBehaviour {

   public ParticleSystem ps;

    // Use this for initialization
    void Start()
    {
        ps.GetComponent<Renderer>().sortingLayerName = "middleground";
    }   

}