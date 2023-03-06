using static Library;
int count = getNumber("Задайте кол-во элементов массива: ");
int[] array = new int[count];
fillArray(array);
string elMassiv = "[ " + printArray(array) + " ]";
Console.WriteLine(elMassiv);
