//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C142Component ecsSchmidC142 { get { return (EcsSchmid.C142Component)GetComponent(GameComponentsLookup.EcsSchmidC142); } }
    public bool hasEcsSchmidC142 { get { return HasComponent(GameComponentsLookup.EcsSchmidC142); } }

    public void AddEcsSchmidC142(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC142;
        var component = CreateComponent<EcsSchmid.C142Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC142(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC142;
        var component = CreateComponent<EcsSchmid.C142Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC142() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC142);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC142;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC142 {
        get {
            if (_matcherEcsSchmidC142 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC142);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC142 = matcher;
            }

            return _matcherEcsSchmidC142;
        }
    }
}
