using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ChainmailS : ArmorSet
    {
        public ChainmailS()
        {
            Name = "Chainmail S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 32;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new DefenseBoost(1))
                .AddSkill(new FlinchFree(2))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new DefenseBoost(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new Guard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new StaminaSurge(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}