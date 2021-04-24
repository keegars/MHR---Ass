using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SkaldaS : ArmorSet
    {
        public SkaldaS()
        {
            Name = "Skalda S/Spio S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 32;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonAttack(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new PoisonResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WeaknessExploit(2));

            Leg = new LegArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new PoisonResistance(1))
                .AddSkill(new MindsEye(1))
                .AddSlot(new SmallSlot());
        }
    }
}