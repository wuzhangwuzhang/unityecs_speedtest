//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C77Component ecsShmidC77 { get { return (EcsShmid.C77Component)GetComponent(GameComponentsLookup.EcsShmidC77); } }
    public bool hasEcsShmidC77 { get { return HasComponent(GameComponentsLookup.EcsShmidC77); } }

    public void AddEcsShmidC77(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsShmidC77;
        var component = CreateComponent<EcsShmid.C77Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC77(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsShmidC77;
        var component = CreateComponent<EcsShmid.C77Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC77() {
        RemoveComponent(GameComponentsLookup.EcsShmidC77);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC77;

    public static Entitas.IMatcher<GameEntity> EcsShmidC77 {
        get {
            if (_matcherEcsShmidC77 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC77);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC77 = matcher;
            }

            return _matcherEcsShmidC77;
        }
    }
}
