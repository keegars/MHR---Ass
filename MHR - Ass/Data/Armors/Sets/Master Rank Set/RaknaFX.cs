using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RaknaFX : ArmorSet
    {
        public RaknaFX()
        {
            Name = "Rakna (F) X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 116;
            Fire.Value = 4;
            Water.Value = -2;
            Ice.Value = -3;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new ReloadSpeed(1))
                .AddSkill(new TuneUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new ReloadSpeed(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new StaminaSurge(2))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new SpareShot(1))
                .AddSkill(new TuneUp(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(3))
                .AddSkill(new StaminaSurge(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}