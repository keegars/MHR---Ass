using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Force.DeepCloner;
using Humanizer;
using MHR___Ass.Data.Armors;
using MHR___Ass.Data.Charms;
using MHR___Ass.Data.Decorations;
using MHR___Ass.Data.Resistances;
using MHR___Ass.Data.Skills;
using MHR___Ass.Data.Slots;
using static MHR___Ass.Data.Filters.Filter;

namespace MHR___Ass
{
    public partial class Form1 : Form
    {
        private readonly HashSet<ArmorSet> _Armor_Sets;
        private readonly Dictionary<string, Skill> _Skills;
        private readonly HashSet<Decoration> _Decorations;
        private readonly HashSet<SkillComboBox> _SkillBoxes;
        private readonly HashSet<SkillComboBox> _CharmSkillBoxes;
        private BlockingCollection<ArmorSet> _ThreadSafe_Armor_Sets = new BlockingCollection<ArmorSet>();
        private List<ArmorSet> _ArmorSetSearch = new List<ArmorSet>();
        private HashSet<SkillDecoCombo> _searchDecoCombos = new HashSet<SkillDecoCombo>();
        private Charm _currentCharm;
        private int _SearchLimit = 250;
        private int _Counter = 0;
        private long _ArmorsSearched = 0;
        private Stopwatch _StopWatch;
        private int _Max_Parrallel = Environment.ProcessorCount;

        public Form1()
        {
            InitializeComponent();

            //Initialize Data
            _Armor_Sets = GetHashSetOfClasses<ArmorSet>();
            _Skills = GetHashSetOfClasses<Skill>().ToDictionary(z => z.Name);
            _Decorations = GetHashSetOfClasses<Decoration>();
            _SkillBoxes = new HashSet<SkillComboBox>
            {
                new SkillComboBox(skillBox1, skillValueBox1),
                new SkillComboBox(skillBox2, skillValueBox2),
                new SkillComboBox(skillBox3, skillValueBox3),
                new SkillComboBox(skillBox4, skillValueBox4),
                new SkillComboBox(skillBox5, skillValueBox5),
                new SkillComboBox(skillBox6, skillValueBox6),
                new SkillComboBox(skillBox7, skillValueBox7),
                new SkillComboBox(skillBox8, skillValueBox8),
                new SkillComboBox(skillBox9, skillValueBox9),
                new SkillComboBox(skillBox10, skillValueBox10),
            };

            _CharmSkillBoxes = new HashSet<SkillComboBox>()
            {
                 new SkillComboBox(charmSkill1Box, charmValueBox1),
                new SkillComboBox(charmSkill2Box, charmValueBox2),
            };

            sortByList.Items.AddRange(GetNames<FilterType>().ToArray());
            sortByList.SelectedIndex = 0;

            var weaponSlots = new string[]
            {
                "None",
                "Small",
                "Medium",
                "Large",
                "Extra Large"
            };

            weaponSlot1Box.Items.AddRange(weaponSlots);
            weaponSlot2Box.Items.AddRange(weaponSlots);
            weaponSlot3Box.Items.AddRange(weaponSlots);

            weaponSlot1Box.SelectedIndex = 0;
            weaponSlot2Box.SelectedIndex = 0;
            weaponSlot3Box.SelectedIndex = 0;

            charmSlot1Box.Items.AddRange(weaponSlots);
            charmSlot2Box.Items.AddRange(weaponSlots);
            charmSlot3Box.Items.AddRange(weaponSlots);

            charmSlot1Box.SelectedIndex = 0;
            charmSlot2Box.SelectedIndex = 0;
            charmSlot3Box.SelectedIndex = 0;

            //Initialize Form
            PopulateSkillBoxes();
            ClearSkills();
        }

        private void PopulateSkillBoxes()
        {
            var skillKeys = _Skills.Select(z => z.Key).OrderBy(z => z).ToList();
            skillKeys.Insert(0, "None");

            foreach (var comboBox in _SkillBoxes)
            {
                comboBox.SkillBox.Items.Clear();

                foreach (var skill in skillKeys)
                {
                    comboBox.SkillBox.Items.Add(skill);
                }

                comboBox.SkillBox.SelectedIndex = 0;
            }

            foreach (var comboBox in _CharmSkillBoxes)
            {
                comboBox.SkillBox.Items.Clear();

                foreach (var skill in skillKeys)
                {
                    comboBox.SkillBox.Items.Add(skill);
                }

                comboBox.SkillBox.SelectedIndex = 0;
            }
        }

        private HashSet<T> GetHashSetOfClasses<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
              .SelectMany(x => x.GetTypes())
              .Where(x => typeof(T).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract && x.BaseType == typeof(T))
              .Select(x => (T)Activator.CreateInstance(x))
              .ToHashSet();
        }

        private void NewDescription(string message)
        {
            skillDescTextBox.Text = message;
        }

        private void SkillBoxIndexChanged(SkillComboBox comboBox)
        {
            if (comboBox.SkillBox.SelectedIndex == -1)
            {
                comboBox.SkillBox.SelectedIndex = 0;
            }
            else
            {
                _Skills.TryGetValue(comboBox.SkillBox.Items[comboBox.SkillBox.SelectedIndex].ToString(), out var value);

                NewDescription(value == null ? "" : value.Description);
                ValueBoxUpdate(comboBox.ValueBox, value == null ? 0 : value.MaxValue);
            }
        }

        private SkillComboBox GetSkillComboBox(int element)
        {
            return _SkillBoxes.ElementAt(element - 1);
        }

        private void ValueBoxUpdate(ComboBox comboxBox, int maxValue)
        {
            comboxBox.Items.Clear();

            if (maxValue > 0)
            {
                comboxBox.Items.AddRange(Enumerable.Range(1, maxValue).Select(z => z.ToString()).ToArray());

                comboxBox.SelectedIndex = comboxBox.Items.Count - 1;
            }
            else
            {
                comboxBox.SelectedIndex = -1;
                comboxBox.Text = "";
            }
        }

        private void skillBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(1));
        }

        private void skillBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(2));
        }

        private void skillBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(3));
        }

        private void skillBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(4));
        }

        private void skillBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(5));
        }

        private void skillBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(6));
        }

        private void skillBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(7));
        }

        private void skillBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(8));
        }

        private void skillBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(9));
        }

        private void skillBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(GetSkillComboBox(10));
        }

        private void charmSkill1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(_CharmSkillBoxes.ElementAt(0));
        }

        private void charmSkill2Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillBoxIndexChanged(_CharmSkillBoxes.ElementAt(1));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearSkills();
        }

        private void ClearSkills()
        {
            foreach (var combobox in _SkillBoxes)
            {
                combobox.SkillBox.SelectedIndex = 0;
            }
        }

        private void SearchLimit(int limit)
        {
            limit100.Checked = limit <= 100;
            limit250.Checked = !limit100.Checked && limit <= 250;
            limit500.Checked = !limit100.Checked && !limit250.Checked && limit <= 500;
            limit1000.Checked = !limit100.Checked && !limit250.Checked && !limit500.Checked && limit <= 1000;
            limit2500.Checked = !limit100.Checked && !limit250.Checked && !limit500.Checked && !limit1000.Checked && limit <= 2500;

            _SearchLimit = limit;
        }

        //100 search limit
        private void limit100_Click(object sender, EventArgs e)
        {
            SearchLimit(100);
        }

        //250 search limit
        private void limit250_Click(object sender, EventArgs e)
        {
            SearchLimit(250);
        }

        //500 search limit
        private void limit500_Click(object sender, EventArgs e)
        {
            SearchLimit(500);
        }

        //1000 search limit
        private void limit1000_Click(object sender, EventArgs e)
        {
            SearchLimit(1000);
        }

        //unlimited search limit
        private void limit2500_Click(object sender, EventArgs e)
        {
            SearchLimit(2500);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchButton.Enabled = false;
            clearButton.Enabled = false;

            //Search algorithm
            //Skills wanted
            var skillValues = _SkillBoxes.Where(z => z.SkillBox.SelectedIndex > 0).ToList();

            if (skillValues.Count <= 0)
            {
                MessageBox.Show("No Skills Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Enable buttons again
                searchButton.Enabled = true;
                clearButton.Enabled = true;
                cancelButton.Enabled = false;

                return;
            }

            var searchSkills = new HashSet<Skill>();

            foreach (var skillValue in skillValues)
            {
                _Skills.TryGetValue(skillValue.SkillBox.SelectedItem.ToString(), out var skill);

                searchSkills.Add(skill.Clone(int.Parse(skillValue.ValueBox.SelectedItem.ToString())));
            }

            //Get all decorations that may make up the skills
            var searchDecos = _Decorations.Where(z => searchSkills.Select(y => y.Name).Contains(z.Skill.Name)).ToHashSet();

            var searchArmorRanks = new HashSet<ArmorRank>();
            if (lowToolStripMenuItem.Checked)
            {
                searchArmorRanks.Add(ArmorRank.Low);
            }
            if (highToolStripMenuItem.Checked)
            {
                searchArmorRanks.Add(ArmorRank.High);
            }

            //Get all armors that can make up the skills
            var searchHeadArmor = _Armor_Sets.FilterOn(ArmorType.Head, searchSkills).FilterByRank(searchArmorRanks);
            var searchTorsoArmor = _Armor_Sets.FilterOn(ArmorType.Torso, searchSkills).FilterByRank(searchArmorRanks);
            var searchArmArmor = _Armor_Sets.FilterOn(ArmorType.Arm, searchSkills).FilterByRank(searchArmorRanks);
            var searchWaistArmor = _Armor_Sets.FilterOn(ArmorType.Waist, searchSkills).FilterByRank(searchArmorRanks);
            var searchLegArmor = _Armor_Sets.FilterOn(ArmorType.Leg, searchSkills).FilterByRank(searchArmorRanks);

            //Get all armors that can fit the decorations in
            var decoHeadArmor = _Armor_Sets.FilterOn(ArmorType.Head, searchDecos).FilterByRank(searchArmorRanks);
            var decoTorsoArmor = _Armor_Sets.FilterOn(ArmorType.Torso, searchDecos).FilterByRank(searchArmorRanks);
            var decoArmArmor = _Armor_Sets.FilterOn(ArmorType.Arm, searchDecos).FilterByRank(searchArmorRanks);
            var decoWaistArmor = _Armor_Sets.FilterOn(ArmorType.Waist, searchDecos).FilterByRank(searchArmorRanks);
            var decoLegArmor = _Armor_Sets.FilterOn(ArmorType.Leg, searchDecos).FilterByRank(searchArmorRanks);

            ////Per each armor category
            /// Find each slot grouping and pick first one based on a filter
            decoHeadArmor = decoHeadArmor.GroupBySlots().FilterByBest(FilterType.Defense);
            decoTorsoArmor = decoTorsoArmor.GroupBySlots().FilterByBest(FilterType.Defense);
            decoArmArmor = decoArmArmor.GroupBySlots().FilterByBest(FilterType.Defense);
            decoWaistArmor = decoWaistArmor.GroupBySlots().FilterByBest(FilterType.Defense);
            decoLegArmor = decoLegArmor.GroupBySlots().FilterByBest(FilterType.Defense);

            // Join slot armors with skill armors
            searchHeadArmor.UnionWith(decoHeadArmor);
            searchTorsoArmor.UnionWith(decoTorsoArmor);
            searchArmArmor.UnionWith(decoArmArmor);
            searchWaistArmor.UnionWith(decoWaistArmor);
            searchLegArmor.UnionWith(decoLegArmor);

            //Add Naked Armor
            ArmorHelper.AddNakedArmor(searchHeadArmor, searchTorsoArmor, searchArmArmor, searchWaistArmor, searchLegArmor);

            var weaponSlotTypes = new List<SlotType>();

            if (weaponSlot1Box.SelectedIndex > 0)
            {
                weaponSlotTypes.Add(GetEnumType<SlotType>(weaponSlot1Box.SelectedItem.ToString()));
            }

            if (weaponSlot2Box.SelectedIndex > 0)
            {
                weaponSlotTypes.Add(GetEnumType<SlotType>(weaponSlot2Box.SelectedItem.ToString()));
            }

            if (weaponSlot3Box.SelectedIndex > 0)
            {
                weaponSlotTypes.Add(GetEnumType<SlotType>(weaponSlot3Box.SelectedItem.ToString()));
            }

            var weaponSlots = weaponSlotTypes.Select(z => new Slot
            {
                Type = z
            }).ToList();

            var skill1 = charmSkill1Box.SelectedIndex > 0 ? _Skills.First(z => z.Key == charmSkill1Box.SelectedItem.ToString()).Value.DeepClone() : null;
            if (skill1 != null)
            {
                skill1.Value = int.Parse(charmValueBox1.SelectedItem.ToString());
            }

            var skill2 = charmSkill2Box.SelectedIndex > 0 ? _Skills.First(z => z.Key == charmSkill2Box.SelectedItem.ToString()).Value.DeepClone() : null;
            if (skill2 != null)
            {
                skill2.Value = int.Parse(charmValueBox2.SelectedItem.ToString());
            }

            _currentCharm = new Charm
            {
                Name = "Custom Charm",
                Skill1 = skill1,
                Skill2 = skill2,
                Slot1 = charmSlot1Box.SelectedIndex > 0 ? new Slot() { Type = GetEnumType<SlotType>(charmSlot1Box.SelectedItem.ToString()) } : null,
                Slot2 = charmSlot2Box.SelectedIndex > 0 ? new Slot() { Type = GetEnumType<SlotType>(charmSlot2Box.SelectedItem.ToString()) } : null,
                Slot3 = charmSlot3Box.SelectedIndex > 0 ? new Slot() { Type = GetEnumType<SlotType>(charmSlot3Box.SelectedItem.ToString()) } : null,
            };

            //Generate armor set combinations
            var searchArmorSets = ArmorHelper.GenerateArmorSets(searchHeadArmor, searchTorsoArmor, searchArmArmor, searchWaistArmor, searchLegArmor, weaponSlots, _currentCharm);

            //These pieces will then be used to brute force each piece together in armor combinations to see if they reach the threshold set, if not then they don't get added to the final armor set list

            var totalCombos = searchHeadArmor.Count * searchTorsoArmor.Count * searchArmArmor.Count * searchWaistArmor.Count * searchLegArmor.Count;

            StartStopWatch();

            FindCombinationsParrallel(searchArmorSets, totalCombos, searchSkills);
        }

        private void StartStopWatch()
        {
            _StopWatch = new Stopwatch();
            _StopWatch.Start();
        }

        private void StopStopWatch()
        {
            _StopWatch.Stop();

            executionLabel.Text = $"Execution Time: {_StopWatch.Elapsed.Humanize(3)}";
        }

        private void DisplayArmorSets()
        {
            //Sort search first
            var sortBy = sortByList.SelectedItem.ToString();

            for (var i = 0; i < _ArmorSetSearch.Count; i++)
            {
                var armorset = _ArmorSetSearch[i].DeepClone();

                armorset.Charm = armorset.Charm.DeepClone();

                armorset.EmptyPopulatedSlots();

                IsCriteriaMet(armorset, _searchDecoCombos, true);

                armorset.GetSkillTotals(true);
                armorset.GetSlotTotals(true);

                _ArmorSetSearch[i] = armorset;
            }

            var filterType = GetEnumType<FilterType>(sortBy);

            _ArmorSetSearch = _ArmorSetSearch.OrderBy(filterType).ToList();

            var sb = new StringBuilder();

            sb.AppendLine($"Displaying {_ArmorSetSearch.Count} Armor Sets");

            foreach (var set in _ArmorSetSearch)
            {
                sb.AppendLine();
                sb.AppendLine($"Head: {set.Head.OriginalArmorSet.Name}");
                sb.AppendLine($"Torso: {set.Torso.OriginalArmorSet.Name}");
                sb.AppendLine($"Arm: {set.Arm.OriginalArmorSet.Name}");
                sb.AppendLine($"Waist: {set.Waist.OriginalArmorSet.Name}");
                sb.AppendLine($"Leg: {set.Leg.OriginalArmorSet.Name}");
                sb.AppendLine();

                sb.AppendLine("Defense");
                sb.AppendLine("--------");
                sb.AppendLine($"Total Defense: {set.GetTotalDefense()}");
                sb.AppendLine($"Fire Res: {set.GetTotalResistance(ResistanceType.Fire)}");
                sb.AppendLine($"Water Res: {set.GetTotalResistance(ResistanceType.Water)}");
                sb.AppendLine($"Thunder Res: {set.GetTotalResistance(ResistanceType.Thunder)}");
                sb.AppendLine($"Ice Res: {set.GetTotalResistance(ResistanceType.Ice)}");
                sb.AppendLine($"Dragon Res: {set.GetTotalResistance(ResistanceType.Dragon)}");

                sb.AppendLine();

                sb.AppendLine($"Weapon Slots");
                sb.AppendLine("--------");

                var weaponSlots = set.GetWeaponSlots();

                if (weaponSlots.Count == 0)
                {
                    sb.Append("XXX");
                }
                else
                {
                    for (var i = 0; i <= 2; i++)
                    {
                        var slot = weaponSlots.ElementAtOrDefault(i);

                        if (slot != null)
                        {
                            sb.Append(slot.Type == SlotType.Small ? "S" : slot.Type == SlotType.Medium ? "M" : "L");
                        }
                        else
                        {
                            sb.Append("X");
                        }
                    }
                }

                sb.AppendLine();

                sb.AppendLine("Charm");
                sb.AppendLine("--------");

                var charmSlots = set.Charm?.GetSlots() ?? new HashSet<Slot>();

                if (charmSlots.Count == 0)
                {
                    sb.Append("XXX");
                }
                else
                {
                    for (var i = 0; i <= 2; i++)
                    {
                        var slot = charmSlots.ElementAtOrDefault(i);

                        if (slot != null)
                        {
                            sb.Append(slot.Type == SlotType.Small ? "S" : slot.Type == SlotType.Medium ? "M" : "L");
                        }
                        else
                        {
                            sb.Append("X");
                        }
                    }
                }

                sb.AppendLine();
                sb.AppendLine();

                sb.AppendLine("Skills");
                sb.AppendLine("--------");

                var skillTotals = set.GetSkillTotals(true);

                foreach (var total in skillTotals.OrderByDescending(z => z.Value).ThenBy(z => z.Key))
                {
                    sb.AppendLine($"{total.Key} x {total.Value}");
                }

                sb.AppendLine();
                sb.AppendLine("Decorations");
                sb.AppendLine("--------");

                var slotTotals = set.GetSlotTotals(true);

                var freeSlots = slotTotals.Where(z => z.Key.Contains("Slot")).OrderBy(z => z.Key);
                var occupiedSlots = slotTotals.Where(z => z.Key.Contains("Jewel")).OrderByDescending(z => z.Value).ThenBy(z => z.Key);

                foreach (var decoration in occupiedSlots) //Highest value, then by Name
                {
                    sb.AppendLine($"{decoration.Key} x {decoration.Value}");
                }

                foreach (var decoration in freeSlots) //Should go Extra Large, Large, Medium, Small
                {
                    sb.AppendLine($"{decoration.Key} x {decoration.Value}");
                }

                sb.AppendLine();
                sb.AppendLine("---------------------------------");
            }

            armorTextBox.Text = sb.ToString();
            armorTextBox.SelectionStart = 0;
            armorTextBox.ScrollToCaret();
        }

        private void BackgroundWorker_FindCombinations(object sender, DoWorkEventArgs e)
        {
            var searchData = e.Argument as SearchData;

            var searchArmorSets = searchData.ArmorSets;
            var searchSkills = searchData.SearchSkills;
            var totalCombos = searchData.TotalCombos;

            _searchDecoCombos = searchData.SearchSkills.Select(z => new SkillDecoCombo
            {
                Skill = z,
                Decoration = _Decorations.FirstOrDefault(y => y.Skill.Name == z.Name)
            }).ToHashSet();

            _Counter = 0;
            _ArmorsSearched = 0;
            _ArmorSetSearch = new List<ArmorSet>();
            _ThreadSafe_Armor_Sets = new BlockingCollection<ArmorSet>();

            Invoke(new MethodInvoker(delegate ()
            {
                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                cancelButton.Enabled = true;
            }));

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = _Max_Parrallel
            };

            var queue = new BlockingCollection<ArmorSet>();
            var isFinished = false;
            Task.Run(() =>
            {
                foreach (var armorSet in searchArmorSets)
                {
                    if (_Counter < _SearchLimit && !backgroundWorker.CancellationPending)
                    {
                        queue.Add(armorSet);
                    }
                    else
                    {
                        break;
                    }
                }

                isFinished = true;
            });

            var parallel = Parallel.ForEach(Enumerable.Range(0, _Max_Parrallel), options, range =>
            {
                var carryOn = true;

                while (carryOn && !backgroundWorker.CancellationPending)
                {
                    while (queue.TryTake(out var armorSet) && carryOn && !backgroundWorker.CancellationPending)
                    {
                        FindCombination(armorSet, _searchDecoCombos);
                    }

                    // If limit is reached, return armor sets
                    if (_Counter >= _SearchLimit || (isFinished && queue.Count == 0) || backgroundWorker.CancellationPending)
                    {
                        carryOn = false;
                    }
                }
            });

            while (!parallel.IsCompleted)
            {
                Thread.Sleep(500);
            }

            if (_SearchLimit != int.MaxValue && _ThreadSafe_Armor_Sets.Count > _SearchLimit)
            {
                _ArmorSetSearch = _ThreadSafe_Armor_Sets.Take(_SearchLimit).ToList();
            }
            else
            {
                _ArmorSetSearch = _ThreadSafe_Armor_Sets.ToList();
            }

            Invoke(new MethodInvoker(delegate ()
            {
                progressBarLabel.Text = ProgressBarText();
            }));
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage > 100 ? 100 : e.ProgressPercentage;
        }

        private void FindCombinationsParrallel(IEnumerable<ArmorSet> armorSets, long totalCombos, HashSet<Skill> searchSkills)
        {
            backgroundWorker = new BackgroundWorker();

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.DoWork += BackgroundWorker_FindCombinations;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_Completed;

            backgroundWorker.RunWorkerAsync(new SearchData { ArmorSets = armorSets, TotalCombos = totalCombos, SearchSkills = searchSkills });
        }

        private void BackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            DisplayArmorSets();

            StopStopWatch();

            //Enable buttons again
            searchButton.Enabled = true;
            clearButton.Enabled = true;
            cancelButton.Enabled = false;
        }

        private void FindCombination(ArmorSet armorset, HashSet<SkillDecoCombo> searchSkillDecos)
        {
            if (IsCriteriaMet(armorset, searchSkillDecos))
            {
                _ThreadSafe_Armor_Sets.Add(armorset);

                Interlocked.Increment(ref _Counter);

                var percentage = (_Counter / _SearchLimit) * 100;

                backgroundWorker.ReportProgress(percentage);
            }

            Interlocked.Increment(ref _ArmorsSearched);

            if (_ArmorsSearched % 1000 == 0)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    progressBarLabel.Text = ProgressBarText();
                }));
            }
        }

        private bool IsCriteriaMet(ArmorSet armorset, HashSet<SkillDecoCombo> searchSkills, bool populateSlot = false)
        {
            var slotCombos = armorset.GetSlotCombos();
            var skillTotals = armorset.GetSkillTotals();

            var requiredSlots = new SlotCombo();
            var requiredSlotPerSkill = new Dictionary<string, SlotCombo>();

            foreach (var skill in searchSkills)
            {
                requiredSlotPerSkill.Add(skill.Skill.Name, new SlotCombo());

                var skillNeeded = skill.Skill.Value;

                var hasSkillValue = skillTotals.TryGetValue(skill.Skill.Name, out var skillValue);

                if (hasSkillValue)
                {
                    skillNeeded -= skillValue;
                }

                if ((skillNeeded > 0 && slotCombos.Count == 0) || (skillNeeded > 0 && skill.Decoration == null))
                {
                    return false;
                }

                //If we don't have the skill required, and we have a decoration, great, let's calculate how many we need
                if (skillNeeded > 0 && skill.Decoration != null && slotCombos.Count > 0)
                {
                    switch (skill.Decoration.Type)
                    {
                        case SlotType.Small:
                            requiredSlots.Small += skillNeeded;
                            requiredSlotPerSkill[skill.Skill.Name].Small += skillNeeded;

                            break;
                        case SlotType.Medium:
                            requiredSlots.Medium += skillNeeded;
                            requiredSlotPerSkill[skill.Skill.Name].Medium += skillNeeded;
                            break;
                        case SlotType.Large:
                            requiredSlots.Large += skillNeeded;
                            requiredSlotPerSkill[skill.Skill.Name].Large += skillNeeded;
                            break;
                        case SlotType.ExtraLarge:
                            requiredSlots.ExtraLarge += skillNeeded;
                            requiredSlotPerSkill[skill.Skill.Name].ExtraLarge += skillNeeded;
                            break;
                    }
                }
            }

            //if no slots are required, then great!
            if (requiredSlots.Small + requiredSlots.Medium + requiredSlots.Large + requiredSlots.ExtraLarge == 0)
            {
                return true;
            }

            //Check the decorations needed against the slot combos, if we have one great! If not, then we return false.
            foreach (var combo in slotCombos)
            {
                if (requiredSlots.Small <= combo.Small && requiredSlots.Medium <= combo.Medium && requiredSlots.Large <= combo.Large && requiredSlots.ExtraLarge <= combo.ExtraLarge)
                {
                    if (populateSlot)
                    {
                        //Lets populate the skills
                        foreach (var slotPerSkill in requiredSlotPerSkill.OrderByDescending(z => z.Value.ExtraLarge).OrderByDescending(z => z.Value.Large).ThenByDescending(z => z.Value.Medium).ThenByDescending(z => z.Value.Small))
                        {
                            var skill = searchSkills.First(z => z.Skill.Name == slotPerSkill.Key);

                            armorset.TryPopulateSlot(skill.Decoration, slotPerSkill.Value);
                        }
                    }

                    return true;
                }
            }

            return false;
        }

        private string ProgressBarText()
        {
            return $"{(_Counter > _SearchLimit ? _SearchLimit : _Counter)} / {_SearchLimit} Found. Searched {_ArmorsSearched}.";
        }

        private void sortByList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ArmorSetSearch != null && _ArmorSetSearch.Count > 0)
            {
                DisplayArmorSets();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy && !backgroundWorker.CancellationPending)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!lowToolStripMenuItem.Checked || highToolStripMenuItem.Checked)
            {
                lowToolStripMenuItem.Checked = !lowToolStripMenuItem.Checked;
            }
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lowToolStripMenuItem.Checked || !highToolStripMenuItem.Checked)
            {
                highToolStripMenuItem.Checked = !highToolStripMenuItem.Checked;
            }
        }

        private void skillBox10_Leave(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            if (comboBox.SelectedIndex == -1)
            {
                comboBox.SelectedIndex = 0;
            }
            else if (comboBox.Items[comboBox.SelectedIndex].ToString() != "None")
            {
                _Skills.TryGetValue(comboBox.Items[comboBox.SelectedIndex].ToString(), out var value);

                foreach (var skillBox in _SkillBoxes)
                {
                    if (skillBox.SkillBox != comboBox && skillBox.SkillBox.SelectedIndex != -1)
                    {
                        _Skills.TryGetValue(skillBox.SkillBox.Items[skillBox.SkillBox.SelectedIndex].ToString(), out var compareValue);

                        if (value == compareValue)
                        {
                            comboBox.SelectedIndex = 0;

                            MessageBox.Show("Skill has already been selected.");

                            comboBox.Focus();

                            break;
                        }
                    }
                }
            }
        }

        private void charmSkill1Box_Leave(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            if (comboBox.SelectedIndex == -1)
            {
                comboBox.SelectedIndex = 0;
            }
            else if (comboBox.Items[comboBox.SelectedIndex].ToString() != "None")
            {
                _Skills.TryGetValue(comboBox.Items[comboBox.SelectedIndex].ToString(), out var value);

                foreach (var skillBox in _CharmSkillBoxes)
                {
                    if (skillBox.SkillBox != comboBox && skillBox.SkillBox.SelectedIndex != -1)
                    {
                        _Skills.TryGetValue(skillBox.SkillBox.Items[skillBox.SkillBox.SelectedIndex].ToString(), out var compareValue);

                        if (value == compareValue)
                        {
                            comboBox.SelectedIndex = 0;

                            MessageBox.Show("Skill has already been selected.");

                            comboBox.Focus();

                            break;
                        }
                    }
                }
            }
        }

        public class SkillComboBox
        {
            public ComboBox SkillBox { get; set; }
            public ComboBox ValueBox { get; set; }
            public ToolTip ToolTip { get; set; } = new ToolTip();

            public SkillComboBox(ComboBox skill, ComboBox value)
            {
                SkillBox = skill;
                ValueBox = value;
            }
        }

        public class SearchData
        {
            public IEnumerable<ArmorSet> ArmorSets { get; set; }
            public HashSet<Skill> SearchSkills { get; set; }
            public long TotalCombos { get; set; }
        }
    }
}