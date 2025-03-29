double dinheiro, taxad, meses, total;

Console.Clear();

Console.WriteLine("Capital [c] (R$):");
dinheiro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Taxa de juros [i] (%):");
taxad = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Tempo [t] (meses):");
meses = Convert.ToDouble(Console.ReadLine());

taxad = dinheiro * (taxad / 100) * meses;

total = dinheiro + taxad;

Console.WriteLine("Carregando...");
Thread.Sleep(3000);

Console.WriteLine($"Montante (R$): {total}");