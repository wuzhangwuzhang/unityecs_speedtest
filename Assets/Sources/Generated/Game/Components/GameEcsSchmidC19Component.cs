//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C19Component ecsSchmidC19 { get { return (EcsSchmid.C19Component)GetComponent(GameComponentsLookup.EcsSchmidC19); } }
    public bool hasEcsSchmidC19 { get { return HasComponent(GameComponentsLookup.EcsSchmidC19); } }

    public void AddEcsSchmidC19(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC19;
        var component = CreateComponent<EcsSchmid.C19Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC19(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC19;
        var component = CreateComponent<EcsSchmid.C19Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC19() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC19);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC19;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC19 {
        get {
            if (_matcherEcsSchmidC19 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC19);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC19 = matcher;
            }

            return _matcherEcsSchmidC19;
        }
    }
}
