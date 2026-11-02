# Coleções e algoritmos em C#

Exemplos interativos de arrays, matrizes, ordenação, listas, filas, pilhas, dicionários e LINQ.

## Comportamento

- Leitura de inteiros com nova tentativa após texto inválido e saída por EOF.
- Busca exibe o valor encontrado.
- Submenus de dicionário e consulta aceitam zero para voltar.
- Falhas esperadas de entrada ou chave ausente retornam ao menu com mensagem.
- .NET 10 LTS e testes de ordenação, arrays vazios, cópia independente e busca.

## Executar e validar

SDK .NET 10. Para ver os exemplos, use os nomes exibidos no menu, como `Array`, `Ordenar`, `Fila` e `Sair`.

```powershell
./build.ps1 -Test -Package
dotnet run --project Colecoes/Colecoes.csproj
```

## Limites

Os exemplos operam em memória; voltar ao menu reinicia os dados do exemplo. As opções textuais preservam a grafia indicada no menu. Não há armazenamento persistente.

## Manutenção e licença

Código autoral licenciado sob a [MIT](LICENSE). Dependências, ferramentas e materiais de terceiros mantêm suas próprias licenças e avisos.

Decisões e continuidade: [PROJECT_MEMORY.md](PROJECT_MEMORY.md).
