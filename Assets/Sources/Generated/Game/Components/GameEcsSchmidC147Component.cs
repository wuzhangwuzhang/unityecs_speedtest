//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsSchmid.C147Component ecsSchmidC147 { get { return (EcsSchmid.C147Component)GetComponent(GameComponentsLookup.EcsSchmidC147); } }
    public bool hasEcsSchmidC147 { get { return HasComponent(GameComponentsLookup.EcsSchmidC147); } }

    public void AddEcsSchmidC147(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC147;
        var component = CreateComponent<EcsSchmid.C147Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsSchmidC147(float newField0, float newField1) {
        var index = GameComponentsLookup.EcsSchmidC147;
        var component = CreateComponent<EcsSchmid.C147Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsSchmidC147() {
        RemoveComponent(GameComponentsLookup.EcsSchmidC147);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsSchmidC147;

    public static Entitas.IMatcher<GameEntity> EcsSchmidC147 {
        get {
            if (_matcherEcsSchmidC147 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsSchmidC147);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsSchmidC147 = matcher;
            }

            return _matcherEcsSchmidC147;
        }
    }
}
