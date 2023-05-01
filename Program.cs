Menu();
static void Menu()
{
    Console.Clear();
    System.Console.WriteLine("O que você deseja fazer?");
    System.Console.WriteLine("1 -  Abrir o arquivo");
    System.Console.WriteLine("2 - Criar novo arquivo");
    System.Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: break;
    }

}

static void Editar()
{
    Console.Clear();

    System.Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    System.Console.WriteLine("-----------------------");
    string text = "";
    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;

    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    System.Console.WriteLine(text);

    Salvar(text);
}

static void Abrir()
{
    Console.Clear();
    System.Console.WriteLine("Qual o caminho do arquivo??");
    string path = Console.ReadLine();
    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        System.Console.WriteLine(text);
    }
}

static void Salvar(string text)
{
    System.Console.WriteLine("Qual caminho para salvar o arquivo?");
    var path = Console.ReadLine();
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }
    System.Console.WriteLine($"Arquivo {path} foi salvo com sucesso");
    Menu();
}