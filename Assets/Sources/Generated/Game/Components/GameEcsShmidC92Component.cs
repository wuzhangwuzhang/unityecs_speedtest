//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C92Component ecsShmidC92 { get { return (EcsShmid.C92Component)GetComponent(GameComponentsLookup.EcsShmidC92); } }
    public bool hasEcsShmidC92 { get { return HasComponent(GameComponentsLookup.EcsShmidC92); } }

    public void AddEcsShmidC92(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC92;
        var component = CreateComponent<EcsShmid.C92Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC92(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC92;
        var component = CreateComponent<EcsShmid.C92Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC92() {
        RemoveComponent(GameComponentsLookup.EcsShmidC92);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC92;

    public static Entitas.IMatcher<GameEntity> EcsShmidC92 {
        get {
            if (_matcherEcsShmidC92 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC92);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC92 = matcher;
            }

            return _matcherEcsShmidC92;
        }
    }
}
