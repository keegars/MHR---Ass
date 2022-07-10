using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Vespoid : ArmorSet
    {
        public Vespoid()
        {
            Name = "Vespoid";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 96;
            Fire.Value = -2;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ParalysisAttack(1))
                .AddSkill(new WirebugWhisperer(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new ParalysisResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ParalysisAttack(2))
                .AddSkill(new MasterMounter(2))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new ParalysisResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new WirebugWhisperer(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}