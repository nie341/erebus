//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MoveToComponent moveTo { get { return (MoveToComponent)GetComponent(GameComponentsLookup.MoveTo); } }
    public bool hasMoveTo { get { return HasComponent(GameComponentsLookup.MoveTo); } }

    public void AddMoveTo(float newX, float newY, float newZ, float newTolerance) {
        var index = GameComponentsLookup.MoveTo;
        var component = CreateComponent<MoveToComponent>(index);
        component.x = newX;
        component.y = newY;
        component.z = newZ;
        component.tolerance = newTolerance;
        AddComponent(index, component);
    }

    public void ReplaceMoveTo(float newX, float newY, float newZ, float newTolerance) {
        var index = GameComponentsLookup.MoveTo;
        var component = CreateComponent<MoveToComponent>(index);
        component.x = newX;
        component.y = newY;
        component.z = newZ;
        component.tolerance = newTolerance;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveTo() {
        RemoveComponent(GameComponentsLookup.MoveTo);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMoveTo;

    public static Entitas.IMatcher<GameEntity> MoveTo {
        get {
            if (_matcherMoveTo == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveTo);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveTo = matcher;
            }

            return _matcherMoveTo;
        }
    }
}
