//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C399Component ecsSchmidC399 { get { return (EcsSchmid.C399Component)GetComponent(GameComponentsLookup.EcsSchmidC399); } }
    public bool hasEcsSchmidC399 { get { return HasComponent(GameComponentsLookup.EcsSchmidC399); } }

    public void AddEcsSchmidC399(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC399;
        var component = CreateComponent<EcsSchmid.C399Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC399(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC399;
        var component = CreateComponent<EcsSchmid.C399Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC399() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC399);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC399;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC399 {
        get {
            if (_matcherEcsSchmidC399 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC399);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC399 = matcher;
            }

            return _matcherEcsSchmidC399;
        }
    }
}
