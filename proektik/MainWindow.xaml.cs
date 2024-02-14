using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proektik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double hprogbuffer = 0;
        double hpwizbuffer = 0;
        double manarogbuffer = 0;
        double manawizbuffer = 0.5;
        int tokens = 0;
        int level = 1;
        int exp = 0;

        Warrior warrior = new Warrior();
        Rogue rogue = new Rogue();
        Wizard wizard = new Wizard();
        public MainWindow()
        {
            InitializeComponent();
            choice.ItemsSource = new List<string>()
            {
                "Warrior", "Rogue", "Wizard"
            };

        }
        private void choice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (choice.SelectedItem.ToString() == "Warrior")
            {
                HP.Content = $"HP: {warrior.health}";
                MANA.Content = $"MANA: {warrior.mana}";
                lbDexterity.Content = $"dexterity: {warrior.dexterity}";
                lbInteligence.Content = $"Inteligence: {warrior.inteligence}";
                lbStrength.Content = $"Strength: {warrior.strength}";
                lbVitality.Content = $"Vitality: {warrior.vitality}";
                phys_dmg.Content = $"p.dmg: {warrior.pdamage}";
                mag_dmg.Content = $"m.dmg: {warrior.mdamage}";
                crt_dmg.Content = $"crt.dmg: {warrior.crtDamage}";
                armor.Content = $"armor: {warrior.armor}";
                mag_def.Content = $"m.defense: {warrior.mdefense}";
                crt_chance.Content = $"crt_chance: {warrior.crtChance}";

            }
            if (choice.SelectedItem.ToString() == "Rogue")
            {

                HP.Content = $"HP: {rogue.health}";
                MANA.Content = $"MANA: {rogue.mana}";
                lbDexterity.Content = $"dexterity: {rogue.dexterity}";
                lbInteligence.Content = $"Inteligence: {rogue.inteligence}";
                lbStrength.Content = $"Strength: {rogue.strength}";
                lbVitality.Content = $"Vitality: {rogue.vitality}";
                phys_dmg.Content = $"p.dmg: {rogue.pdamage}";
                mag_dmg.Content = $"m.dmg: {rogue.mdamage}";
                crt_dmg.Content = $"crt.dmg: {rogue.crtDamage}";
                armor.Content = $"armor: {rogue.armor}";
                mag_def.Content = $"m.defense: {rogue.mdefense}";
                crt_chance.Content = $"crt_chance: {rogue.crtChance}";

            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                HP.Content = $"HP: {wizard.health}";
                MANA.Content = $"MANA: {wizard.mana}";
                lbDexterity.Content = $"dexterity: {wizard.dexterity}";
                lbInteligence.Content = $"Inteligence: {wizard.inteligence}";
                lbStrength.Content = $"Strength: {wizard.strength}";
                lbVitality.Content = $"Vitality: {wizard.vitality}";
                phys_dmg.Content = $"p.dmg: {wizard.pdamage}";
                mag_dmg.Content = $"m.dmg: {wizard.mdamage}";
                crt_dmg.Content = $"crt.dmg: {wizard.crtDamage}";
                armor.Content = $"armor: {wizard.armor}";
                mag_def.Content = $"m.defense: {wizard.mdefense}";
                crt_chance.Content = $"crt_chance: {wizard.crtChance}";
            }
        }

        private void str_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == null)
            {
                MessageBox.Show("Choose your character");
            }
            else
            {
                if (choice.SelectedItem.ToString() == "Warrior")
                {
                    if (warrior.strength < warrior.maxStrength)
                    {
                        if (tokens > 0)
                        {
                            warrior.strength += 1;
                            lbStrength.Content = $"Strength: {warrior.strength}";
                            warrior.health += 1;
                            HP.Content = $"HP: {warrior.health}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max HP is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Rogue")
                {
                    if (rogue.strength < rogue.maxStrength)
                    {
                        if (tokens > 0)
                        {
                            rogue.strength += 1;
                            lbStrength.Content = $"Strength: {rogue.strength}";
                            hprogbuffer += 0.5;
                            HP.Content = $"HP: {rogue.health}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max HP is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Wizard")
                {
                    if (wizard.strength < wizard.maxStrength)
                    {
                        if (tokens > 0)
                        {
                            wizard.strength += 1;
                            lbStrength.Content = $"Strength: {wizard.strength}";
                            hpwizbuffer += 0.2;
                            HP.Content = $"HP: {wizard.health}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max strength is reached!!!");
                    }
                }
            }
        }

        private void dex_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == null)
            {
                MessageBox.Show("Choose your character");
            }
            else
            {
                if (choice.SelectedItem.ToString() == "Warrior")
                {
                    if (warrior.dexterity < warrior.maxDexterity)
                    {
                        if (tokens > 0)
                        {
                            warrior.dexterity += 1;
                            lbDexterity.Content = $"Dexterity: {warrior.dexterity}";
                            warrior.crtDamage += 1;
                            crt_dmg.Content = $"crt.dmg: {warrior.crtDamage}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max dexterity is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Rogue")
                {
                    if (rogue.dexterity < rogue.maxDexterity)
                    {
                        if (tokens > 0)
                        {
                            rogue.dexterity += 1;
                            lbDexterity.Content = $"Dexterity: {rogue.dexterity}";
                            rogue.crtDamage += 1;
                            crt_dmg.Content = $"crt.dmg: {rogue.crtDamage}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max dexterity is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Wizard")
                {
                    if (wizard.dexterity < wizard.maxDexterity)
                    {
                        if (tokens > 0)
                        {
                            wizard.dexterity += 1;
                            lbDexterity.Content = $"Dexterity: {wizard.dexterity}";
                            wizard.crtDamage += 1;
                            crt_dmg.Content = $"crt.dmg: {wizard.crtDamage}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max dexterity is reached!!!");
                    }
                }
            }
        }

        private void vit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == null)
            {
                MessageBox.Show("Choose your character");
            }
            else
            {
                if (choice.SelectedItem.ToString() == "Warrior")
                {
                    if (warrior.vitality < wizard.maxVitality)
                    {
                        if (tokens > 0)
                        {
                            warrior.vitality += 1;
                            lbVitality.Content = $"Vitality: {warrior.vitality}";
                            warrior.health += 2;
                            HP.Content = $"HP: {warrior.health}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max vitality is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Rogue")
                {
                    if (rogue.vitality < rogue.maxVitality)
                    {
                        if (tokens > 0)
                        {
                            rogue.vitality += 1;
                            lbVitality.Content = $"Vitality: {rogue.vitality}";
                            hprogbuffer += 1.5;
                            rogue.health = Convert.ToInt32(30 + hprogbuffer);
                            HP.Content = $"HP: {rogue.health}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max vitality is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Wizard")
                {
                    if (wizard.vitality < wizard.maxVitality)
                    {
                        if (tokens > 0)
                        {
                            wizard.vitality += 1;
                            lbVitality.Content = $"Vitality: {wizard.vitality}";
                            hpwizbuffer += 1.4;
                            wizard.health = Convert.ToInt32(21 + hpwizbuffer);
                            HP.Content = $"HP: {wizard.health}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max vitality is reached!!!");
                    }
                }
            }
        }

        private void int_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == null)
            {
                MessageBox.Show("Choose your character");
            }
            else
            {
                if (choice.SelectedItem.ToString() == "Warrior")
                {
                    if (warrior.inteligence < warrior.maxInteligence)
                    {
                        if (tokens > 0)
                        {
                            warrior.inteligence += 1;
                            lbInteligence.Content = $"Inteligence: {warrior.inteligence}";
                            warrior.mana += 1;
                            MANA.Content = $"MANA: {warrior.mana}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max inteligence is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Rogue")
                {
                    if (rogue.inteligence < rogue.maxInteligence)
                    {
                        if (tokens > 0)
                        {
                            rogue.inteligence += 1;
                            lbInteligence.Content = $"Inteligence: {rogue.inteligence}";
                            manarogbuffer += 1.2;
                            rogue.mana = Convert.ToInt32(18 + manarogbuffer);
                            MANA.Content = $"MANA: {rogue.mana}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max inteligence is reached!!!");
                    }
                }
                if (choice.SelectedItem.ToString() == "Wizard")
                {
                    if (wizard.inteligence < wizard.maxInteligence)
                    {
                        if (tokens > 0)
                        {
                            wizard.inteligence += 1;
                            lbInteligence.Content = $"Inteligence: {wizard.inteligence}";
                            manawizbuffer += 1.5;
                            wizard.mana = Convert.ToInt32(52 + manawizbuffer);
                            MANA.Content = $"MANA: {wizard.mana}";
                            tokens--;
                            TokenCount.Content = $"{tokens}";
                        }
                        else
                        {
                            MessageBox.Show("Not enough tokens");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max inteligence is reached!!!");
                    }
                }
            }
        }
        public void UpdateLvl()
        {
            switch (level)
            {
                case 50:
                    MessageBox.Show("Max level reached!!!");
                    break;
                default:
                    if (exp < level * 1000)
                    {
                        experience.Content = $"experience: {exp}/{level * 1000}";
                    }
                    else
                    {
                        tokens += 5;
                        exp = exp - level * 1000;
                        level++;
                        lvl.Content = $"lvl: {level}";
                        experience.Content = $"experience: {exp}/{level * 1000}";
                        TokenCount.Content = $"{tokens}";
                    } break;
            }
        }
            private void btn100_Click(object sender, RoutedEventArgs e)
            {
                exp += 100;
                UpdateLvl();
            }

            private void btn500_Click(object sender, RoutedEventArgs e)
            {
                exp += 500;
                UpdateLvl();
        }

            private void btn1000_Click(object sender, RoutedEventArgs e)
            {
                exp += 1000;
                UpdateLvl();
            }
        }
    } 

