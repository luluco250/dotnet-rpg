class Actor {
	public string name = "";
	public int health = 100;
	public int stamina = 100;
	public int mana = 100;

	public override string ToString() =>
		$"[{name}]\n" +
		$"HP: {health}\n" +
		$"SP: {stamina}\n" +
		$"MP: {mana}";
}