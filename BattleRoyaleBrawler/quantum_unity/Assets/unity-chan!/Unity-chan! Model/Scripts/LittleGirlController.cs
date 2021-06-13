using System.Collections;
using System.Collections.Generic;
using Quantum;
using UnityEngine;

public class LittleGirlController : MonoBehaviour
{
    private EntityView _root;
    public Animator Animator;

    public float AnimationSpeedModifier = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _root = GetComponent<EntityView>();
    }

    // Update is called once per frame
    void Update()
    {
        var body3D = QuantumRunner.Default.Game.Frames.Verified.Get<PhysicsBody3D>(_root.EntityRef);
        var speed = body3D.Velocity.XZ.Magnitude.AsFloat;
        if (speed > 0.01f)
        {
            Animator.SetFloat("Speed",speed);
            Animator.speed = AnimationSpeedModifier * speed;
        }
        else
        {
            Animator.SetFloat("speed",0);
            Animator.speed = 1;
        }
    }
}
