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
        float warbuffer = 0;
        float rogbuffer = 0;
        float wizbuffer = 0;
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
                warbuffer += 1;
                warrior.strength = Convert.ToInt32(30 + warbuffer);
                lbStrength.Content = $"Strength: {warrior.strength}";
            }
            if (choice.SelectedItem.ToString() == "Rogue")
            {
                rogbuffer += 1;
                rogue.strength = Convert.ToInt32(20 + rogbuffer);
                lbStrength.Content = $"Strength: {rogue.strength}";
            }
            if (choice.SelectedItem.ToString() == "Wizard")
            {
                wizbuffer += 1;
                wizard.strength = Convert.ToInt32(15 + wizbuffer);
                lbStrength.Content = $"Strength: {wizard.strength}";
            }
        }
    }
}
