using System;

public class GeracaoTextoService
{
    public string GerarDescricaoProduto(string nomeProduto, string categoria)
    {
        // Aqui você poderia utilizar um modelo de NLP para gerar descrições mais precisas.
        // Para simplificação, vamos gerar uma descrição fictícia.
        return $"O {nomeProduto} é um excelente produto da categoria {categoria}, ideal para quem busca qualidade e desempenho.";
    }
}
