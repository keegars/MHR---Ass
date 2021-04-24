using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Golden : ArmorSet
    {
        public Golden()
        {
            Name = "Golden";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 70;
            Fire.Value = 2;
            Water.Value = 1;
            Ice.Value = -5;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new LatentPower(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new LatentPower(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new CriticalBoost(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalBoost(2))
                .AddSkill(new LatentPower(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}