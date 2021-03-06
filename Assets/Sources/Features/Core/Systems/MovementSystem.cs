using System;
using Entitas;
using UnityEngine;

public sealed class MovementSystem : IExecuteSystem, ICleanupSystem {
  private readonly GameContext context;
  private readonly IGroup<GameEntity> moving;
  private readonly IGroup<GameEntity> completed;

  public MovementSystem(Contexts contexts) {
    context = contexts.game;
    completed = context.GetGroup(GameMatcher.MoveToCompleted);
    moving = context.GetGroup(Matcher<GameEntity>.AllOf(
      GameMatcher.MoveTo,
      GameMatcher.Speed,
      GameMatcher.Position
    ));
  }

  public void Execute() {
    var entities = moving.GetEntities();
    foreach (var entity in entities) {
      Vector3 direction = new Vector3(
        entity.moveTo.x - entity.position.x,
        entity.moveTo.y - entity.position.y,
        entity.moveTo.z - entity.position.z
      );

      Vector3 offset = direction.normalized * entity.speed.value * context.time.delta;

      entity.ReplacePosition(
        entity.position.x + offset.x,
        entity.position.y + offset.y,
        entity.position.z + offset.z
      );

      float distance = direction.magnitude;

      if (direction.magnitude <= entity.moveTo.tolerance) {
        entity.RemoveMoveTo();
        entity.isMoveToCompleted = true;
      }
    }
  }

  public void Cleanup() {
    foreach (var entity in completed.GetEntities()) {
      entity.isMoveToCompleted = false;
    }
  }
}
