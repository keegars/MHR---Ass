using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RhenoplosX : ArmorSet
    {
        public RhenoplosX()
        {
            Name = "Rhenoplos X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 102;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PierceUp(2))
                .AddSkill(new StunResistance(2))
                .AddSkill(new MuckResistance(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Artillery(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Artillery(2))
                .AddSkill(new LoadShells(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new TremorResistance(2))
                .AddSkill(new LoadShells(2))
                .AddSkill(new SpecialAmmoBoost(2))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PierceUp(1))
                .AddSkill(new TremorResistance(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}