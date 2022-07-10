using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BoneX : ArmorSet
    {
        public BoneX()
        {
            Name = "Bone X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 94;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new StaminaThief(1))
                .AddSkill(new Partbreaker(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new StaminaThief(1))
                .AddSkill(new MarathonRunner(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new PunishingDraw(2))
                .AddSkill(new StaminaThief(2))
                .AddSkill(new MarathonRunner(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Partbreaker(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MuckResistance(2))
                .AddSkill(new Focus(2))
                .AddSkill(new PunishingDraw(2))
                .AddSlot(new MediumSlot());
        }
    }
}