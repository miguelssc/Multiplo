int numero;
int divisor;
Console.WriteLine("digite um numero");
numero =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite outro numero");
divisor =Convert.ToInt32(Console.ReadLine());

int definiçao = numero % divisor;

if(definiçao == 0){
    Console.WriteLine($"{numero} e multiplo de {divisor}");
}
else{
    Console.WriteLine($"{numero} nao e multiplo de {divisor}");
}

