using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GossHarag : ArmorSet
    {
        public GossHarag()
        {
            Name = "Goss Harag";
            

            //Base values
            BaseDefense = 30;
            Fire.Value = -4;
            Water.Value = 1;
            Ice.Value = 4;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Agitator(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalDraw(1));

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalDraw(1))
                .AddSkill(new PunishingDraw(1));

            Waist = new WaistArmor(this)
                .AddSkill(new PunishingDraw(1))
                .AddSkill(new Resentment(1));

            Leg = new LegArmor(this)
                .AddSkill(new Agitator(1));
        }
    }
}