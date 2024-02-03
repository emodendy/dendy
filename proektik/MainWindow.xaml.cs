using System;
using System.Collections.Generic;
using System.Linq;
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
 
            }
            if (choice.SelectedItem.ToString() == "Rogue") 
            {

                    HP.Content = $"HP: {rogue.health}";
                    MANA.Content = $"MANA: {rogue.mana}";
                    lbDexterity.Content = $"dexterity: {rogue.dexterity}";
                    lbInteligence.Content = $"Inteligence: {rogue.inteligence}";
                    lbStrength.Content = $"Strength: {rogue.strength}";
                    lbVitality.Content = $"Vitality: {rogue.vitality}";

            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                    HP.Content = $"HP: {wizard.health}";
                    MANA.Content = $"MANA: {wizard.mana}";
                    lbDexterity.Content = $"dexterity: {wizard.dexterity}";
                    lbInteligence.Content = $"Inteligence: {wizard.inteligence}";
                    lbStrength.Content = $"Strength: {wizard.strength}";
                    lbVitality.Content = $"Vitality: {wizard.vitality}";
            }
        }

        private void str_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem.ToString() == "Warrior")
            {
                if (warrior.strength < warrior.maxStrength)
                {
                    if (tokens > 0)
                    {
                        warrior.strength += 1;
                        lbStrength.Content = $"Strength: {warrior.strength}";
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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

        private void dex_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem.ToString() == "Warrior")
            {
                if (warrior.dexterity < warrior.maxDexterity)
                {
                    if (tokens > 0)
                    {
                        warrior.dexterity += 1;
                        lbDexterity.Content = $"Dexterity: {warrior.dexterity}";
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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

        private void vit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == "Warrior")
            {
                if (warrior.vitality < wizard.maxVitality)
                {
                    if (tokens > 0)
                    {
                        warrior.vitality += 1;
                        lbVitality.Content = $"Vitality: {warrior.vitality}";
                        warrior.health += 2;
                        HP.Content = $"HP: {warrior.health}";
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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

        private void int_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == "Warrior")
            {
                if (warrior.inteligence < warrior.maxInteligence) 
                { 
                    if (tokens > 0)
                    {
                        warrior.inteligence += 1;
                        lbInteligence.Content = $"Inteligence: {warrior.inteligence}";
                        warrior.mana += 1;
                        MANA.Content = $"MANA: {warrior.mana}";
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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
                        TokenCount.Text = (tokens - 1).ToString();
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

        private void TokenCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                tokens = Convert.ToInt32(TokenCount.Text);
            }catch (FormatException)
            {
                MessageBox.Show("Введите число,а не строку!!!");
            }
           
        }
    }
}
