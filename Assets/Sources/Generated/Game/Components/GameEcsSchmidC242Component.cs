//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C242Component ecsSchmidC242 { get { return (EcsSchmid.C242Component)GetComponent(GameComponentsLookup.EcsSchmidC242); } }
    public bool hasEcsSchmidC242 { get { return HasComponent(GameComponentsLookup.EcsSchmidC242); } }

    public void AddEcsSchmidC242(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC242;
        var component = CreateComponent<EcsSchmid.C242Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC242(long newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC242;
        var component = CreateComponent<EcsSchmid.C242Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC242() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC242);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC242;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC242 {
        get {
            if (_matcherEcsSchmidC242 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC242);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC242 = matcher;
            }

            return _matcherEcsSchmidC242;
        }
    }
}
