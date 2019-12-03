using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManhattanDistance : IHeuristics
{
    public int GetDistance(Node node, Node goal)
    {
        int ix = Mathf.Abs(node.iGridX - goal.iGridX);
        int iy = Mathf.Abs(node.iGridY - goal.iGridY);
        return (ix + iy);
    }
}

public class DiagonalDistance : IHeuristics
{
    const int D = 1;
    const int D2 = 1;
    public int GetDistance(Node node, Node goal)
    {
        int ix = Mathf.Abs(node.iGridX - goal.iGridX);//x1-x2
        int iy = Mathf.Abs(node.iGridY - goal.iGridY);//y1-y2    

        return D * (ix + iy) + (D2 - 2 * D) * (int)Mathf.Min(ix, iy);
    }
}
public class EuclideanDistance : IHeuristics
{
    public int GetDistance(Node node, Node goal)
    {
        int ix = Mathf.Abs(node.iGridX - goal.iGridX);//x1-x2
        int iy = Mathf.Abs(node.iGridY - goal.iGridY);//y1-y2


        return (int)Mathf.Sqrt(ix * ix + iy * iy);
    }
}
