//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C66Component ecsShmidC66 { get { return (EcsShmid.C66Component)GetComponent(GameComponentsLookup.EcsShmidC66); } }
    public bool hasEcsShmidC66 { get { return HasComponent(GameComponentsLookup.EcsShmidC66); } }

    public void AddEcsShmidC66(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC66;
        var component = CreateComponent<EcsShmid.C66Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC66(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsShmidC66;
        var component = CreateComponent<EcsShmid.C66Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC66() {
        RemoveComponent(GameComponentsLookup.EcsShmidC66);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC66;

    public static Entitas.IMatcher<GameEntity> EcsShmidC66 {
        get {
            if (_matcherEcsShmidC66 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC66);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC66 = matcher;
            }

            return _matcherEcsShmidC66;
        }
    }
}