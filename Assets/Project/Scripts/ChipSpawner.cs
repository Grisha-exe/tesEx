using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipSpawner : MonoBehaviour
{
    public GameObject ChipPrefab;
    public Transform[] Cells;

    public void SpawnChip()
    {
        List<Transform> freeCells = new List<Transform>();

        foreach (var cell in Cells)
        {
            if (cell.childCount == 0)
            {
                freeCells.Add(cell);
            }
        }

        if (freeCells.Count == 0)
        {
            Debug.Log("No chips spawned");
            return;
        }
        
        Transform randomCell = freeCells[Random.Range(0, freeCells.Count)];
        
        GameObject newChip = Instantiate(ChipPrefab, randomCell);
        newChip.transform.localPosition = Vector3.zero;
        newChip.transform.localScale = Vector3.one;
    }
}