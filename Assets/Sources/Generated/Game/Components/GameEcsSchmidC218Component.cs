//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C218Component ecsSchmidC218 { get { return (EcsSchmid.C218Component)GetComponent(GameComponentsLookup.EcsSchmidC218); } }
    public bool hasEcsSchmidC218 { get { return HasComponent(GameComponentsLookup.EcsSchmidC218); } }

    public void AddEcsSchmidC218(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC218;
        var component = CreateComponent<EcsSchmid.C218Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC218(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC218;
        var component = CreateComponent<EcsSchmid.C218Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC218() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC218);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC218;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC218 {
        get {
            if (_matcherEcsSchmidC218 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC218);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC218 = matcher;
            }

            return _matcherEcsSchmidC218;
        }
    }
}
