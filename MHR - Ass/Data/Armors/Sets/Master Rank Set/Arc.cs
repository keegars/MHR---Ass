using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Arc : ArmorSet
    {
        public Arc()
        {
            Name = "Arc";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = 2;
            Thunder.Value = 0;
            Dragon.Value = -4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Bloodlust(1))
                .AddSkill(new Coalescence(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Bloodlust(1))
                .AddSkill(new Resuscitate(1))
                .AddSkill(new CriticalElement(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalElement(2))
                .AddSkill(new Resuscitate(2))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Coalescence(1))
                .AddSkill(new RazorSharp(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Bloodlust(1))
                .AddSkill(new RazorSharp(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());
        }
    }
}