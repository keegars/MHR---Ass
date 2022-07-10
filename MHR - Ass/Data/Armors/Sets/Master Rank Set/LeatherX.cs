using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class LeatherX : ArmorSet
    {
        public LeatherX()
        {
            Name = "Leather X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 92;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new HungerResistance(1))
                .AddSkill(new CarvingPro(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Botanist(2))
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new SpecialAmmoBoost(1))                
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new RecoveryUp(2))
                .AddSkill(new HungerResistance(2))                
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new Botanist(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}