# Revisão de qualidade — 2026-11-01

Exemplos interativos de arrays, matrizes, ordenação, listas, filas, pilhas, dicionários e LINQ.

## Escopo

Leitura de fontes, documentação, configurações e scripts do projeto, excluindo dependências, metadados Git e saídas geradas. Sem alteração visual; mudanças de interface gráfica exigem Figma.

## Correções e decisões

- Leitura de inteiros com nova tentativa após texto inválido e saída por EOF.
- Busca exibe o valor encontrado.
- Submenus de dicionário e consulta aceitam zero para voltar.
- Falhas esperadas de entrada ou chave ausente retornam ao menu com mensagem.
- .NET 10 LTS e testes de ordenação, arrays vazios, cópia independente e busca.

## Como validar

SDK .NET 10. Para ver os exemplos, use os nomes exibidos no menu, como `Array`, `Ordenar`, `Fila` e `Sair`.

```powershell
./build.ps1 -Test -Package
dotnet run --project Colecoes/Colecoes.csproj
```

## Limites reais

Os exemplos operam em memória; voltar ao menu reinicia os dados do exemplo. As opções textuais preservam a grafia indicada no menu. Não há armazenamento persistente.

Confira `PROJECT_MEMORY.md` para continuidade. Os resultados executados estão registrados abaixo.

## Resultado executado

Build .NET 10, testes de ordenação/cópia/busca e publish win-x64 aprovados. Pacote executado com entrada numérica inválida seguida de busca válida e EOF.

Publicação em produção não foi realizada. Pacotes foram preparados e a publicação da branch será registrada na auditoria local; integração e distribuição são coordenadas separadamente.
