using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Hermitaur : ArmorSet
    {
        public Hermitaur()
        {
            Name = "Hermitaur";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 106;
            Fire.Value = -1;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new QuickSheath(2))
                .AddSkill(new TremorResistance(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(3))
                .AddSkill(new LoadShells(3))
                .AddSkill(new NormalRapidUp(3))
                .AddSkill(new AmmoUp(3))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new GuardUp(2))
                .AddSkill(new NormalRapidUp(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new TuneUp(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new QuickSheath(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new TuneUp(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new TremorResistance(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}