//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C120Component ecsSchmidC120 { get { return (EcsSchmid.C120Component)GetComponent(GameComponentsLookup.EcsSchmidC120); } }
    public bool hasEcsSchmidC120 { get { return HasComponent(GameComponentsLookup.EcsSchmidC120); } }

    public void AddEcsSchmidC120(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC120;
        var component = CreateComponent<EcsSchmid.C120Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC120(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC120;
        var component = CreateComponent<EcsSchmid.C120Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC120() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC120);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC120;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC120 {
        get {
            if (_matcherEcsSchmidC120 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC120);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC120 = matcher;
            }

            return _matcherEcsSchmidC120;
        }
    }
}