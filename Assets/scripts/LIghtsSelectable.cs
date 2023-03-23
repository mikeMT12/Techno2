using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIghtsSelectable : MonoBehaviour
{
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TextOn()
    {
        Text.SetActive(true);

    }
    
    public void TextOff()
    {
        Text.GetComponent<Animator>().Play("LightsAnimationOFF");
        Text.SetActive(false);
    }
}
