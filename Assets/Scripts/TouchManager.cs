using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            // check the first touch. touchphase.began is the first frame
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                // raycast laser metaphor
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;

                // shooting the actual raycast
                if(Physics.Raycast(ray, out hit))
                {
                    // did we hit a collider ?
                    if(hit.collider != null)
                    {
                        Color color = new Color(Random.value, Random.value, Random.value);
                        // mofify its color
                        hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
                    }
                }
            }
        }
    }
}
