//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly AbleToMoveComponent ableToMoveComponent = new AbleToMoveComponent();

    public bool isAbleToMove {
        get { return HasComponent(GameComponentsLookup.AbleToMove); }
        set {
            if (value != isAbleToMove) {
                if (value) {
                    AddComponent(GameComponentsLookup.AbleToMove, ableToMoveComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.AbleToMove);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherAbleToMove;

    public static Entitas.IMatcher<GameEntity> AbleToMove {
        get {
            if (_matcherAbleToMove == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AbleToMove);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAbleToMove = matcher;
            }

            return _matcherAbleToMove;
        }
    }
}