//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C212Component ecsSchmidC212 { get { return (EcsSchmid.C212Component)GetComponent(GameComponentsLookup.EcsSchmidC212); } }
    public bool hasEcsSchmidC212 { get { return HasComponent(GameComponentsLookup.EcsSchmidC212); } }

    public void AddEcsSchmidC212(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC212;
        var component = CreateComponent<EcsSchmid.C212Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC212(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC212;
        var component = CreateComponent<EcsSchmid.C212Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC212() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC212);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC212;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC212 {
        get {
            if (_matcherEcsSchmidC212 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC212);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC212 = matcher;
            }

            return _matcherEcsSchmidC212;
        }
    }
}
