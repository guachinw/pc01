using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    //float tx = 10;
    //float ty = 20;

    /*float tx = 0;
    float ty = 0;
    float minX = -5;
    float miny = -5;
    float width = 10;
    float height = 10;*/

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*tx += 0.01f;
        ty += 0.01f;

        //float x = minX + width * Mathf.PerlinNoise(tx, 0);
        //float y = miny + height * Mathf.PerlinNoise(ty,0);

        float x = -5 + 10 * Mathf.PerlinNoise(tx, 0);
		float y = -5 + 10 * Mathf.PerlinNoise(0, ty);


        transform.position = new Vector3(x,y,0);*/

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.Scale(new Vector3(1,1,0));
        transform.position = mousePosition;
    }
}
