string userName = "Daria";
Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}");
//int counter = 0;
//for(int i = 0; i < userName.Length; i++)
//{
//    if (userName[i] == 'a')
//    {  counter++; }
//}
//Console.WriteLine($"Your name has {counter} a-letters");
string updatedUserName = userName.Replace('a', '4').Replace('r', '3');
Console.WriteLine(updatedUserName);
