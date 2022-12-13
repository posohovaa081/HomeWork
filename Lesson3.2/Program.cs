// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

 int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool isPalindrome = IsPalindromeInt(numPalindrome);
bool IsPalindromeInt(int num)
{
    // num = 456654
    int temp = num;
    // temp = 456654
    int revert = 0;

    while (temp > 0)
    {
        //revert= 0*10=0 + 4=4
        //revert= 4*10=40 + 5=45
        //revert= 45*10=450 + 6=456
        //revert= 456*10=4560 + 6=4566
        //revert= 4566*10=45660 +5=45665
        //revert= 45665*10=456650 + 6=456654
        revert = (revert * 10) + (temp % 10);

        //temp = 45665
        //temp = 456
        //temp = 45
        //temp = 4
        temp /= 10;
    }

    return revert == num;
}
bool IsPalindromeString(string str)
{
    int size = str.Length;
    for (int i = 0; i <= size / 2; ++i)
    {
        if (str[i] != str[size - 1 - i])
        {
            return false;
           
        }
    }
    return true;
}
System.Console.WriteLine($"число {numPalindrome} {str}");