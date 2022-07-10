using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class PukeiPukeiX : ArmorSet
    {
        public PukeiPukeiX()
        {
            Name = "Pukei-Pukei X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpecialAmmoBoost(1))
                .AddSkill(new SpareShot(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SpecialAmmoBoost(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new SpeedSharpening(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SpareShot(1))
                .AddSkill(new Ballistics(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpareShot(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new Ballistics(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}