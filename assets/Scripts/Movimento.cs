using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 0.5f;
    public bool emX;
    public bool emY;
    public bool emZ;

    // Start is called before the first frame update
    void Start()
    {
        emX = (Random.value > 0.6f);
        emY = (Random.value > 0.6f);
        emZ = (Random.value > 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (emX)
        {
            gameObject.transform.Translate(Vector3.right * velocidade * Mathf.Cos(Time.timeSinceLevelLoad), Space.World);
        }
        if (emY)
        {
            gameObject.transform.Translate(Vector3.back * velocidade * Mathf.Cos(Time.timeSinceLevelLoad), Space.World);
        }
        if (emZ)
        {
            gameObject.transform.Translate(Vector3.up * velocidade * Mathf.Cos(Time.timeSinceLevelLoad), Space.World);
        }
     
    }
}
