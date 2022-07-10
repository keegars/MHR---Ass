using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class HunterX : ArmorSet
    {
        public HunterX()
        {
            Name = "Hunter X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 94;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new ItemProlonger(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new AmmoUp(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new StunResistance(2))
                .AddSkill(new Handicraft(2))
                .AddSkill(new ItemProlonger(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new StunResistance(1))
                .AddSkill(new AttackBoost(1))
                .AddSkill(new QuickSheath(1))
                .AddSlot(new MediumSlot());
        }
    }
}