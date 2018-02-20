//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C3Component ecsSchmidC3 { get { return (EcsSchmid.C3Component)GetComponent(GameComponentsLookup.EcsSchmidC3); } }
    public bool hasEcsSchmidC3 { get { return HasComponent(GameComponentsLookup.EcsSchmidC3); } }

    public void AddEcsSchmidC3(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC3;
        var component = CreateComponent<EcsSchmid.C3Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC3(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC3;
        var component = CreateComponent<EcsSchmid.C3Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC3() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC3);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC3;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC3 {
        get {
            if (_matcherEcsSchmidC3 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC3);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC3 = matcher;
            }

            return _matcherEcsSchmidC3;
        }
    }
}
