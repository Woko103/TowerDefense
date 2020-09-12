using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 6f;

    private Transform target;
    private int waypointIndex = 0;

    void Start ()
    {
        target = waypoint.waypoints[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= waypoint.waypoints.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        waypointIndex++;
        target = waypoint.waypoints[waypointIndex];
    }
}
