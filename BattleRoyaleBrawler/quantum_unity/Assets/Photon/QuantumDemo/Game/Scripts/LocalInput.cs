using System;
using Photon.Deterministic;
using Quantum;
using UnityEngine;

public class LocalInput : MonoBehaviour {
    
  private void OnEnable() {
    QuantumCallback.Subscribe(this, (CallbackPollInput callback) => PollInput(callback));
  }

  public void PollInput(CallbackPollInput callback) {
    Quantum.Input i = new Quantum.Input();

    i.Jump = UnityEngine.Input.GetButton("Jump");

    var x = UnityEngine.Input.GetAxis("Horizontal").ToFP();
    var y = UnityEngine.Input.GetAxis("Vertical").ToFP();

    i.Direction = new FPVector2(x, y);
    
    callback.SetInput(i, DeterministicInputFlags.Repeatable);
  }
}
