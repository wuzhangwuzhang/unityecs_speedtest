//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C89Component ecsShmidC89 { get { return (EcsShmid.C89Component)GetComponent(GameComponentsLookup.EcsShmidC89); } }
    public bool hasEcsShmidC89 { get { return HasComponent(GameComponentsLookup.EcsShmidC89); } }

    public void AddEcsShmidC89(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC89;
        var component = CreateComponent<EcsShmid.C89Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC89(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC89;
        var component = CreateComponent<EcsShmid.C89Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC89() {
        RemoveComponent(GameComponentsLookup.EcsShmidC89);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC89;

    public static Entitas.IMatcher<GameEntity> EcsShmidC89 {
        get {
            if (_matcherEcsShmidC89 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC89);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC89 = matcher;
            }

            return _matcherEcsShmidC89;
        }
    }
}
