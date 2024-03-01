﻿// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Gasc Music";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};  

void ExibirLogo()
{
    Console.WriteLine(
        @"Ꮆ闩丂⼕ 爪ㄩ丂讠⼕"
        );
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite sua opção:");
}

ExibirLogo();
ExibirLogo();
ExibirOpcoesDoMenu();

Console.ReadLine();