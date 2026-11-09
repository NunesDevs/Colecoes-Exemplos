# Memória do projeto

Revisão: 2026-11-01. Ler este arquivo e `docs/ai-context/QUALITY_REVIEW_2026-11-01.md` antes de retomar alterações.

## Objetivo e estado

Exemplos interativos de arrays, matrizes, ordenação, listas, filas, pilhas, dicionários e LINQ.

Mudanças funcionais desta revisão:
- Leitura de inteiros com nova tentativa após texto inválido e saída por EOF.
- Busca exibe o valor encontrado.
- Submenus de dicionário e consulta aceitam zero para voltar.
- Falhas esperadas de entrada ou chave ausente retornam ao menu com mensagem.
- .NET 10 LTS e testes de ordenação, arrays vazios, cópia independente e busca.

## Decisões

- Preservar o propósito didático e o histórico anterior do Git.
- Manter esta revisão na branch `codex/quality-refresh` até integração coordenada.
- Preservar arquivos locais e avisos de terceiros; não versionar resultados de build, credenciais ou dados reais.
- Artefatos de console são distribuíveis locais. Um build ou pacote não comprova publicação em produção.
- .NET 10 LTS foi escolhido porque .NET 3.1 e 6 estavam sem suporte e .NET 8 encerra suporte em 2026-11-10. Referência: https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core .

## Validação reproduzível

SDK .NET 10. Para ver os exemplos, use os nomes exibidos no menu, como `Array`, `Ordenar`, `Fila` e `Sair`.

```powershell
./build.ps1 -Test -Package
dotnet run --project Colecoes/Colecoes.csproj
```

## Limitações para continuidade

Os exemplos operam em memória; voltar ao menu reinicia os dados do exemplo. As opções textuais preservam a grafia indicada no menu. Não há armazenamento persistente.

Os documentos automáticos de maio em `docs/ai-context` são um registro histórico, incluindo falsos positivos por palavras como “secret”. Esta memória e a revisão de qualidade descrevem o estado posterior às correções.

Pacotes Release omitem símbolos de depuração e mapeiam caminhos de origem em `Directory.Build.props`, para não distribuir caminhos locais. Para depurar, use a configuração Debug.

## Evidência da revisão

Build .NET 10, testes de ordenação/cópia/busca e publish win-x64 aprovados. Pacote executado com entrada numérica inválida seguida de busca válida e EOF.

## CI — 2026-11-08

O workflow `.github/workflows/ci.yml` valida a stack e os testes reais deste projeto em push/PR para `master` e por disparo manual. Usa ações oficiais fixadas por SHA, permissão `contents: read` e checkout sem credenciais persistentes. Não faz deploy nem publica pacotes.

A release `v2026.11.8` e seus binários continuam associados ao código `a220f51e6b93729fa7338d8c8ed760f79e646089`. O commit de workflow/documentação é posterior e não muda os artefatos já compilados. Resultado da execução remota disponível na aba Actions; não confundir configuração do workflow com aprovação de uma execução.
