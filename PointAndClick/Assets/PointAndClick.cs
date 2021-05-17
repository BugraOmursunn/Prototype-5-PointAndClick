using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    [SerializeField] private GameObject Character;
    private Vector3 InputPos, targetPos;
    private float mousePosX, mousePosY;
    [SerializeField] private float moveSpeed;
    private Vector3 diff;
    void Update()
    {

        /* Without Mathf.Clamp
        if (Input.GetMouseButton(0))
        {
            diff = Input.mousePosition - Camera.main.WorldToScreenPoint(Character.transform.position);
            targetPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(diff.z)));
        }
        Character.transform.position = Vector3.Lerp(Character.transform.position, targetPos, Time.deltaTime * moveSpeed);
        */

        if (Input.GetMouseButton(0))
        {
            InputPos = Input.mousePosition;
            diff = InputPos - Camera.main.WorldToScreenPoint(Character.transform.position);

            mousePosX = Mathf.Clamp(InputPos.x, Screen.width / 10, Screen.width - Screen.width / 10);
            mousePosY = Mathf.Clamp(InputPos.y, Screen.height / 10, Screen.height - Screen.height / 10);

            targetPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePosX, mousePosY, Mathf.Abs(diff.z)));
        }
        Character.transform.position = Vector3.Lerp(Character.transform.position, targetPos, Time.deltaTime * moveSpeed);
    }
}
