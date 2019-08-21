using System;
using System.Collections.Generic;

static class Utils {
	public static string GetPlayerInput(string prompt = "Make your choice", bool canBeEmpty = false) {
		string input;

		while (true) {
			Console.Write(prompt + ": ");

			input = Console.ReadLine();

			if (!canBeEmpty && input.Length == 0) {
				Console.Error.WriteLine("Type something!");
				continue;
			}
			
			break;
		}

		return input;
	}

	public static int GetPlayerChoice(string prompt, string[] choices) {
		if (choices.Length < 2)
			return 0;

		string input;
		int choice;

		while (true) {
			for (int i = 0; i < choices.Length; ++i)
				Console.WriteLine($"{i + 1}: {choices[i]}");

			Console.Write(prompt + ": ");

			input = Console.ReadLine();

			if (!int.TryParse(input, out choice)) {
				Console.Error.WriteLine("Type an integer number!");
				continue;
			}

			if (choice < 1 || choice > choices.Length) {
				Console.Error.WriteLine($"Choose between 1 and {choices.Length}!");
				continue;
			}

			break;
		}

		return choice - 1;
	}

	public static int GetPlayerChoice(string[] choices)
		=> GetPlayerChoice("Make your choice", choices);
	
	public static string GetPlayerChoice<T>(Dictionary<string, T>.KeyCollection col) {
		throw new NotImplementedException();
	}
}