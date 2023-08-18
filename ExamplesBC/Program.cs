using ExamplesBC;
// class examples


Student.Print("This is a static method dispaly");

var david = new Student("David");
var megan = new Student("Megan");

var tony = new Student("Tony", "AZ");
tony.Name = "Tony";
tony.State = "AZ";

var josh = new Student();
var greg = new Instructor();

Console.WriteLine($"Id [{ david.Id}] The name is [{david.Name}] State is [{david.State}]");

tony.ChangeName("Anthony");


Console.WriteLine($"Students are {megan.Name} and {tony.Name}");

Console.WriteLine($"ID [{megan.Id}] The name is [{megan.Name}] State is [{megan.State}]");
Console.WriteLine($"ID [{tony.Id}] The name is [{tony.Name}] State is [{tony.State}]");
/*
var stateCode = "OH";
var stateName = "";


//swtich expression
stateName = stateCode switch
{
    "OH" => "Ohio",
    "KY" => "Kentucky",
    "IN" => "Indiana",
    _ => "I don't know"
};

// switch statement
switch(stateCode)
{
    case "OH":
        stateName = "Ohio";
        break;
    case "KY":
        stateName = "Kentucky";
        break;
    case "IN":
        stateName = "Indiana";
        break;
    default:
        stateName = "I don't know";
        break;
}
if(stateCode == "OH")
{
    stateName = "Ohio";
} else if (stateCode == "KY")
{
    stateName = "Kentucky";
} else if (stateCode == "IN")
{
    stateName = "Indiana";
} else
{
    stateName = "I don't know";
}
int[] collection = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for(i = -; i < collectoin.length; i++)
{
    var item = 0;
    item += collection[i];
    return item;
}
var answer = 0;
foreach(var anInt in collection) {
    answer += anInt;
}
Console.WriteLine(anInt);
*/