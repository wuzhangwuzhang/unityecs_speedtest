//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C490Component ecsSchmidC490 { get { return (EcsSchmid.C490Component)GetComponent(GameComponentsLookup.EcsSchmidC490); } }
    public bool hasEcsSchmidC490 { get { return HasComponent(GameComponentsLookup.EcsSchmidC490); } }

    public void AddEcsSchmidC490(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC490;
        var component = CreateComponent<EcsSchmid.C490Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC490(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC490;
        var component = CreateComponent<EcsSchmid.C490Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC490() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC490);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC490;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC490 {
        get {
            if (_matcherEcsSchmidC490 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC490);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC490 = matcher;
            }

            return _matcherEcsSchmidC490;
        }
    }
}
