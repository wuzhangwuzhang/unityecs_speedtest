//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C325Component ecsSchmidC325 { get { return (EcsSchmid.C325Component)GetComponent(GameComponentsLookup.EcsSchmidC325); } }
    public bool hasEcsSchmidC325 { get { return HasComponent(GameComponentsLookup.EcsSchmidC325); } }

    public void AddEcsSchmidC325(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC325;
        var component = CreateComponent<EcsSchmid.C325Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC325(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC325;
        var component = CreateComponent<EcsSchmid.C325Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC325() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC325);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC325;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC325 {
        get {
            if (_matcherEcsSchmidC325 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC325);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC325 = matcher;
            }

            return _matcherEcsSchmidC325;
        }
    }
}
