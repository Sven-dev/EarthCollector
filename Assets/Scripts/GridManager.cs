using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Row RowPrefab;
    [SerializeField] private Block BlockPrefab;
    [Space]
    [SerializeField] private List<Color> BlockColors;
    [Space]
    [SerializeField] private Grid Grid;

    // Start is called before the first frame update
    void Start()
    {
        PopulateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PopulateGrid()
    {
        for (int i = 0; i < 6; i++)
        {
            Row row = Instantiate(RowPrefab, transform);
            row.transform.localPosition = new Vector3(0, -i, 0);
            Grid.Rows.Add(row);

            for (int j = 0; j < 7; j++)
            {
                Block block = Instantiate(BlockPrefab, row.transform.GetChild(j));
                row.blocks.Add(block);

                block.SetColor(GetRandomColor());
            }
        }
    }

    private Color GetRandomColor()
    {
        int rnd = Random.Range(0, BlockColors.Count);
        return BlockColors[rnd];
    }
}