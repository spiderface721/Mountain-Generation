using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] int height;
    [SerializeField] int width;

    [SerializeField] Vector2 spaceBetweenPoints;
    [SerializeField] Vector2 startPos;


    [SerializeField] GameObject blockPrefab;

    [SerializeField] List<GameObject> blocksList = new List<GameObject>();
    void GenerateShape()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Vector2 newPos;
                newPos.x = startPos.x + j * spaceBetweenPoints.x;
                newPos.y = startPos.y + i * spaceBetweenPoints.y;
                GameObject newBlock = Instantiate(blockPrefab, newPos, Quaternion.identity);
                blocksList.Add(newBlock);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateShape();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
