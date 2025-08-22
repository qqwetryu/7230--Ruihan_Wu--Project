This document is a place to paste raw prompts and references for a particular activity. This allows for better referencing in code and documentaion.

---

Me:

"please write me some cool Unity code"

ChatGPT:

Here’s a small but flashy Unity example you can drop into a new scene to get something fun moving right away—a "Gravity Orb" script that makes a glowing sphere float, pulse, and attract nearby objects like a mini black hole.

using UnityEngine;

public class GravityOrb : MonoBehaviour
{
    public float pulseSpeed = 2f;       // How fast the glow pulses
    public float pulseStrength = 0.3f;  // How much it changes size
    public float attractionRadius = 5f; // How far it pulls objects
    public float attractionForce = 10f; // How strong the pull is
    public Color glowColor = Color.cyan;

    private Vector3 baseScale;
    private Light orbLight;

    void Start()
    {
        baseScale = transform.localScale;

        // Add a light so it glows
        orbLight = gameObject.AddComponent<Light>();
        orbLight.type = LightType.Point;
        orbLight.color = glowColor;
        orbLight.intensity = 5f;
        orbLight.range = 6f;
    }

    void Update()
    {
        // Pulsing effect
        float pulse = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseStrength;
        transform.localScale = baseScale * pulse;
        orbLight.intensity = 3f + Mathf.Sin(Time.time * pulseSpeed) * 2f;

        // Pull in nearby rigidbodies
        Collider[] hits = Physics.OverlapSphere(transform.position, attractionRadius);
        foreach (var hit in hits)
        {
            Rigidbody rb = hit.attachedRigidbody;
            if (rb != null && rb.gameObject != gameObject)
            {
                Vector3 dir = (transform.position - rb.position).normalized;
                rb.AddForce(dir * attractionForce * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        // Show attraction range in the editor
        Gizmos.color = new Color(0, 1, 1, 0.25f);
        Gizmos.DrawSphere(transform.position, attractionRadius);
    }
}


How to use:
Create a new empty GameObject in Unity and name it GravityOrb.

Add a Sphere mesh as a child (scale it to around 1,1,1).

Attach this script to the parent object.

Add a few cubes or rigidbodies nearby, hit Play, and watch them get pulled in while the orb pulses and glows.

