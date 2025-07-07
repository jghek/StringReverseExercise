namespace StringReverseExercise.Tests;

public class ExerciseTests
{
	[Fact]
	public void Cc_StringReverser()
	{
		// act
		var c = new StringReverser();

		// assert
		Assert.NotNull(c);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "do! I banana? pear, apple, fruits: these of any like you Do developer. Hello")]
	[InlineData("Hello World!", "World! Hello")]
	public void Opdracht1_WithText_ReturnsReversedText(string s, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string result = c.Exercise1(s);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od")]
	[InlineData("Hello World!", "olleH !dlroW")]
	public void Opdracht2_WithText_ReturnsReversedWords(string s, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string result = c.Exercise1(s);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "OLLEH .REPOLEVED OD UOY EKIL YNA FO ESEHT :STIURF ,ELPPA ,RAEP ?ANANAB I !OD")]
	[InlineData("Hello World!", "OLLEH !DLROW")]
	public void Opdracht3_1_WithText_ReturnsReversedCasing(string s, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string result = c.Exercise1(s);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "Olleh .Repoleved Od Uoy Ekil Yna Fo Eseht :Stiurf ,Elppa ,Raep ?Ananab I !Od")]
	[InlineData("Hello World!", "Olleh !dlroW")]
	public void Opdracht3_2_WithText_ReturnsReversedEachWordCapitalized(string s, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string result = c.Exercise1(s);

		//assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("Hello developer. Do you like any of these fruits: apple, pear, banana? I do!", "Olleh. Repoleved od uoy ekil yna fo eseht :stiurf ,elppa ,raep? Ananab i! Od")]
	[InlineData("Hello World!", "Olleh !dlrow")]
	public void Opdracht3_3_WithText_ReturnsReversedEachFirstWordCapitalized(string s, string expected)
	{
		//arrange
		var c = new StringReverser();

		//act
		string result = c.Exercise1(s);

		//assert
		Assert.Equal(expected, result);
	}
}