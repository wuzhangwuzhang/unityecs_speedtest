//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C459Component ecsSchmidC459 { get { return (EcsSchmid.C459Component)GetComponent(GameComponentsLookup.EcsSchmidC459); } }
    public bool hasEcsSchmidC459 { get { return HasComponent(GameComponentsLookup.EcsSchmidC459); } }

    public void AddEcsSchmidC459(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC459;
        var component = CreateComponent<EcsSchmid.C459Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC459(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC459;
        var component = CreateComponent<EcsSchmid.C459Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC459() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC459);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC459;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC459 {
        get {
            if (_matcherEcsSchmidC459 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC459);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC459 = matcher;
            }

            return _matcherEcsSchmidC459;
        }
    }
}
