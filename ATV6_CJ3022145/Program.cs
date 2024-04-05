
Console.WriteLine("Digite o número da atividade desejada: ");
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
//Atividade 1
case 1:
        Console.WriteLine("Atividade 1");
        int contador0 = 0;
        Console.WriteLine("Digite um número inteiro: ");
        int n1 = int.Parse(Console.ReadLine());

        while (contador0 < n1) 
        {
            contador0++;
            Console.WriteLine(contador0);
        }
        break;

    //Atividade 2    
case 2: 
        Console.WriteLine("Atividade 2");
        Console.WriteLine("Digite um número inteiro: ");
        int n2 = int.Parse(Console.ReadLine());
        int contador1 = 1;

        while (contador1 <= n2)
        {
            if (contador1 % 2 == 0)
            {
                Console.WriteLine(contador1);
            }
            contador1 += 1;
        }
        break;
    //Atividade 3
case 3:
        Console.WriteLine("Atividade 3");
        Console.WriteLine("Digite um número inteiro: ");
        int n3 = int.Parse(Console.ReadLine());
        int contador2 = 1000;

        while (contador2 >= n3)
        {
            if (contador2 % 2 == 0)
            {
                Console.WriteLine(contador2);
            }
            contador2 -= 1;
        }
        break;
    //Atividade 4
case 4:
        Console.WriteLine("Atividade 4");
        int n4 = 0, soma = 0;

        while (soma != 200)
        {
               Console.WriteLine("Digite um número inteiro: ");
               n4 = int.Parse(Console.ReadLine());
            if (n4 > 0)
            {
                soma += n4;
                if (soma >= 200)
                {
                    Console.WriteLine("A soma chegou a 200.");
                }
            }
        }
        break;
    //Atividade 5
case 5:
        Console.WriteLine("Atividade 5");
}