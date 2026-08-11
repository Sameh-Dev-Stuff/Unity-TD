using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class GridPlacement : MonoBehaviour
{
    [SerializeField] private GameObject prefabDefender;
    [SerializeField] private TMP_Text objectCountText;
    [SerializeField] private Camera mineCamera;
    [SerializeField] private Grid grid;
    [SerializeField] private LayerMask placementLayerMask;

    private int objectCount = 0;

    private HashSet<Vector3Int> CELL = new HashSet<Vector3Int>();

    private void Update()
    {
        if (Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            PlaceDefender();
        }
    }

    private void PlaceDefender()
    {
        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
         
        Ray ray = mineCamera.ScreenPointToRay(touchPosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray,out hitInfo,Mathf.Infinity,placementLayerMask))
        { 
            Vector3Int cellPos = grid.WorldToCell(hitInfo.point);
            Vector3 placementWorldPos = grid.GetCellCenterWorld(cellPos);
            
            
            
            if (CELL.Contains(cellPos) == false)
            {
                Instantiate(prefabDefender ,placementWorldPos ,Quaternion.identity);
                objectCount++;
                objectCountText.text = $"Object: {objectCount}";
            }

            CELL.Add(cellPos);
        }
        
    }
}