using UnityEngine;

public class NPCController : MonoBehaviour
{
    public Character character;
    public GameObject Target;
    public float minimalDistanceFromTarget = 1;
    void Update()
    {
        float distance = (transform.position - Target.transform.position).magnitude;
        if (distance < minimalDistanceFromTarget) character.Move((transform.position - Target.transform.position).normalized * minimalDistanceFromTarget);
    }
}
