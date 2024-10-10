int n = int.Parse(Console.ReadLine()); // taking a number

int numberCopy = n; //making a copy
int fact = 1; // setting factorial to 1 because if we have it 0 we cannot get anything by multiplying by 0
int sum = 0; // a sum for factorial of each digit

// calculations for each digit factorial
while(numberCopy > 0)
{
    int digits = numberCopy % 10; // ex: 145 / 10 = 14.5 and we yoink only 5
    numberCopy /= 10; // 145 / 10 = 14.5 that .5 gets yeeted

    // factorial calculation for digit
    fact = 1;
    for(int i = 1; i <= digits; i++)
    {
        fact *= i;
    }

    sum += fact; // factorial sum from each digit

}

//checking if it is strong
bool isStrong = sum == n;

Console.WriteLine(isStrong ? "yes" : "no");