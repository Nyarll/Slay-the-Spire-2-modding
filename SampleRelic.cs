/**
using MegaCrit.Sts2.Core.Entities.Relics;

public class SampleRelic : Relic
{
    public override string Id => "NightOfTheWizard:SampleRelic";

    public override string Name => "テストレリック";

    public override string Description => "戦闘開始時に1ドローする。";

    public override RelicRarity Rarity => RelicRarity.Common;

    public override void OnBattleStart()
    {
        Owner.Draw(1);
    }
}
/**/