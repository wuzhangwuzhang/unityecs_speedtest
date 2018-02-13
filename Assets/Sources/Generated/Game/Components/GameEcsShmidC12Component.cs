//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcsShmid.C12Component ecsShmidC12 { get { return (EcsShmid.C12Component)GetComponent(GameComponentsLookup.EcsShmidC12); } }
    public bool hasEcsShmidC12 { get { return HasComponent(GameComponentsLookup.EcsShmidC12); } }

    public void AddEcsShmidC12(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC12;
        var component = CreateComponent<EcsShmid.C12Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        AddComponent(index, component);
    }

    public void ReplaceEcsShmidC12(int newField0, int newField1) {
        var index = GameComponentsLookup.EcsShmidC12;
        var component = CreateComponent<EcsShmid.C12Component>(index);
        component.field0 = newField0;
        component.field1 = newField1;
        ReplaceComponent(index, component);
    }

    public void RemoveEcsShmidC12() {
        RemoveComponent(GameComponentsLookup.EcsShmidC12);
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

    static Entitas.IMatcher<GameEntity> _matcherEcsShmidC12;

    public static Entitas.IMatcher<GameEntity> EcsShmidC12 {
        get {
            if (_matcherEcsShmidC12 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EcsShmidC12);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEcsShmidC12 = matcher;
            }

            return _matcherEcsShmidC12;
        }
    }
}
