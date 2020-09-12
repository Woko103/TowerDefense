using UnityEngine;

public class shop : MonoBehaviour
{
    buildManager bManager;

    private void Start() {
        bManager = buildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        bManager.SetTurretToBuild(bManager.standardTurretPrefab);
    }
    
    public void PurchaseMissileTurret()
    {
        bManager.SetTurretToBuild(bManager.missileTurretPrefab);
    }
}
