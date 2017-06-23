using Entitas;

public sealed class ReactiveSystems : Feature {
  public ReactiveSystems(Contexts contexts) : base("Reactive Systems") {
    Add(new AddViewSystem(contexts));
    Add(new RemoveViewSystem(contexts));
    Add(new RenderPositionSystem(contexts));
    Add(new RenderScaleSystem(contexts));
    Add(new DestroySystem(contexts));
  }
}