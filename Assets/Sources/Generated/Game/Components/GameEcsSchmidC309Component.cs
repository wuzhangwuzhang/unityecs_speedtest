//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C309Component ecsSchmidC309 { get { return (EcsSchmid.C309Component)GetComponent(GameComponentsLookup.EcsSchmidC309); } }
    public bool hasEcsSchmidC309 { get { return HasComponent(GameComponentsLookup.EcsSchmidC309); } }

    public void AddEcsSchmidC309(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC309;
        var component = CreateComponent<EcsSchmid.C309Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC309(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC309;
        var component = CreateComponent<EcsSchmid.C309Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC309() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC309);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC309;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC309 {
        get {
            if (_matcherEcsSchmidC309 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC309);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC309 = matcher;
            }

            return _matcherEcsSchmidC309;
        }
    }
}
