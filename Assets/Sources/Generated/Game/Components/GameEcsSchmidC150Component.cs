//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C150Component ecsSchmidC150 { get { return (EcsSchmid.C150Component)GetComponent(GameComponentsLookup.EcsSchmidC150); } }
    public bool hasEcsSchmidC150 { get { return HasComponent(GameComponentsLookup.EcsSchmidC150); } }

    public void AddEcsSchmidC150(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC150;
        var component = CreateComponent<EcsSchmid.C150Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC150(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC150;
        var component = CreateComponent<EcsSchmid.C150Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC150() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC150);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC150;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC150 {
        get {
            if (_matcherEcsSchmidC150 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC150);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC150 = matcher;
            }

            return _matcherEcsSchmidC150;
        }
    }
}