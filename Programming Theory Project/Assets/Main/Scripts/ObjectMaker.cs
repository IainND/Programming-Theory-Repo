using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour
{
    public static ObjectMaker oMInstance;

    public GameObject[] shapeTypes;
    private float shapeX = 1.5f;
    private float shapeY = 0f;
    private float shapeZ = 3f;

    public GameObject[] animalTypes;
    private float animalX = -1.5f;
    private float animalY = -1.5f;
    private float animalZ = 5f;

    private void Awake()
    {
        oMInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeSomething(string request)
    {
        if (request == "Shape")
        {
            MakeShape();
        }
        else if (request == "Animal")
        {
            MakeAnimal();
        }
        else { Debug.Log("Invalid MakeSomething request"); }
    }

    void MakeShape()
    {
        int shapeIndex = Random.Range(0, shapeTypes.Length);
        Vector3 shapeStartPos = new Vector3(shapeX, shapeY, shapeZ);
        GameObject newShape = (GameObject)Instantiate(shapeTypes[shapeIndex], shapeStartPos, shapeTypes[shapeIndex].transform.rotation);
    }

    void MakeAnimal()
    {
        int animalIndex = Random.Range(0, animalTypes.Length);
        Vector3 animalStartPos = new Vector3(animalX, animalY, animalZ);
        GameObject newAnimal = (GameObject)Instantiate(animalTypes[animalIndex], animalStartPos, animalTypes[animalIndex].transform.rotation);
    }

    Vector3 RandomVector(int xLimit, int yLimit, int zLimit)
    {
        Vector3 randVector = new Vector3(RandomFloat(xLimit), RandomFloat(yLimit), RandomFloat(zLimit));
        return randVector;
    }

    public float RandomFloat(int floatLimit)
    {
        return Random.Range(0, floatLimit);
    }
    


}
