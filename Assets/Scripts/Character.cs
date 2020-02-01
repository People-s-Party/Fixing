using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 StartPostion;
    public float PlayerSpeed;
    public float rotateSpeed = 2f;
    private Quaternion targetAngels = Quaternion.Euler(0, 0, 0);
    void Start()
    {
        transform.position = Vector3.MoveTowards(transform.position, StartPostion, 10000);
    }

    void Update()
    {
        
        Vector3 playerposition = transform.position;
        float MoveX = 0;
        float MoveY = 0;
        if (Input.GetKey(KeyCode.W))
        {
            targetAngels = Quaternion.Euler(0, 0, 0);
            MoveY += Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetAngels = Quaternion.Euler(0, 180f, 0);
            MoveY -= Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            targetAngels = Quaternion.Euler(0, 90f, 0);
            MoveX -= Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetAngels = Quaternion.Euler(0, -90, 0);
            MoveX += Time.deltaTime * PlayerSpeed;
        }
        if (playerposition.x + MoveX <= -8 || playerposition.x + MoveX >= 8.5) MoveX = 0;
        if (playerposition.y + MoveY <= -4.5 || playerposition.y + MoveY >= 3) MoveY = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetAngels, rotateSpeed * Time.deltaTime);
        if (Quaternion.Angle(targetAngels, transform.rotation) < 1)
        {
            transform.rotation = targetAngels;
        }
        if (MoveX!=0)transform.Translate(MoveX, 0, 0);
        else transform.Translate(0, MoveY, 0);

    }
}
