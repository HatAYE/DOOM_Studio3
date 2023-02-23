using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    // Range at which Item can be picked up
    public float RangeRadius;
    [Range(0, 360)]
    // Angle from player forward where itm can be picked up
    public float FOVAngle;
    public LayerMask ItemMask;
    public LayerMask WallMask;
    public Vector3 directionToItem;
    // Item that can be picked up
    public GameObject ItemInView;
    // Transform component of item that can be picked up
    public Transform ItemTransform;

    private void Update()
    {
        FieldOfViewCheck();

        if (ItemInView != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(ItemInView);
            }
        }
    }

    //Check if Item is in player FOV
    private void FieldOfViewCheck()
    {
        Collider[] CollidersInRange = Physics.OverlapSphere(transform.position, RangeRadius, ItemMask);

        if (CollidersInRange.Length != 0)
        {
            ItemTransform = CollidersInRange[0].transform;

            directionToItem = (ItemTransform.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToItem) < FOVAngle / 2)
            {
                float distanceToItem = Vector3.Distance(transform.position, ItemTransform.position);

                if (!Physics.Raycast(transform.position, directionToItem, distanceToItem, WallMask))
                {
                    ItemInView = CollidersInRange[0].gameObject;
                }
            }
        }
    }
}