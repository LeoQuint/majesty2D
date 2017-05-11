using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSP_Game;

public class Tile : MonoBehaviour {

    public TileLayer m_Tile;

    public  TileNode m_Node;

#if UNITY_EDITOR
    void OnValidate()
    {
        Debug.Log("Validating");
        UpdateTile();
    }
#endif


    void UpdateTile()
    {

    }
}
