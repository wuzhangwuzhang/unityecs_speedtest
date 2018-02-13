//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C9Component ecsShmidC9 { get { return (EcsShmid.C9Component)GetComponent(GameComponentsLookup.EcsShmidC9); } }
    public bool hasEcsShmidC9 { get { return HasComponent(GameComponentsLookup.EcsShmidC9); } }

    public void AddEcsShmidC9(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC9;
        var component = CreateComponent<EcsShmid.C9Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC9(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC9;
        var component = CreateComponent<EcsShmid.C9Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC9() {
        RemoveComponent(GameComponentsLookup.EcsShmidC9);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC9;

    public static Entitas.IMatcher<GameEntity> EcsShmidC9 {
        get {
            if (_matcherEcsShmidC9 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC9);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC9 = matcher;
            }

            return _matcherEcsShmidC9;
        }
    }
}
