//Программа принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*

int Num(){
  int num = new Random().Next(100,1000);
  Console.WriteLine("Число: " + num);
  int dec = num / 10;
  int ed = dec % 10;
  int result = ed;
  return result;
 }

int number = Num(); 
Console.WriteLine("Второе число: " + number);

*/


//Программа, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

/*

Console.Write(TNum());
int TNum(){
Console.WriteLine("Введите число : " );
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100){
Console.WriteLine("Третьей цифры нет ");   
return 0;

}
else{

if(num > 999){
while(num > 999){
num = num / 10;
    }
}
else{
    num = num % 10;
}
}
int result = num % 10;
return result;

}

*/


//Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
/*

Console.Write("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void ChoiseDay (int num){
  if (num == 6 || num == 7){
  Console.WriteLine("Выходной ");
  }
  else if (num < 1 || num > 7) {
  Console.WriteLine("Это не то ");
  }
  else
  Console.WriteLine("Не выходной ");

}

ChoiseDay(num);

*/
 
 
 
 
 
  /*  
 //Хотел создать нерандомное решение первой задачи, 
 //но так и не нашел ошибку... 
 //Почему программа выдает третье число вместо второго?
 
Console.Write(TNum());
int TNum(){
Console.WriteLine("Введите трехзначное число : " );
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 100){
return 0;

}
else{
 
if(num <= 999)
  while(num > 999){
num = num / 10;  
}
else{
    num = num % 10;
}
}
int result = num % 10;
return result;

}

*/
    
     