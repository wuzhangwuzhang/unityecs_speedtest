//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C304Component ecsSchmidC304 { get { return (EcsSchmid.C304Component)GetComponent(GameComponentsLookup.EcsSchmidC304); } }
    public bool hasEcsSchmidC304 { get { return HasComponent(GameComponentsLookup.EcsSchmidC304); } }

    public void AddEcsSchmidC304(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC304;
        var component = CreateComponent<EcsSchmid.C304Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC304(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC304;
        var component = CreateComponent<EcsSchmid.C304Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC304() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC304);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC304;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC304 {
        get {
            if (_matcherEcsSchmidC304 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC304);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC304 = matcher;
            }

            return _matcherEcsSchmidC304;
        }
    }
}
