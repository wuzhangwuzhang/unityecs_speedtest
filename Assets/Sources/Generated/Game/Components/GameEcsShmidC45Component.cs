//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C45Component ecsShmidC45 { get { return (EcsShmid.C45Component)GetComponent(GameComponentsLookup.EcsShmidC45); } }
    public bool hasEcsShmidC45 { get { return HasComponent(GameComponentsLookup.EcsShmidC45); } }

    public void AddEcsShmidC45(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC45;
        var component = CreateComponent<EcsShmid.C45Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC45(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC45;
        var component = CreateComponent<EcsShmid.C45Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC45() {
        RemoveComponent(GameComponentsLookup.EcsShmidC45);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC45;

    public static Entitas.IMatcher<GameEntity> EcsShmidC45 {
        get {
            if (_matcherEcsShmidC45 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC45);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC45 = matcher;
            }

            return _matcherEcsShmidC45;
        }
    }
}
