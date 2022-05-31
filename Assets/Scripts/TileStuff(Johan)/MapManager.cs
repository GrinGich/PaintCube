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

    [SerializeField]
    public Transform Player;
    private void Update()
    {
        /*This line of code turns the coordinates of the player and transforms them into a vector, 
          and checks if those coordinates are above a tile*/
        if (map.GetTile(Vector3Int.FloorToInt(Player.position)).name == "Blank")
        {
            map.SetTile(Vector3Int.FloorToInt(Player.position), måladTile);
        }
    }
}
