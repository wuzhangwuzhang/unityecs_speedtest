//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C157Component ecsSchmidC157 { get { return (EcsSchmid.C157Component)GetComponent(GameComponentsLookup.EcsSchmidC157); } }
    public bool hasEcsSchmidC157 { get { return HasComponent(GameComponentsLookup.EcsSchmidC157); } }

    public void AddEcsSchmidC157(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC157;
        var component = CreateComponent<EcsSchmid.C157Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC157(long newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC157;
        var component = CreateComponent<EcsSchmid.C157Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC157() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC157);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC157;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC157 {
        get {
            if (_matcherEcsSchmidC157 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC157);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC157 = matcher;
            }

            return _matcherEcsSchmidC157;
        }
    }
}