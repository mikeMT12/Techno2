using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeeadlightsManager : MonoBehaviour
{
    public Transform pointer;
    [SerializeField] private float _timeDelay = 5f;
    [SerializeField] private float _nowTime = 0f;
    public GameObject LightToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        _nowTime = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.yellow);
       
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            _nowTime += Time.deltaTime;
            pointer.position = hit.point;
            LIghtsSelectable lights = hit.collider.gameObject.GetComponent<LIghtsSelectable>();
            Debug.Log(hit.collider.gameObject.tag);
            if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Touch touch = Input.GetTouch(0);
                LightToSpawn.SetActive(true);
            }
            

            
            if (lights) 
            {
                
                if (_nowTime >= _timeDelay)
                {
                    lights.TextOn();
                }

                if (_nowTime >= _timeDelay * 2)
                {
                    lights.TextOff();
                    if (_nowTime >= _timeDelay * 3)
                    {
                        _nowTime = 4;
                    }
                }

            }



        }
    }
}
