using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SkaldaX : ArmorSet
    {
        public SkaldaX()
        {
            Name = "Skalda X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 106;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonAttack(3))
                .AddSkill(new LatentPower(3))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new LatentPower(2))
                .AddSkill(new MindsEye(2))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new PoisonResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WeaknessExploit(2))
                .AddSkill(new PoisonResistance(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new PoisonResistance(1))
                .AddSkill(new MindsEye(1))
                .AddSlot(new MediumSlot());
        }
    }
}