using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Hunter : ArmorSet
    {
        public Hunter()
        {
            Name = "Hunter";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 62;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ItemProlonger(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1));

            Arm = new ArmArmor(this)
                .AddSkill(new QuickSheath(1));

            Waist = new WaistArmor(this)
                .AddSkill(new StunResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new StunResistance(1))
                .AddSkill(new AttackBoost(1));
        }
    }
}