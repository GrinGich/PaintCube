using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This line of code lets the code 
using UnityEngine.Tilemaps;


[CreateAssetMenu]
public class Outline : ScriptableObject
{
    //This line of code creates a variable for the tiles
    Tilemap map;
    //This line of code creates a reference to the tile.
    public TileBase[] tiles;

    
}
