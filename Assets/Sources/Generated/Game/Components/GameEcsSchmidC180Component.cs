//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C180Component ecsSchmidC180 { get { return (EcsSchmid.C180Component)GetComponent(GameComponentsLookup.EcsSchmidC180); } }
    public bool hasEcsSchmidC180 { get { return HasComponent(GameComponentsLookup.EcsSchmidC180); } }

    public void AddEcsSchmidC180(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC180;
        var component = CreateComponent<EcsSchmid.C180Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC180(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC180;
        var component = CreateComponent<EcsSchmid.C180Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC180() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC180);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC180;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC180 {
        get {
            if (_matcherEcsSchmidC180 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC180);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC180 = matcher;
            }

            return _matcherEcsSchmidC180;
        }
    }
}