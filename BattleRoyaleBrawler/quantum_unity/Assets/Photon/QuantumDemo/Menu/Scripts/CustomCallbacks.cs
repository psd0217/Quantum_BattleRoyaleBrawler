using Quantum;
using Quantum.Demo;
using UnityEngine;

public class CustomCallbacks : QuantumCallbacks
{

  public AssetRefEntityPrototype Prototype;
  public override void OnGameStart(Quantum.QuantumGame game) {
    // paused on Start means waiting for Snapshot
    if (game.Session.IsPaused) return;

    SendLocalPlayer(game);

  }

  private void SendLocalPlayer(QuantumGame game)
  {
    foreach (var lp in game.GetLocalPlayers()) {
      Debug.Log("CustomCallbacks - sending player: " + lp);
      game.SendPlayerData(lp, new Quantum.RuntimePlayer
      {
        prefab = Prototype,
        Nickname = UIMain.Client.NickName
      });
    }
  }

  public override void OnGameResync(Quantum.QuantumGame game)
  {
    SendLocalPlayer(game);
    Debug.Log("Detected Resync. Verified tick: " + game.Frames.Verified.Number);
  }

}

