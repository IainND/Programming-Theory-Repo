using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    float turnSpeed;

    void Awake()
    {
        turnSpeed = ObjectMaker.oMInstance.RandomFloat(69);
    }

    public void Update()
    {
        transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        StartCoroutine(DestroyMe());
    }

    IEnumerator DestroyMe()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
