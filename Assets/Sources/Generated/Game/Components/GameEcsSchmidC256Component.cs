//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C256Component ecsSchmidC256 { get { return (EcsSchmid.C256Component)GetComponent(GameComponentsLookup.EcsSchmidC256); } }
    public bool hasEcsSchmidC256 { get { return HasComponent(GameComponentsLookup.EcsSchmidC256); } }

    public void AddEcsSchmidC256(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC256;
        var component = CreateComponent<EcsSchmid.C256Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC256(int newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC256;
        var component = CreateComponent<EcsSchmid.C256Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC256() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC256);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC256;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC256 {
        get {
            if (_matcherEcsSchmidC256 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC256);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC256 = matcher;
            }

            return _matcherEcsSchmidC256;
        }
    }
}
