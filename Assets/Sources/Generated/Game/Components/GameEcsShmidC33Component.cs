//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C33Component ecsShmidC33 { get { return (EcsShmid.C33Component)GetComponent(GameComponentsLookup.EcsShmidC33); } }
    public bool hasEcsShmidC33 { get { return HasComponent(GameComponentsLookup.EcsShmidC33); } }

    public void AddEcsShmidC33(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC33;
        var component = CreateComponent<EcsShmid.C33Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC33(float newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC33;
        var component = CreateComponent<EcsShmid.C33Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC33() {
        RemoveComponent(GameComponentsLookup.EcsShmidC33);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC33;

    public static Entitas.IMatcher<GameEntity> EcsShmidC33 {
        get {
            if (_matcherEcsShmidC33 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC33);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC33 = matcher;
            }

            return _matcherEcsShmidC33;
        }
    }
}