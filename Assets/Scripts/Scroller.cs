using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    int numlayers;
    Transform[] layers;
    public float[] layerFac;
    public Camera attachedCamera;
    Vector3 initialPosition;


    // Start is called before the first frame update
    void Start()
    {
        numlayers = layerFac.Length;
        layers = new Transform[numlayers];
        initialPosition = attachedCamera.transform.position; 

        for (int i = 0; i < numlayers; i++)
        {
            layers[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = attachedCamera.transform.position - initialPosition;

        for (int i = 0; i < numlayers; i++)
        {
            Vector3 scaledDiff = diff * layerFac[i];
            layers[i].transform.localPosition = new Vector3(scaledDiff.x, scaledDiff.y, 0.0f);
        }
    }
}
