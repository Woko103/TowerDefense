using UnityEngine;

public class buildManager : MonoBehaviour
{
    public static buildManager instance;

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogError("More than one build manager");
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
