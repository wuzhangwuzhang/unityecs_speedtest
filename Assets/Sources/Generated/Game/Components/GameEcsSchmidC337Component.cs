//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C337Component ecsSchmidC337 { get { return (EcsSchmid.C337Component)GetComponent(GameComponentsLookup.EcsSchmidC337); } }
    public bool hasEcsSchmidC337 { get { return HasComponent(GameComponentsLookup.EcsSchmidC337); } }

    public void AddEcsSchmidC337(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC337;
        var component = CreateComponent<EcsSchmid.C337Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC337(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC337;
        var component = CreateComponent<EcsSchmid.C337Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC337() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC337);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC337;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC337 {
        get {
            if (_matcherEcsSchmidC337 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC337);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC337 = matcher;
            }

            return _matcherEcsSchmidC337;
        }
    }
}