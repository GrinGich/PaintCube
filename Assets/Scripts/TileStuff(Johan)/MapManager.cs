using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    //This line of code creates a reference to the tilemap.
    [SerializeField]
    private Tilemap map;
    [SerializeField]
    TileBase måladTile;

    private void Update()
    {
        //Ersätt 0,0,0 med spelarens position
        //if (map.GetTile(new Vector3Int(GameObject.FindWithTag("player").transform.position)).name == "Blank")
        {
            map.SetTile(new Vector3Int(0, 0, 0),måladTile);
        }
    }
}
