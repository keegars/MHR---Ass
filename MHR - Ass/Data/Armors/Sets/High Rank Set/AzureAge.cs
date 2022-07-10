using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AzureAge : ArmorSet
    {
        public AzureAge()
        {
            Name = "Azure Age";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 92;
            Fire.Value = 2;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new WaterAttack(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new WeaknessExploit(2))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new CriticalElement(1))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new WaterAttack(1))
                .AddSkill(new CriticalElement(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new QuickSheath(2))
                .AddSkill(new Focus(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}