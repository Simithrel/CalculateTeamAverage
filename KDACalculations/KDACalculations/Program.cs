using PlayerStatsAveraging;
using System;
using System.Collections;
using static System.Console;

namespace KDACalculations
{
    class Program
    {
        static void Main()
        {
            ArrayList players = new ArrayList();
            string reply;

            WriteLine("Average scores for team\n");

            do
            {
                // Initialize variables
                string username;
                int kills = 0, deaths = 0, assists = 0, damage = 0;

                // Get username
                Write("Enter username: ");
                username = ReadLine() ?? "";

                // Get kills
                kills = GetIntInput("Enter kills: ");

                // Get deaths
                deaths = GetIntInput("Enter deaths: ");

                // Get assists
                assists = GetIntInput("Enter assists: ");

                // Get damage
                damage = GetIntInput("Enter damage: ");

                // Add player stats to list
                players.Add(new PlayerStats(username, kills, deaths, assists, damage));

                // Ask user to continue
                Write("Would you like to continue (y/n)? ");
                reply = ReadLine()?.ToLower();

            } while (reply != "n");

            // Calculate and display averages
            if (players.Count > 0)
            {
                double totalKills = 0, totalDeaths = 0, totalAssists = 0, totalDamage = 0;

                // calculates team average
                foreach (PlayerStats player in players)
                {
                    totalKills += player.Kills;
                    totalDeaths += player.Deaths;
                    totalAssists += player.Assists;
                    totalDamage += player.Damage;
                }

                double averageKills = totalKills / players.Count;
                double averageDeaths = totalDeaths / players.Count;
                double averageAssists = totalAssists / players.Count;
                double averageDamage = totalDamage / players.Count;

                WriteLine("\n--- Averages ---");
                WriteLine($"Average Kills: {averageKills:F2}");
                WriteLine($"Average Deaths: {averageDeaths:F2}");
                WriteLine($"Average Assists: {averageAssists:F2}");
                WriteLine($"Average Damage: {averageDamage:F2}");
            }
            else
            {
                WriteLine("No data to calculate averages.");
            }
            foreach (PlayerStats player in players)
            {
                WriteLine();
                WriteLine(player);
            }
            WriteLine();
        }

        // get valid integer input
        static int GetIntInput(string prompt)
        {
            while (true)
            {
                Write(prompt);
                if (int.TryParse(ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    WriteLine("Please enter a valid integer.");
                }
            }
        }
    }
}