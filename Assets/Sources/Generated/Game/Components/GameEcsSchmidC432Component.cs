//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C432Component ecsSchmidC432 { get { return (EcsSchmid.C432Component)GetComponent(GameComponentsLookup.EcsSchmidC432); } }
    public bool hasEcsSchmidC432 { get { return HasComponent(GameComponentsLookup.EcsSchmidC432); } }

    public void AddEcsSchmidC432(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC432;
        var component = CreateComponent<EcsSchmid.C432Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC432(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC432;
        var component = CreateComponent<EcsSchmid.C432Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC432() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC432);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC432;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC432 {
        get {
            if (_matcherEcsSchmidC432 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC432);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC432 = matcher;
            }

            return _matcherEcsSchmidC432;
        }
    }
}