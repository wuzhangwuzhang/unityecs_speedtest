//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C128Component ecsSchmidC128 { get { return (EcsSchmid.C128Component)GetComponent(GameComponentsLookup.EcsSchmidC128); } }
    public bool hasEcsSchmidC128 { get { return HasComponent(GameComponentsLookup.EcsSchmidC128); } }

    public void AddEcsSchmidC128(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC128;
        var component = CreateComponent<EcsSchmid.C128Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC128(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC128;
        var component = CreateComponent<EcsSchmid.C128Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC128() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC128);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC128;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC128 {
        get {
            if (_matcherEcsSchmidC128 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC128);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC128 = matcher;
            }

            return _matcherEcsSchmidC128;
        }
    }
}
