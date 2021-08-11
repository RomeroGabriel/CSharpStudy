<Query Kind="Statements" />

var sequences =  new [] { "red,blue,green", "orange", "white, pink" };
var allWords = sequences.SelectMany(s => s.Split(','));
Console.WriteLine(allWords);

string [] objects = { "house", "car", "bicycle" };
string [] colors = { "red", "green", "gray" };
var pars = colors.SelectMany(_ => 
	objects, (c, o) => new { Color = c, Obj = o });
Console.WriteLine(pars);