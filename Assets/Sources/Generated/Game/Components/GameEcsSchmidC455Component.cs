//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C455Component ecsSchmidC455 { get { return (EcsSchmid.C455Component)GetComponent(GameComponentsLookup.EcsSchmidC455); } }
    public bool hasEcsSchmidC455 { get { return HasComponent(GameComponentsLookup.EcsSchmidC455); } }

    public void AddEcsSchmidC455(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC455;
        var component = CreateComponent<EcsSchmid.C455Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC455(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC455;
        var component = CreateComponent<EcsSchmid.C455Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC455() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC455);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC455;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC455 {
        get {
            if (_matcherEcsSchmidC455 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC455);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC455 = matcher;
            }

            return _matcherEcsSchmidC455;
        }
    }
}
