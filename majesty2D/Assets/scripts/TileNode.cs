[System.Serializable]
public struct TileNode {
    //Can this tile be travelled through.
    public bool m_IsPassable;
    //Can units pass through this tile.
    public bool m_IsWalkable;
    //Cost of passing through on foot.
    public float m_WalkCost;
    //Cost of passing through in the air.
    public float m_AirCost;
    //Tile X Location.
    public int X;
    //tile Y Location.
    public int Y;
}
