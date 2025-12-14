using UnityEngine;


public class Scenario : MonoBehaviour
{
    public Transform               CameraTarget;
    public Transform               RaycastOrigin;
    public Transform               AnimatedObject;
    public LayerMask               LayerMask;
    public RaycastType             Type;
    public QueryTriggerInteraction TriggerInteraction;
	
    public float RaycastLength = float.MaxValue;
	
    [Header("Only used for RaycastTypes:  Spherecast | SpherecastAll | Capsulecast | CapsulecastAll")]
    public float Radius = 0.5f;
	
    [Header("Only used for RaycastTypes:  Boxcast | BoxcastAll")]
    public Vector3 HalfExtents = new Vector3(0.25f, 0.25f, 0.25f);
	
    [Header("Only used for RaycastTypes:  Capsulecast | CapsulecastAll")]
    public float Height = 0.25f;


    public enum RaycastType
    {
        Raycast,
        RaycastAll,
        Spherecast,
        SpherecastAll,
        Capsulecast,
        CapsulecastAll,
        Boxcast,
        BoxcastAll
    }
	
	
}	// class Scenario
