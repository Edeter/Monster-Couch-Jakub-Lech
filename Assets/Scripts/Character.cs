using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] public Vector2 xLimit;
    [SerializeField] public Vector2 yLimit;

    public void Move(Vector2 value)
    {
       Vector3 finalPos =  transform.position + (Vector3)value*Time.deltaTime * speed;
        finalPos.x = Mathf.Clamp(finalPos.x, xLimit.x, xLimit.y);
        finalPos.y = Mathf.Clamp(finalPos.y, yLimit.x, yLimit.y);
        transform.position = finalPos;

    }
}
