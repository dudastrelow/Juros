// Montante = valor + juros
// Montante = principal + (Principal * Taxa de juros * Numero de periodos)

// 1 mes: M = P *(1 + i) -- M = P * (1 + i)^n



using System;
class juros
{
    static void menu()
    {
        List<string> valores = new List<string>();
        valores.Add("1 - Juros");
        valores.Add("0 - Sair do programa");
        valores.Add("\nEscolha uma opção\n");

        foreach (string item in valores)
        {
            Console.WriteLine(item.ToString());
        }
    }
    static void Main(string[] args)
    {
        byte opção = 0;
        while(true)
        {
            opção = Convert.ToByte(Console.ReadLine());
            switch(opção)
            {
                case 0:
                    Console.WriteLine("Obrigada por usar esse programa");
                    goto saida;
                    break;
                case 1:
                    DateTime datanasmineto;
                    Console.WriteLine("Quantas pessosas vão querer ingresso?");
                    ingresso = Convert.ToByte(Console.ReadLine());
                    int[] idades = new int[ingresso];

                    for (int i = 0; i < idades.Length; i++)
                    {
                        Console.WriteLine($"Informe a data de nascimento da pessoa {i + 1}:");
                        idades[i] = idadess(Convert.ToDateTime(Console.ReadLine()));
                    }
                    preço = ingressos(idades);
                    Console.WriteLine("\nO valor do(s) ingressos ficou " + preço.ToString("0.00") + "\n"); Console.WriteLine($"\n{nome}, você NÃO pode entar na festa\n");
                    }
                    break;
            }
        }
    saida:;
    }
    static int CalcularIdade(DateTime dataNascimento)
        {
 
   

}
}
