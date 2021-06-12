using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Awake()
    {
        xValue = ObjectMaker.oMInstance.RandomFloat(9);
        yValue = ObjectMaker.oMInstance.RandomFloat(11);
        zValue = ObjectMaker.oMInstance.RandomFloat(1);
    }

    protected override void movePattern(float xMoveShape, float yMoveShape, float zMoveShape)
    {
        transform.Translate(xMoveShape * Time.deltaTime, yMoveShape * Time.deltaTime, zMoveShape * Time.deltaTime);
    }
}
