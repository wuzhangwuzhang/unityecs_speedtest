//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C208Component ecsSchmidC208 { get { return (EcsSchmid.C208Component)GetComponent(GameComponentsLookup.EcsSchmidC208); } }
    public bool hasEcsSchmidC208 { get { return HasComponent(GameComponentsLookup.EcsSchmidC208); } }

    public void AddEcsSchmidC208(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC208;
        var component = CreateComponent<EcsSchmid.C208Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC208(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC208;
        var component = CreateComponent<EcsSchmid.C208Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC208() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC208);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC208;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC208 {
        get {
            if (_matcherEcsSchmidC208 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC208);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC208 = matcher;
            }

            return _matcherEcsSchmidC208;
        }
    }
}
