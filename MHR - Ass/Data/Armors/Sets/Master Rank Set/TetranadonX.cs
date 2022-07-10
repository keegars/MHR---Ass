using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class TetranadonX : ArmorSet
    {
        public TetranadonX()
        {
            Name = "Tetranadon X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 102;
            Fire.Value = -1;
            Water.Value = 4;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new NormalRapidUp(2))
                .AddSkill(new SpeedEating(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new SpecialAmmoBoost(2))
                .AddSkill(new HungerResistance(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new EvadeExtender(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new HungerResistance(2))
                .AddSkill(new Heroics(2))
                .AddSkill(new SpeedEating(2))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}