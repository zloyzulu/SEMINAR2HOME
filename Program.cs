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

void TNum(int a){
    while (a > 999){

    int ed = a / 10;
    a = ed;

    } 
    if (a <= 999){
    int dec = a % 10;
    Console.WriteLine("Третья цифра : " + dec );
    } 
    if ( a < 100){
    Console.WriteLine("Третьей цифры нет");
    }
 }
 Console.WriteLine("Введите число");
 int a = Convert.ToInt32(Console.ReadLine());
 TNum(a);

*/


//Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
/*

void ChoiseDay(int num){
  if (num > 5 && num <= 7){
  Console.WriteLine("Выходной ");
  }
  else if (num <= 0 || num > 7) {
  Console.WriteLine("Это не то ");
  }
  else
  Console.WriteLine("Рабочие будни ");

}
Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
ChoiseDay(num);

*/
    
     
