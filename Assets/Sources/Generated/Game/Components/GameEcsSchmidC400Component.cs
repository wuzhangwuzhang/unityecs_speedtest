//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C400Component ecsSchmidC400 { get { return (EcsSchmid.C400Component)GetComponent(GameComponentsLookup.EcsSchmidC400); } }
    public bool hasEcsSchmidC400 { get { return HasComponent(GameComponentsLookup.EcsSchmidC400); } }

    public void AddEcsSchmidC400(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC400;
        var component = CreateComponent<EcsSchmid.C400Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC400(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC400;
        var component = CreateComponent<EcsSchmid.C400Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC400() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC400);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC400;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC400 {
        get {
            if (_matcherEcsSchmidC400 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC400);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC400 = matcher;
            }

            return _matcherEcsSchmidC400;
        }
    }
}