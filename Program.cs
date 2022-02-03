CriarDiretorioGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "Modelo.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "LCK", "Danwon Gaming KIA", "DK.txt");

CopiarArquivo(origem, destino);
static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("O arquivo de origem não existe");
        return;
    }
    if(File.Exists(pathDestino))
    {
        Console.WriteLine("O arquivo já existe na pasta de destino");
        return;
    }   
    File.Copy(pathOrigem, pathDestino);
}

MoverArquivo(origem, destino);
static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("O arquivo de origem não existe");
        return;
    }
    if(File.Exists(pathDestino))
    {
        Console.WriteLine("O arquivo já existe na pasta de destino");
        return;
    }
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Modelo.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Top: ");
        sw.WriteLine("Jungler: ");
        sw.WriteLine("Mid: ");
        sw.WriteLine("Adc: ");
        sw.WriteLine("Suporte: ");
    }
}

static void CriarDiretorioGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if(!Directory.Exists(path))
    {
        var DirGlobo = Directory.CreateDirectory(path);
        var DirCoreia = DirGlobo.CreateSubdirectory("LCK");
        var DirChina = DirGlobo.CreateSubdirectory("LPL");
        var DirEuropa = DirGlobo.CreateSubdirectory("LEC");
        var DirAmericaDoNorte = DirGlobo.CreateSubdirectory("LCS");

        DirCoreia.CreateSubdirectory("T1");
        DirCoreia.CreateSubdirectory("Geng");
        DirCoreia.CreateSubdirectory("Danwon Gaming KIA");

        DirChina.CreateSubdirectory("EDG");
        DirChina.CreateSubdirectory("RNG");
        DirChina.CreateSubdirectory("LNG");

        DirEuropa.CreateSubdirectory("G2");
        DirEuropa.CreateSubdirectory("FNATIC");
        DirEuropa.CreateSubdirectory("Rogue");


        DirAmericaDoNorte.CreateSubdirectory("Team Liquid");
        DirAmericaDoNorte.CreateSubdirectory("Evil Genius");
        DirAmericaDoNorte.CreateSubdirectory("100 Thievs");
    }
}



