// CARREGAR DADOS

var cliente1 = new Cliente
{
    Id = 1,
    Nome = "Mirella Sarah Brenda Duarte",
    Documento = "897.974.015-88",
    EstadoCivil = "Casada",
    Profissao = "Manicure",
};

cliente1.ListaFilho = new List<Filho>();

var filho1 = new Filho
{
    Id = 2,
    Nome = "Luan Severino das Neves",
    Documento = "075.119.758-01"
};

cliente1.ListaFilho.Add(filho1);


cliente1.ListaEndereco = new List<Endereco>();

var endereco1 = new Endereco
{
    Logradouro = "Travessa C1",
    Numero = "866",
    Bairro = "Zona de Expansão (Mosqueiro)",
    Cidade = "Aracaju",
    Estado = "SE"
};

cliente1.ListaEndereco.Add(endereco1);

// PRINTAR NA TELA

Console.WriteLine(cliente1);

foreach (var totalFilhos in cliente1.ListaFilho)
{
    Console.WriteLine($"{totalFilhos}");
}

foreach (var totalEnderecos in cliente1.ListaEndereco)
{
    Console.WriteLine($"{totalEnderecos}");
}

Console.WriteLine("");

// CARREGAR DADOS

var cliente2 = new Cliente
{
    Id = filho1.Id,
    Nome = filho1.Nome,
    Documento = filho1.Documento,
    Profissao = "Vaqueiro",
    EstadoCivil = "Casado"
};

cliente2.ListaEndereco = new List<Endereco>();

var endereco2 = new Endereco
{
    Logradouro = "Avenida das Jacas",
    Numero = "802",
    Bairro = "Infraero",
    Cidade = "Macapá",
    Estado = "AP"
};

cliente2.ListaEndereco.Add(endereco2);


cliente2.ListaFilho = new List<Filho>();

var filho2 = new Filho
{
    Id = 4,
    Nome = "Joaquim Edson Castro",
    Documento = "075.119.758-01"
};

cliente2.ListaFilho.Add(filho2);

var filho3 = new Filho
{
    Id = 8,
    Nome = "Henry Erick da Luz",
    Documento = "136.694.870-00"
};

cliente2.ListaFilho.Add(filho3);

// PRINTAR NA TELA

Console.WriteLine(cliente2);

foreach (var totalFilhos in cliente2.ListaFilho)
{
    Console.WriteLine($"{totalFilhos}");
}

foreach (var totalEnderecos in cliente2.ListaEndereco)
{
    Console.WriteLine($"{totalEnderecos}");
}

Console.WriteLine("");


var cliente3 = new Cliente
{
    Id = filho2.Id,
    Nome = filho2.Nome,
    Documento = filho2.Documento,
    Profissao = "Motorista de Aplicativo",
    EstadoCivil = "Divorciado"
};

cliente3.ListaFilho = new List<Filho>();

var filho4 = new Filho
{
    Id = 16,
    Nome = "Alexandre Ruan Miguel Nogueira",
    Documento = "243.434.466-62"
};

cliente3.ListaFilho.Add(filho4);

var filho5 = new Filho
{
    Id = 32,
    Nome = "Mariane Kamilly",
    Documento = "366.808.151-42"
};

cliente3.ListaFilho.Add(filho5);

var filho6 = new Filho
{
    Id = 64,
    Nome = "Noah Thomas Nathan Nogueira",
    Documento = "102.932.370-42"
};

cliente3.ListaFilho.Add(filho6);

cliente3.ListaEndereco = new List<Endereco>();

var endereco3 = new Endereco
{
    Logradouro = "Rua Inglaterra",
    Numero = "176",
    Bairro = "Jardim Europa",
    Cidade = "Ariquemes",
    Estado = "RO"
};

cliente3.ListaEndereco.Add(endereco3);



// CARREGAR DADOS

var cliente4 = new Cliente
{
    Id = filho3.Id,
    Nome = filho3.Nome,
    Documento = filho3.Documento,
    Profissao = "Jardineiro",
    EstadoCivil = "Viúvo"
};

cliente4.ListaEndereco = new List<Endereco>();

var endereco4 = new Endereco
{
    Logradouro = "Rua Joel da Cunha Mendes 1066",
    Numero = "758",
    Bairro = "Piçarra",
    Cidade = "Teresina",
    Estado = "PI"
};

cliente4.ListaEndereco.Add(endereco4);

// PRINTAR NA TELA

Console.WriteLine(cliente3);

foreach (var totalFilhos in cliente3.ListaFilho)
{
    Console.WriteLine($"{totalFilhos}");
}

foreach (var totalEnderecos in cliente3.ListaEndereco)
{
    Console.WriteLine($"{totalEnderecos}");
}

Console.WriteLine("");

// PRINTAR NA TELA

Console.WriteLine(cliente4);

foreach (var totalEnderecos in cliente4.ListaEndereco)
{
    Console.WriteLine($"{totalEnderecos}");
}

Console.WriteLine("");