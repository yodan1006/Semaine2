using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GeneratorCircle : MonoBehaviour
{
    [SerializeField] int numberItem;
    [SerializeField] GameObject wathObject;
    [SerializeField] float circleRadius = 10f; // Rayon du cercle
    [SerializeField] UnityEvent destruction;

    private List<GameObject> items = new List<GameObject>();

    private void Start()
    {
        if (wathObject == null)
        {
            Debug.Log("Prefab manquant!");
            return;
        }

        if (destruction == null)
            destruction = new UnityEvent();

        destruction.AddListener(GenerateNew);

        GenerateItems();
    }

    private void GenerateItems()
    {
        for (int i = 0; i < numberItem; i++)
        {
            GenerateNewItem(i);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyRandomItem();
        }
    }

    private void GenerateNew()
    {
        GenerateNewItem(items.Count);
    }

    private void GenerateNewItem(int index = -1)
    {
        float angle = Random.Range(0f, 360f);
        float radians = angle * Mathf.Deg2Rad;

        // Calcule la position aléatoire sur le cercle
        Vector3 position = new Vector3(
            Mathf.Cos(radians) * circleRadius,
            0,
            Mathf.Sin(radians) * circleRadius
        );

        // Instancie le nouvel objet à la position calculée
        GameObject newObject = Instantiate(wathObject, position, Quaternion.identity);
        items.Add(newObject);
    }

    public void DestroyRandomItem()
    {
        if (items.Count > 0)
        {
            GameObject itemToDestroy = items[0];
            items.Remove(itemToDestroy);
            Destroy(itemToDestroy);

            destruction.Invoke();
        }
    }

    public List<GameObject> GetItems() { return items; }
}
