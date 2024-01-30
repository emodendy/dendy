﻿using System;
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
        double hpwarbuffer = 0;
        double hprogbuffer = 0;
        double hpwizbuffer = 0;
        double manawarbuffer = 0;
        double manarogbuffer = 0;
        double manawizbuffer = 0.5;

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
                warrior.strength +=1;
                lbStrength.Content = $"Strength: {warrior.strength}";
            }
            if (choice.SelectedItem.ToString() == "Rogue")
            {
                rogue.strength += 1;
                lbStrength.Content = $"Strength: {rogue.strength}";
            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                wizard.strength += 1;
                lbStrength.Content = $"Strength: {wizard.strength}";
            }
        }

        private void dex_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem.ToString() == "Warrior")
            {
                warrior.dexterity += 1;
                lbDexterity.Content = $"Dexterity: {warrior.dexterity}";
            }
            if (choice.SelectedItem.ToString() == "Rogue")
            {
                rogue.dexterity += 1;
                lbDexterity.Content = $"Dexterity: {rogue.dexterity}";
            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                rogue.dexterity += 1;
                lbDexterity.Content = $"Dexterity: {rogue.dexterity}";
            }
        }

        private void vit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == "Warrior")
            {
                warrior.vitality += 1;
                lbVitality.Content = $"Vitality: {warrior.vitality}";
                warrior.health += 2;
                HP.Content = $"HP: {warrior.health}";
            }
            if (choice.SelectedItem.ToString() == "Rogue")
            {
                rogue.vitality += 1;
                lbVitality.Content = $"Vitality: {rogue.vitality}";
                hprogbuffer += 1.5;
                rogue.health = Convert.ToInt32(30 + hprogbuffer);
                HP.Content = $"HP: {rogue.health}";
            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                wizard.vitality += 1;
                lbVitality.Content = $"Vitality: {wizard.vitality}";
                hpwizbuffer += 1.4;
                wizard.health = Convert.ToInt32(21 + hpwizbuffer);
                HP.Content = $"HP: {wizard.health}";
            }
        }

        private void int_btn_Click(object sender, RoutedEventArgs e)
        {
            if (choice.SelectedItem == "Warrior")
            {
                warrior.inteligence += 1;
                lbInteligence.Content = $"Inteligence: {warrior.inteligence}";
                warrior.mana += 1;
                MANA.Content = $"MANA: {warrior.mana}";
            }
            if (choice.SelectedItem.ToString() == "Rogue")
            {
                rogue.inteligence += 1;
                lbInteligence.Content = $"Inteligence: {rogue.inteligence}";
                manarogbuffer += 1.2;
                rogue.mana = Convert.ToInt32(18 + manarogbuffer);
                MANA.Content = $"MANA: {rogue.mana}";
            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                wizard.inteligence += 1;
                lbInteligence.Content = $"Inteligence: {wizard.inteligence}";
                manawizbuffer += 1.5;
                wizard.mana = Convert.ToInt32(52 + manawizbuffer);
                MANA.Content = $"MANA: {wizard.mana}";
            }
        }
    }
}
