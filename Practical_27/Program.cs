
// C# 10 We don't need to use main Method
Console.WriteLine("Hello, World!");

// used text.jason globally in global.cs file
var names = new[] { "Janvi", "Vidhi", "Mahek", "Vrunda" };
var serialized = JsonSerializer.Serialize(names);
Console.WriteLine(serialized);

//Lambdaexpression c# 9
//Func<string> helloWorld = () => "Hello world";
//Lambdaexpression c# 10
var helloWorld = () => "Hello World";
Console.WriteLine(helloWorld());

//Lambdaexpression c# 9
//Func<string?> text = () => null;
//Lambdaexpression c# 10
var text = string? () => null;
Console.WriteLine(text());


