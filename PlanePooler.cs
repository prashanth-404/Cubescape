using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePooler : MonoBehaviour
{
    public GameObject[] arr;
    public int distance = 12;
    public float time = 5f;
    // Start is called before the first frame update
    private int timer = 0;

    private int i;

    public void Start()
    {
        InvokeRepeating("HandleIt", time, 1);
    }

    void HandleIt()
    {

        i = timer % arr.Length;
        arr[i].transform.Translate(0, 0, distance);
        timer += 1;
    }
}
