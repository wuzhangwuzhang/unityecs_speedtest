//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C83Component ecsSchmidC83 { get { return (EcsSchmid.C83Component)GetComponent(GameComponentsLookup.EcsSchmidC83); } }
    public bool hasEcsSchmidC83 { get { return HasComponent(GameComponentsLookup.EcsSchmidC83); } }

    public void AddEcsSchmidC83(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC83;
        var component = CreateComponent<EcsSchmid.C83Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC83(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC83;
        var component = CreateComponent<EcsSchmid.C83Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC83() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC83);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC83;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC83 {
        get {
            if (_matcherEcsSchmidC83 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC83);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC83 = matcher;
            }

            return _matcherEcsSchmidC83;
        }
    }
}
