//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C416Component ecsSchmidC416 { get { return (EcsSchmid.C416Component)GetComponent(GameComponentsLookup.EcsSchmidC416); } }
    public bool hasEcsSchmidC416 { get { return HasComponent(GameComponentsLookup.EcsSchmidC416); } }

    public void AddEcsSchmidC416(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC416;
        var component = CreateComponent<EcsSchmid.C416Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC416(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC416;
        var component = CreateComponent<EcsSchmid.C416Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC416() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC416);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC416;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC416 {
        get {
            if (_matcherEcsSchmidC416 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC416);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC416 = matcher;
            }

            return _matcherEcsSchmidC416;
        }
    }
}
