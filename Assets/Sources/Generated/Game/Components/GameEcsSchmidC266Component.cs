//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C266Component ecsSchmidC266 { get { return (EcsSchmid.C266Component)GetComponent(GameComponentsLookup.EcsSchmidC266); } }
    public bool hasEcsSchmidC266 { get { return HasComponent(GameComponentsLookup.EcsSchmidC266); } }

    public void AddEcsSchmidC266(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC266;
        var component = CreateComponent<EcsSchmid.C266Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC266(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC266;
        var component = CreateComponent<EcsSchmid.C266Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC266() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC266);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC266;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC266 {
        get {
            if (_matcherEcsSchmidC266 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC266);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC266 = matcher;
            }

            return _matcherEcsSchmidC266;
        }
    }
}
