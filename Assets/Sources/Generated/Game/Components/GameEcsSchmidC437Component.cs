//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C437Component ecsSchmidC437 { get { return (EcsSchmid.C437Component)GetComponent(GameComponentsLookup.EcsSchmidC437); } }
    public bool hasEcsSchmidC437 { get { return HasComponent(GameComponentsLookup.EcsSchmidC437); } }

    public void AddEcsSchmidC437(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC437;
        var component = CreateComponent<EcsSchmid.C437Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC437(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC437;
        var component = CreateComponent<EcsSchmid.C437Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC437() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC437);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC437;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC437 {
        get {
            if (_matcherEcsSchmidC437 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC437);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC437 = matcher;
            }

            return _matcherEcsSchmidC437;
        }
    }
}
