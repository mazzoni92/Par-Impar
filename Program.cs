Console.WriteLine("Digite um numero para verificar se é Par ou Impar: ");
int numero = Convert.ToInt32(Console.ReadLine());

if(numero % 2 == 0){
    Console.WriteLine($"O numero {numero} é Par");
}
else{
    Console.WriteLine($"O numero {numero} é Impar ");
}