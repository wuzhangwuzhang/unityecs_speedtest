//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C7Component ecsSchmidC7 { get { return (EcsSchmid.C7Component)GetComponent(GameComponentsLookup.EcsSchmidC7); } }
    public bool hasEcsSchmidC7 { get { return HasComponent(GameComponentsLookup.EcsSchmidC7); } }

    public void AddEcsSchmidC7(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC7;
        var component = CreateComponent<EcsSchmid.C7Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC7(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC7;
        var component = CreateComponent<EcsSchmid.C7Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC7() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC7);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC7;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC7 {
        get {
            if (_matcherEcsSchmidC7 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC7);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC7 = matcher;
            }

            return _matcherEcsSchmidC7;
        }
    }
}