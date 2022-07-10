using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DeathStenchS : ArmorSet
    {
        public DeathStenchS()
        {
            Name = "Death Stench S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ProtectivePolish(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Fortify(1))
                .AddSkill(new RapidMorph(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MaximumMight(2))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new RapidMorph(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}