using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class PukeiPukeiS : ArmorSet
    {
        public PukeiPukeiS()
        {
            Name = "Pukei-Pukei S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 80;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpecialAmmoBoost(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SpecialAmmoBoost(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SpareShot(1))
                .AddSkill(new Ballistics(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpareShot(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(1))
                .AddSkill(new Ballistics(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}