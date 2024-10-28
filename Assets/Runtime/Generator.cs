using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Generator : MonoBehaviour
{
    [SerializeField] int numberItem;
    [SerializeField] GameObject wathObject;
    [SerializeField] Vector3 objectMinArea = new Vector3(-10,0,-10);
    [SerializeField] Vector3 objectMaxArea = new Vector3(10, 10, 10);
    [SerializeField] UnityEvent destruction;

    private List<GameObject> items = new List<GameObject>();

    private void Start()
    {
        if (wathObject == null)
        {
            Debug.Log("Prefab manquant!");
            return;
        }
        if (destruction == null) destruction = new UnityEvent();

        destruction.AddListener(GenerateNewItems);
    }
    void GenerateItems()
    {
       
    }

    void GenerateNewItems()
    {
        for (int i = 0; i < numberItem; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(objectMinArea.x, objectMaxArea.x),
                Random.Range(objectMinArea.y, objectMaxArea.y),
                Random.Range(objectMinArea.z, objectMaxArea.z)
            );

            GameObject objects = Instantiate(wathObject, randomPosition, Quaternion.identity);

            items.Add(objects);
        }
    }

    public List<GameObject> GetItems() { return items; }
}
