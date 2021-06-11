using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected abstract void movePattern(float xMoveShape, float yMoveShape, float zMoveShape);

    public float xValue;
    public float yValue;
    public float zValue;

    public void Update()
    {
        movePattern(xValue, yValue, zValue);
        StartCoroutine(DestroyMe());
    }

    IEnumerator DestroyMe()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

}
