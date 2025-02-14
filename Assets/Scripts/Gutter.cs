using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider ball)
    {
        Rigidbody ballRigidBody = ball.GetComponent<Rigidbody>();
        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;
        ballRigidBody.linearVelocity = Vector3.zero;
        ballRigidBody.angularVelocity = Vector3.zero;
        ballRigidBody.AddForce(transform.forward * velocityMagnitude,ForceMode.VelocityChange);
    }
   
}
