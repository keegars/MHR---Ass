using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ArchfiendArmor : ArmorSet
    {
        public ArchfiendArmor()
        {
            Name = "Archfiend Armor";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 144;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = -5;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Dereliction(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Resentment(2))
                .AddSkill(new WeaknessExploit(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Dereliction(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Dereliction(1))
                .AddSkill(new ChainCrit(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Resentment(2))
                .AddSkill(new ChainCrit(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}