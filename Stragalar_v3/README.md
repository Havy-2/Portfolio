# Stragalar v3

Versão criada seguindo o padrão da pasta **Exemplo** (BibliotecaEscolarForms / LojaCeet).

## Estrutura

```
Stragalar/
├── Modelos/          ← Classes de domínio (Produto, Usuario)
├── Dados/            ← Conexao + DAOs
├── Telas/            ← Formulários (Login, Principal, Início, Produtos, Estoque, Vendas)
├── Properties/
├── Program.cs
└── Stragalar.csproj
```

## Características

- Formulários **encaixados** no painel do FormPrincipal (padrão da BibliotecaEscolar)
- Separação clara: Modelos / Dados / Telas
- Menu lateral com navegação
- Login funcional + cadastro básico de produtos

## Como usar

1. Abra `Stragalar.sln`
2. Instale o pacote **MySql.Data** (NuGet)
3. Execute o script `../Banco_Dados/Stragalar_Oficial.sql`
4. Ajuste a conexão em `Dados/Conexao.cs` se necessário

Usuários de teste: `admin` / `admin123`
