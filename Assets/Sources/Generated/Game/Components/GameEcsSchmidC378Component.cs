//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C378Component ecsSchmidC378 { get { return (EcsSchmid.C378Component)GetComponent(GameComponentsLookup.EcsSchmidC378); } }
    public bool hasEcsSchmidC378 { get { return HasComponent(GameComponentsLookup.EcsSchmidC378); } }

    public void AddEcsSchmidC378(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC378;
        var component = CreateComponent<EcsSchmid.C378Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC378(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC378;
        var component = CreateComponent<EcsSchmid.C378Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC378() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC378);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC378;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC378 {
        get {
            if (_matcherEcsSchmidC378 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC378);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC378 = matcher;
            }

            return _matcherEcsSchmidC378;
        }
    }
}
