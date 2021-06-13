using System.Collections;
using System.Collections.Generic;
using Quantum;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform _target;

    public Vector3 Offset;

    public float Speed = 3;

    // Update is called once per frame
    void LateUpdate()
    {
        if (_target == null)
        {
            var frame = QuantumRunner.Default?.Game?.Frames.Verified;
            if(frame == null) return;

            var lgcs = GameObject.FindObjectsOfType<LittleGirlController>();
            foreach(var lgc in lgcs)
            {
                var e = lgc.GetComponent<EntityView>().EntityRef;
                var fg = frame.Get<FallGirl>(e);
                if (QuantumRunner.Default.Session.IsLocalPlayer(fg.Player))
                {
                    _target = lgc.transform;
                }
            }
            return;
        }

        transform.position = Vector3.Lerp(transform.position, _target.position + Offset, Time.deltaTime * Speed);
    }
}
