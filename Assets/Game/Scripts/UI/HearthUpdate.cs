using System.Collections.Generic;
using UnityEngine;

public class GameObjectManager : MonoBehaviour
{
    // List to store references to GameObjects (set via Inspector or dynamically)
    public List<GameObject> gameObjectList;
    public int listCount;

    void Start()
    {
        listCount = gameObjectList.Count;
        // Optionally initialize or debug if the list is empty
        if (gameObjectList.Count == 0)
        {
            Debug.LogWarning("GameObject list is empty. Please add GameObjects in the Inspector.");
        }
    }

    // Function to hide the last GameObject in the list (without removing it)
    public void HideLastGameObject()
    {
        if (gameObjectList.Count > 0)
        {
            // Get the last GameObject in the list
            GameObject lastGameObject = gameObjectList[listCount - 1];

            // Deactivate the GameObject
            lastGameObject.SetActive(false);
            listCount -=1;
        }
    }

    // Function to show all GameObjects
    public void ShowAllGameObjects()
    {
        // Loop through all GameObjects in the list and activate them
        foreach (GameObject obj in gameObjectList)
        {
            obj.SetActive(true);
            listCount = gameObjectList.Count;
        }
    }
}