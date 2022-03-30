using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefabs;
   public int columnPoolsize = 5;
    public float spawnedRate = 3f;

    private GameObject[] columns;

    private Vector2 ColumnPoolPosition=new Vector2(-30, -30);
    public float ColumnXPosition = 9;
    public float ColumnYPosition; 


    private float minY = -2f;
    private float maxY = 1f;
    private int CurrentColumnIndex = 0;
    private float timeSinceSpawned = 0;


    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolsize];
        for (int i = 0; i < columnPoolsize; i++)

            columns[i] = Instantiate(columnPrefabs, ColumnPoolPosition, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.ins.GameOver)
            return;
        timeSinceSpawned += Time.deltaTime;
        if(timeSinceSpawned >= spawnedRate)
        {
            timeSinceSpawned = 0;
            ColumnYPosition = Random.Range(minY, maxY);
            columns[CurrentColumnIndex].transform.position = new Vector2(ColumnXPosition, ColumnYPosition);
            CurrentColumnIndex++;

            if (CurrentColumnIndex >= columnPoolsize) 
            CurrentColumnIndex = 0;
        }
    }
}
