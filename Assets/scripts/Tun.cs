using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tun : MonoBehaviour
{
    public GameObject oldPge;
    public GameObject newPage;
    public void Tunn()
    {
        oldPge.SetActive(false);
        newPage.SetActive(true);
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

