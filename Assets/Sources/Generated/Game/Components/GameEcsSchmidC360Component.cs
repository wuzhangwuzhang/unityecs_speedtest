//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C360Component ecsSchmidC360 { get { return (EcsSchmid.C360Component)GetComponent(GameComponentsLookup.EcsSchmidC360); } }
    public bool hasEcsSchmidC360 { get { return HasComponent(GameComponentsLookup.EcsSchmidC360); } }

    public void AddEcsSchmidC360(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC360;
        var component = CreateComponent<EcsSchmid.C360Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC360(long newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC360;
        var component = CreateComponent<EcsSchmid.C360Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC360() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC360);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC360;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC360 {
        get {
            if (_matcherEcsSchmidC360 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC360);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC360 = matcher;
            }

            return _matcherEcsSchmidC360;
        }
    }
}
