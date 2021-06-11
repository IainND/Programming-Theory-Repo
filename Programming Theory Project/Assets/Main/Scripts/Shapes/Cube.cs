using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Awake()
    {
        xValue = ObjectMaker.oMInstance.RandomFloat(69);
        yValue = ObjectMaker.oMInstance.RandomFloat(69);
        zValue = ObjectMaker.oMInstance.RandomFloat(69);
    }

    protected override void movePattern(float xMove, float yMove, float zMove)
    {
        transform.Rotate(xMove * Time.deltaTime, yMove * Time.deltaTime, zMove * Time.deltaTime);
        
    }
}
