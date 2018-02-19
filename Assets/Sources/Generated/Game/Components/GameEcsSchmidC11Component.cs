//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C11Component ecsSchmidC11 { get { return (EcsSchmid.C11Component)GetComponent(GameComponentsLookup.EcsSchmidC11); } }
    public bool hasEcsSchmidC11 { get { return HasComponent(GameComponentsLookup.EcsSchmidC11); } }

    public void AddEcsSchmidC11(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC11;
        var component = CreateComponent<EcsSchmid.C11Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC11(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC11;
        var component = CreateComponent<EcsSchmid.C11Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC11() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC11);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC11;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC11 {
        get {
            if (_matcherEcsSchmidC11 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC11);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC11 = matcher;
            }

            return _matcherEcsSchmidC11;
        }
    }
}