using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Darkness : MonoBehaviour
{
    public Tilemap DarkMap;
    public Tilemap BlurMap;
    public Tilemap BackGroundMap;

    public Tile DarkTile;
    public Tile BlurTile;

    // Start is called before the first frame update
    void Start()
    {
        DarkMap.origin = BlurMap.origin = BackGroundMap.origin;
        DarkMap.size = BlurMap.size = BackGroundMap.size;

        foreach (Vector3Int p in DarkMap.cellBounds.allPositionsWithin)
        {
            DarkMap.SetTile(p, DarkTile);
        }
        foreach (Vector3Int p in BlurMap.cellBounds.allPositionsWithin)
        {
            BlurMap.SetTile(p, BlurTile);
        }
    }

    void Update()
    {

    }
}
