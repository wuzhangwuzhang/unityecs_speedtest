//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C77Component ecsSchmidC77 { get { return (EcsSchmid.C77Component)GetComponent(GameComponentsLookup.EcsSchmidC77); } }
    public bool hasEcsSchmidC77 { get { return HasComponent(GameComponentsLookup.EcsSchmidC77); } }

    public void AddEcsSchmidC77(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC77;
        var component = CreateComponent<EcsSchmid.C77Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC77(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC77;
        var component = CreateComponent<EcsSchmid.C77Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC77() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC77);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC77;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC77 {
        get {
            if (_matcherEcsSchmidC77 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC77);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC77 = matcher;
            }

            return _matcherEcsSchmidC77;
        }
    }
}
