//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C48Component ecsSchmidC48 { get { return (EcsSchmid.C48Component)GetComponent(GameComponentsLookup.EcsSchmidC48); } }
    public bool hasEcsSchmidC48 { get { return HasComponent(GameComponentsLookup.EcsSchmidC48); } }

    public void AddEcsSchmidC48(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC48;
        var component = CreateComponent<EcsSchmid.C48Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC48(int newField0, long newField1) {
        var index = GameComponentsLookup.EcsSchmidC48;
        var component = CreateComponent<EcsSchmid.C48Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC48() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC48);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC48;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC48 {
        get {
            if (_matcherEcsSchmidC48 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC48);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC48 = matcher;
            }

            return _matcherEcsSchmidC48;
        }
    }
}