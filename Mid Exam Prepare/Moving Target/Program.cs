using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> targets = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string input;
        int shotTargets = 0;
        int currentTarget = 0;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            int index = int.Parse(tokens[1]);
            bool indexExists = false;
            ShootTarget(targets, ref shotTargets, ref currentTarget, tokens, command, index, ref indexExists);
            indexExists = AddTarget(targets, tokens, command, index, indexExists);
            indexExists = Strike(targets, tokens, command, index, indexExists);
        }
        Console.WriteLine(string.Join("|", targets));
    }

    private static bool Strike(List<int> targets, string[] tokens, string command, int index, bool indexExists)
    {
        if (command.Contains("Strike"))
        {
            for (int i = 0; i < targets.Count; i++)
            {
                if (index == i)
                {
                    indexExists = true;
                    if (indexExists)
                    {
                        int radius = int.Parse(tokens[2]);
                        int targetsToStrikeRight = 0;
                        int targetsToStrikeLeft = 0;
                        for (int j = index + 1; j < targets.Count; j++)
                        {
                            targetsToStrikeRight++;
                            if (targetsToStrikeRight == radius)
                            {
                                break;
                            }
                        }
                        for (int k = index - 1; k >= 0; k--)
                        {
                            targetsToStrikeLeft++;
                            if (targetsToStrikeLeft == radius)
                            {
                                break;
                            }
                        }
                        if (radius == targetsToStrikeLeft && radius == targetsToStrikeRight)
                        {
                            if (targetsToStrikeLeft + targetsToStrikeRight == targets.Count - 1)
                            {
                                Console.WriteLine("Strike missed!");
                            }
                            else
                            {
                                for (int n = 0; n < radius + index; n++)
                                {
                                    for (int m = 0; m < targets.Count; m++)
                                    {
                                        if (m == index - radius)
                                        {
                                            targets.RemoveAt(index - radius);
                                            break;
                                        }
                                    }
                                }
                            }
                        }

                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                    }
                }
            }
            if (indexExists == false)
            {
                Console.WriteLine("Strike missed!");
            }
        }

        return indexExists;
    }

    private static bool AddTarget(List<int> targets, string[] tokens, string command, int index, bool indexExists)
    {
        if (command.Contains("Add"))
        {
            for (int i = 0; i < targets.Count; i++)
            {
                if (index == i)
                {
                    indexExists = true;
                }
                if (indexExists)
                {
                    int value = int.Parse(tokens[2]);
                    targets.Insert(index, value);
                    break;
                }
            }
            if (indexExists == false)
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        return indexExists;
    }

    private static void ShootTarget(List<int> targets, ref int shotTargets, ref int currentTarget, string[] tokens, string command, int index, ref bool indexExists)
    {
        if (command.Contains("Shoot"))
        {
            for (int i = 0; i < targets.Count; i++)
            {
                currentTarget = targets[i];
                if (index == i)
                {
                    indexExists = true;
                }
                if (indexExists)
                {
                    int power = int.Parse(tokens[2]);
                    currentTarget -= power;
                    targets[i] = currentTarget;
                    break;
                }
            }
            if (currentTarget <= 0)
            {
                shotTargets++;
                targets.Remove(currentTarget);
            }
        }
    }
}