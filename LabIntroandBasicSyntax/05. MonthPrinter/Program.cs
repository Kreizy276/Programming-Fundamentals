int month = int.Parse(Console.ReadLine());
string assignment = "";

if(month > 12 || month < 1)
{
    Console.WriteLine("Error!");
}
else
{
    switch (month)
{
    case 1:
        assignment = "January";
        break;
    case 2:
        assignment = "February";
        break;
    case 3:
        assignment = "March";
        break;
    case 4:
        assignment = "April";
        break;
    case 5:
        assignment = "May";
        break;
    case 6:
        assignment = "June";
        break;
    case 7:
        assignment = "July";
        break;
    case 8:
        assignment = "August";
        break;
    case 9:
        assignment = "September";
        break;
    case 10:
        assignment = "Octonber";
        break;
    case 11:
        assignment = "November";
        break;
    case 12:
        assignment = "December";
        break;
}

    Console.WriteLine(assignment);
}