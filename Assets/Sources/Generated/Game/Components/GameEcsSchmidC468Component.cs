//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C468Component ecsSchmidC468 { get { return (EcsSchmid.C468Component)GetComponent(GameComponentsLookup.EcsSchmidC468); } }
    public bool hasEcsSchmidC468 { get { return HasComponent(GameComponentsLookup.EcsSchmidC468); } }

    public void AddEcsSchmidC468(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC468;
        var component = CreateComponent<EcsSchmid.C468Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC468(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsSchmidC468;
        var component = CreateComponent<EcsSchmid.C468Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC468() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC468);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC468;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC468 {
        get {
            if (_matcherEcsSchmidC468 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC468);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC468 = matcher;
            }

            return _matcherEcsSchmidC468;
        }
    }
}
