//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C90Component ecsSchmidC90 { get { return (EcsSchmid.C90Component)GetComponent(GameComponentsLookup.EcsSchmidC90); } }
    public bool hasEcsSchmidC90 { get { return HasComponent(GameComponentsLookup.EcsSchmidC90); } }

    public void AddEcsSchmidC90(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC90;
        var component = CreateComponent<EcsSchmid.C90Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC90(float newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC90;
        var component = CreateComponent<EcsSchmid.C90Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC90() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC90);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC90;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC90 {
        get {
            if (_matcherEcsSchmidC90 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC90);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC90 = matcher;
            }

            return _matcherEcsSchmidC90;
        }
    }
}
