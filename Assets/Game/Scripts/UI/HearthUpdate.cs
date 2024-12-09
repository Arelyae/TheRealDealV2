using System.Collections.Generic;
using UnityEngine;

public class GameObjectManager : MonoBehaviour
{
    // List to store references to GameObjects
    public List<GameObject> gameObjectList;

    void Start()
    {
    }

    // Function to hide the last GameObject in the list
    public void HideLastGameObject()
    {
        if (gameObjectList.Count > 0)
        {
            // Get the last GameObject in the list
            GameObject lastGameObject = gameObjectList[gameObjectList.Count - 1];

            // Deactivate the GameObject
            lastGameObject.SetActive(false);

            // Remove the GameObject from the list
            gameObjectList.RemoveAt(gameObjectList.Count - 1);
        }
    }

    // Function to show all GameObjects
    public void ShowAllGameObjects()
    {
        // Loop through all GameObjects in the list and activate them
        foreach (GameObject obj in gameObjectList)
        {
            obj.SetActive(true);
        }
    }
}
