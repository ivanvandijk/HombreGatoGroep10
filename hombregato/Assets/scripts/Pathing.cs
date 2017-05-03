using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour {

    [SerializeField] private bool DrawGizmos;
    [SerializeField] private Transform[] _Waypoints;

    public Transform[] GetWayPoints()
    {
        return _Waypoints;
    }

    void OnDrawGizmos()
    {
        if (DrawGizmos)
        {
            Gizmos.color = Color.red;
            for(int i = 1; i < _Waypoints.Length; i++)
            {
                Gizmos.DrawLine(_Waypoints[i].position,
                                    _Waypoints[i - 1].position);
            }
        }
    }
}
