using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour {

    private int xSize;
    private int ySize;

    private TileNode[,] m_Grid;

    private void Start()
    {
        
    }

    public int YSize
    {
        get
        {
            return ySize;
        }

        set
        {
            ySize = value;
        }
    }

    public int XSize
    {
        get
        {
            return xSize;
        }

        set
        {
            xSize = value;
        }
    }

    //Draws the node map.
    private void OnDrawGizmos()
    {
        
    }
}


