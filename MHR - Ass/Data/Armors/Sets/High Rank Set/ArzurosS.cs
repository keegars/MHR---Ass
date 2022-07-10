using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ArzurosS : ArmorSet
    {
        public ArzurosS()
        {
            Name = "Arzuros S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 74;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Fortify(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Counterstrike(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Counterstrike(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Counterstrike(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());
        }
    }
}