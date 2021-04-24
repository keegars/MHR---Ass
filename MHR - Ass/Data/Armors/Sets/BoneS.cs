using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BoneS : ArmorSet
    {
        public BoneS()
        {
            Name = "Bone S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 32;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new StaminaThief(1))
                .AddSkill(new Partbreaker(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new StaminaThief(1))
                .AddSkill(new MarathonRunner(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MuckResistance(1))
                .AddSkill(new StaminaThief(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MuckResistance(2))
                .AddSkill(new Focus(1))
                .AddSlot(new MediumSlot());
        }
    }
}