using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TimedObjectPlacer : MonoBehaviour
{
    public GameObject Prefab;

    public Collider2D SpawnArea;
    
    public float minimumSecondsToWait;
    public float maximumSecondsToWait;

    private bool isOkToCreate = true;
    private bool isActive = false;
    private Coroutine countdownCoroutine;
    void Update()
    {
        if (!isActive)
            return;
        
        if (isOkToCreate)
        {
            countdownCoroutine = StartCoroutine(CountdownUnitlCreation());
        }
    }

    public void StartPlacing()
    {
        isActive = true;
        isOkToCreate = true;
    }
    
    public void StopPlacing()
    {
        isActive = false;
        isOkToCreate = false;

        if (countdownCoroutine != null)
            StopCoroutine(countdownCoroutine);

        CleanupPlacedObjects();
    }
    
    private void CleanupPlacedObjects()
    {
        List<GameObject> placedObjects = GameObject.FindGameObjectsWithTag(Prefab.tag).ToList();

        for (int i = 0; i < placedObjects.Count; i++)
        {
            Destroy(placedObjects[i]);
        }
    }

    IEnumerator CountdownUnitlCreation()
    {
        isOkToCreate = false;
        
        float secondsToWait = Random.Range(minimumSecondsToWait, maximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        
        isOkToCreate = true;
    }

    protected virtual void Place()
    {
        Instantiate(Prefab, GetRandomSpawnArea(), Quaternion.identity);
    }

    private Vector3 GetRandomSpawnArea()
    {
        Bounds bounds = SpawnArea.bounds;

        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomY = Random.Range(bounds.min.y, bounds.max.y);
        
        return new Vector3(randomX, randomY, 0f);
    }
}