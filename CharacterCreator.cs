using System;
using System.Linq;
using System.Collections.Generic;

static class CharacterCreator {
	static Dictionary<string, Actor> classes = new Dictionary<string, Actor>{
		{"Warrior", new Actor{

		}}
	};

	public static void Begin(out Actor character) {
		throw new NotImplementedException();
		
		var name = Utils.GetPlayerInput("Please enter your character's name");
		var characterClass = Utils.GetPlayerChoice(
			"Choose your character's class",
			classes.Keys.ToArray()
		);
		
		//character = classes[]
	}
}