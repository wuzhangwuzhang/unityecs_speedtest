//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C226Component ecsSchmidC226 { get { return (EcsSchmid.C226Component)GetComponent(GameComponentsLookup.EcsSchmidC226); } }
    public bool hasEcsSchmidC226 { get { return HasComponent(GameComponentsLookup.EcsSchmidC226); } }

    public void AddEcsSchmidC226(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC226;
        var component = CreateComponent<EcsSchmid.C226Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC226(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC226;
        var component = CreateComponent<EcsSchmid.C226Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC226() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC226);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC226;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC226 {
        get {
            if (_matcherEcsSchmidC226 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC226);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC226 = matcher;
            }

            return _matcherEcsSchmidC226;
        }
    }
}
