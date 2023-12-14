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

namespace CA2_S00240478
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Team> Teams = new List<Team>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetData(object sender, RoutedEventArgs e)
        {
            // Teams
            Team t1 = new Team() { Name = "France" };
            Team t2 = new Team() { Name = "Italy" };
            Team t3 = new Team() { Name = "Spain" };

            // French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

            // Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            // Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

            // Added players to teams
            
            t1.Players = new List<Player> { p1, p2, p3 };
            Teams.Add(t1);
            t2.Players = new List<Player> { p4, p5, p6 };
            Teams.Add(t2);
            t3.Players = new List<Player> { p7, p8, p9 };
            Teams.Add(t3);

            // Added teams to team listbox
            lbxTeams.ItemsSource = Teams;        
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selectedTeam = lbxTeams.SelectedItem as Team;

            if (selectedTeam != null)
            {
                lbxPlayers.ItemsSource = selectedTeam.Players;
            }
        }

        private void UpdateRecord(char result)
        {
            Player selectedPlayer = lbxPlayers.SelectedItem as Player;
            if (selectedPlayer != null)
            {
                string updatedRecord = selectedPlayer.ResultRecord.Substring(1) + result;
                selectedPlayer.ResultRecord = updatedRecord;
            }

            Team selectedTeam = lbxTeams.SelectedItem as Team;
            if (selectedTeam != null)
            {
                lbxPlayers.ItemsSource = null;
                lbxPlayers.ItemsSource = selectedTeam.Players;

                lbxTeams.ItemsSource = null;
                lbxTeams.ItemsSource = Teams;
                lbxTeams.SelectedItem = selectedTeam;
            }
        }

        private void btnWin_Click(object sender, RoutedEventArgs e)
        {
            UpdateRecord('W');
        }

        private void btnLoss_Click(object sender, RoutedEventArgs e)
        {
            UpdateRecord('L');
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            UpdateRecord('D');
        }
    }
}
