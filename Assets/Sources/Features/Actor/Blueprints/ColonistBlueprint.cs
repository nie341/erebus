using Entitas;
using UnityEngine;

public sealed class ColonistBlueprint {
  public static GameEntity Create(float x, float z) {
    var colonist = Contexts.sharedInstance.game.CreateEntity();
    colonist.AddAsset("Prefabs/Colonist");
    colonist.AddPosition(x, 0, z);
    colonist.AddSpeed(Random.Range(5f, 7f));
    colonist.AddGoal(30f, 53f);
    colonist.isOwnedByPlayer = true;
    colonist.isWorker = true;
    return colonist;
  }
}
