using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHeuristics
{
    int GetDistance(Node node, Node goal);
}
