string country = Console.ReadLine();
string spoken = "";

switch (country)
{
    case "USA":
    case "England":
        spoken = "English";
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        spoken = "Spanish";
        break;
    default:
        spoken = "unknown";
        break;
}

Console.WriteLine(spoken);