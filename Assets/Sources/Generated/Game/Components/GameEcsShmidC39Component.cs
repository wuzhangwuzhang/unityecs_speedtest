//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C39Component ecsShmidC39 { get { return (EcsShmid.C39Component)GetComponent(GameComponentsLookup.EcsShmidC39); } }
    public bool hasEcsShmidC39 { get { return HasComponent(GameComponentsLookup.EcsShmidC39); } }

    public void AddEcsShmidC39(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC39;
        var component = CreateComponent<EcsShmid.C39Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC39(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC39;
        var component = CreateComponent<EcsShmid.C39Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC39() {
        RemoveComponent(GameComponentsLookup.EcsShmidC39);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC39;

    public static Entitas.IMatcher<GameEntity> EcsShmidC39 {
        get {
            if (_matcherEcsShmidC39 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC39);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC39 = matcher;
            }

            return _matcherEcsShmidC39;
        }
    }
}
