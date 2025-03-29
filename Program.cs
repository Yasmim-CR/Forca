Console.WriteLine("Digite uma palavra secreta:");
string palavra = Console.ReadLine()!;
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine()!.ToLower();

bool letraExiste = palavra.Contains(letra); 
Console.WriteLine($"A letra {letra} existe na palavra secreta => {letraExiste}"); 