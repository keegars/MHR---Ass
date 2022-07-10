using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Garangolm : ArmorSet
    {
        public Garangolm()
        {
            Name = "Garangolm";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 120;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ChargeMaster(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new TremorResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new FlinchFree(3))
                .AddSkill(new TremorResistance(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ChargeMaster(1))
                .AddSkill(new Focus(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpiribirdsCall(1))
                .AddSkill(new Focus(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ChargeMaster(1))
                .AddSkill(new Slugger(1))
                .AddSkill(new StaminaThief(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());
        }
    }
}