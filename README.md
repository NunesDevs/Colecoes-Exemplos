# Colecoes-Exemplos

Exemplos interativos de arrays, listas, filas, pilhas e dicionários em uma aplicação de console C#.

## Funcionalidades verificadas

- Manipulação de arrays.
- Listas e ordenação.
- Filas e pilhas.
- Dicionários.

## Operação e arquitetura verificadas

Colecoes/Program.cs conduz o menu; classes OpArrays e OpLista reúnem operações de apoio. Sem banco ou backend HTTP.

Arquivos principais: `Colecoes/Program.cs`, `Colecoes/helper/OpArrays.cs`, `Colecoes/helper/OpLista.cs`.

### Requisitos e execução

SDK .NET compatível com Colecoes/Colecoes.csproj.

```text
dotnet build Colecoes.sln
dotnet run --project Colecoes/Colecoes.csproj
```



### Testes e estado

Não foi identificada uma suíte automatizada específica para os fluxos descritos; valide a execução e os casos de borda antes de publicar.

Estado: projeto de estudo/experimental. Deploy ativo não foi confirmado nesta revisão.

### Limitações conhecidas

- Exercícios interativos sem suíte automatizada.
- Entradas de console exigem valores compatíveis com cada opção.

### Licença e manutenção

Nenhum arquivo de licença foi identificado nesta revisão; não foi adicionada uma nova licença. Atualize comandos e limitações quando houver mudança de comportamento.
