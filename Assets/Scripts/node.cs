﻿using UnityEngine;
using UnityEngine.EventSystems;

public class node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    buildManager buildManager;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = buildManager.instance;
    }

    private void OnMouseDown()
    {
        if(buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (turret != null)
        {
            return;
        }

        GameObject turretToBuild = buildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if(buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
