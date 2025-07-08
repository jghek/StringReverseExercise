using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using StringReverseExercise;

namespace BenchmarkApp;

public class StringReverserBenchmark
{
	private readonly StringReverser _stringReverser = new StringReverser();
	private readonly string text = "Hello developer. Do you like any of these fruits: apple, pear, banana? I do!";

	[Benchmark]
	public string Exercise1() => _stringReverser.Exercise1(text);

	[Benchmark]
	public string Exercise2() => _stringReverser.Exercise2(text);

	[Benchmark]
	public string Exercise31() => _stringReverser.Exercise31(text);

	[Benchmark]
	public string Exercise32() => _stringReverser.Exercise32(text);

	[Benchmark]
	public string Exercise33() => _stringReverser.Exercise33(text);
}

public class Program
{
	public static void Main(string[] args)
	{
		var summary = BenchmarkRunner.Run<StringReverserBenchmark>();
	}
}

