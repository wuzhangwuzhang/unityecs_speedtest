//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C119Component ecsSchmidC119 { get { return (EcsSchmid.C119Component)GetComponent(GameComponentsLookup.EcsSchmidC119); } }
    public bool hasEcsSchmidC119 { get { return HasComponent(GameComponentsLookup.EcsSchmidC119); } }

    public void AddEcsSchmidC119(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC119;
        var component = CreateComponent<EcsSchmid.C119Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC119(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC119;
        var component = CreateComponent<EcsSchmid.C119Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC119() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC119);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC119;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC119 {
        get {
            if (_matcherEcsSchmidC119 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC119);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC119 = matcher;
            }

            return _matcherEcsSchmidC119;
        }
    }
}