// See https://aka.ms/new-console-template for more information

double n1,n2,maior;

Console.Write("Digite o 1º valor: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o 2º valor: ");
n2 = Convert.ToDouble(Console.ReadLine());

if(n1>n2){
    maior = n1;

}else{
    maior = n2;
}

Console.WriteLine($"Maior número é {maior}");