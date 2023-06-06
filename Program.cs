Console.WriteLine("-=-Fluxograma da engenharia-=-\n");

Console.Write("O objeto está se movendo?");
    bool estasemovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria?");
    bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (!estasemovendo)
    {
        if (!deveria) 
        {
            mensagem = "Ótimo.";
        }
        else
        {
            mensagem = "Use WD-40.";
        }
    }
else 
    {
        if (deveria)
        {
            mensagem = "Ótimo.";
        }
        else
        {
            mensagem = "use Silver Tape.";
        }
    }

Console.WriteLine();
Console.Write(mensagem);











