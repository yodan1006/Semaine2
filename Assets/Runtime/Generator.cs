using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Generator : MonoBehaviour
{
    [SerializeField] int numberItem;
    [SerializeField] GameObject wathObject;
    [SerializeField] Vector3 objectMinArea = new Vector3(-10, 0, -10);
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

        if (destruction == null)
            destruction = new UnityEvent();

        // Ajouter l'�couteur d'�v�nement pour g�n�rer un seul nouvel item apr�s destruction
        destruction.AddListener(GenerateNewItem);

        // G�n�re les items initiaux
        GenerateItems();
    }

    private void GenerateItems()
    {
        // G�n�re exactement `numberItem` items une seule fois au d�but
        for (int i = 0; i < numberItem; i++)
        {
            GenerateNewItem();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyRandomItem();
        }
    }

    private void GenerateNewItem()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(objectMinArea.x, objectMaxArea.x),
            Random.Range(objectMinArea.y, objectMaxArea.y),
            Random.Range(objectMinArea.z, objectMaxArea.z)
        );

        GameObject newObject = Instantiate(wathObject, randomPosition, Quaternion.identity);
        items.Add(newObject);
    }

    public void DestroyRandomItem()
    {
        if (items.Count > 0)
        {
            GameObject itemToDestroy = items[0];
            items.Remove(itemToDestroy);
            Destroy(itemToDestroy);

            // Invoque l'�v�nement de destruction pour cr�er un nouveau cube
            destruction.Invoke();
        }
    }

    public List<GameObject> GetItems() { return items; }
}
