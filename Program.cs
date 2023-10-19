// CARREGAR DADOS

var cliente1 = new Cliente
{
    Id = 1,
    Nome = "Mirella Sarah Brenda Duarte",
    Documento = "897.974.015-88",
    EstadoCivil = "Casada",
    Profissao = "Manicure",
    ListaFilho = new List<Cliente>(),
    Endereco = new Endereco
    {
        Logradouro = "Travessa C1",
        Numero = "866",
        Bairro = "Zona de Expansão (Mosqueiro)",
        Cidade = "Aracaju",
        Estado = "SE"
    }
};

var filho1 = new Cliente
{
    Id = 2,
    Nome = "Luan Severino das Neves",
    Documento = "075.119.758-01",
    EstadoCivil = "Casado",
    Profissao = "Vaqueiro",
    ListaFilho = new List<Cliente>(),
    Endereco = new Endereco
    {
        Logradouro = "Avenida das Jacas",
        Numero = "802",
        Bairro = "Infraero",
        Cidade = "Macapá",
        Estado = "AP"
    }
};

cliente1.ListaFilho.Add(filho1);

// PRINTAR NA TELA

Console.WriteLine(cliente1);

foreach (var totalFilhos in cliente1.ListaFilho)
{
    Console.WriteLine($"{totalFilhos}");
}

Console.WriteLine(cliente1.Endereco);

Console.WriteLine("");



// CARREGAR DADOS

var filho2 = new Cliente
{
    Id = 4,
    Nome = "Joaquim Edson Castro",
    Documento = "075.119.758-01",
    EstadoCivil = "Divorciado",
    Profissao = "Motorista de Aplicativo",
    ListaFilho = new List<Cliente>(),
    Endereco = new Endereco
    {
        Logradouro = "Rua Inglaterra",
        Numero = "176",
        Bairro = "Jardim Europa",
        Cidade = "Ariquemes",
        Estado = "RO"
    }
};

filho1.ListaFilho.Add(filho2);

var filho3 = new Cliente
{
    Id = 8,
    Nome = "Henry Erick da Luz",
    Documento = "136.694.870-00",
    EstadoCivil = "Viúvo",
    Profissao = "Jardineiro",
    Endereco = new Endereco
    {
        Logradouro = "Rua Joel da Cunha Mendes 1066",
        Numero = "758",
        Bairro = "Piçarra",
        Cidade = "Teresina",
        Estado = "PI"
    }
};

filho1.ListaFilho.Add(filho3);

// PRINTAR NA TELA

Console.WriteLine(filho1);

foreach (var totalFilhos in filho1.ListaFilho)
{
    Console.WriteLine($"{totalFilhos}");
}

Console.WriteLine(filho1.Endereco);

Console.WriteLine("");



// CARREGAR DADOS

var filho4 = new Cliente
{
    Id = 16,
    Nome = "Alexandre Ruan Miguel Nogueira",
    Documento = "243.434.466-62",
    EstadoCivil = "Solteiro",
    Profissao = "Chef de Cozinha"
};

filho2.ListaFilho.Add(filho4);

var filho5 = new Cliente
{
    Id = 32,
    Nome = "Mariane Kamilly",
    Documento = "366.808.151-42",
    EstadoCivil = "Solteira",
    Profissao = "Engenheira Civil"
};

filho2.ListaFilho.Add(filho5);

var filho6 = new Cliente
{
    Id = 64,
    Nome = "Noah Thomas Nathan Nogueira",
    Documento = "102.932.370-42",
    EstadoCivil = "União Estável",
    Profissao = "Caminhoneiro"
};

filho2.ListaFilho.Add(filho6);


// PRINTAR NA TELA

Console.WriteLine(filho2);

foreach (var totalFilhos in filho2.ListaFilho)
{
    Console.WriteLine($"{totalFilhos}");
}

Console.WriteLine(filho2.Endereco);

Console.WriteLine("");

// PRINTAR NA TELA

Console.WriteLine(filho3);
Console.WriteLine(filho3.Endereco);
Console.WriteLine("");