//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C389Component ecsSchmidC389 { get { return (EcsSchmid.C389Component)GetComponent(GameComponentsLookup.EcsSchmidC389); } }
    public bool hasEcsSchmidC389 { get { return HasComponent(GameComponentsLookup.EcsSchmidC389); } }

    public void AddEcsSchmidC389(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC389;
        var component = CreateComponent<EcsSchmid.C389Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC389(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC389;
        var component = CreateComponent<EcsSchmid.C389Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC389() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC389);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC389;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC389 {
        get {
            if (_matcherEcsSchmidC389 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC389);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC389 = matcher;
            }

            return _matcherEcsSchmidC389;
        }
    }
}