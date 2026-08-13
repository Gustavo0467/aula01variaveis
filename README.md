# aula01variaveis

 ##teste de edição

## 👤 Informações do Aluno / Cabeçalho

* **Nome do Aluno(a):** Gustavo Silva de Souza
* **Matéria / Disciplina:** DSII
* **Data:** [ 12/08/2026 ]
* **Professor(a):** [ Luiz ]

---

## 📖 Manual Prático de Formatação em Markdown (`.md`)

Este arquivo é um guia/manual simplificado e interativo de como utilizar a linguagem de marcação **Markdown** para documentar seus projetos no GitHub e outras plataformas.

---

### 1. Títulos e Cabeçalhos (Headings)

Para criar títulos, utiliza-se o caractere `#` no início da linha:

# Título H1 (Maior)
## Título H2
### Título H3
#### Título H4
##### Título H5
###### Título H6

---

### 2. Estilização de Texto

| Formatação | Sintaxe Markdown | Resultado |
| :--- | :--- | :--- |
| **Negrito** | `**texto**` ou `__texto__` | **texto em negrito** |
| *Itálico* | `*texto*` ou `_texto_` | *texto em itálico* |
| **_Negrito + Itálico_** | `***texto***` | ***texto em negrito e itálico*** |
| ~~Riscado / Tachado~~ | `~~texto~~` | ~~texto riscado~~ |
| Highlight / Marcado | `<mark>texto</mark>` | <mark>texto destacado</mark> |

---

### 3. Listas

#### Listas Não Ordenadas (Marcadores):
- Item 1
* Item 2
  - Subitem 2.1

#### Listas Ordenadas (Numeradas):
1. Primeiro passo
2. Segundo passo
3. Terceiro passo

#### Listas de Tarefas (Checklists):
- [x] Variáveis declaradas
- [x] Tipos de dados entendidos
- [ ] Exercícios concluídos

---

### 4. Blocos de Código (Syntax Highlighting)

Para exibir códigos com realce de sintaxe, utilize três crases (\`\`\`) indicando a linguagem:

#### Exemplo em Python (Variáveis):
```python
# Declaração de variáveis no projeto Aula01Variaveis
nome_usuario = "Maria"   # String
idade = 20               # Integer
altura = 1.68            # Float
ativo = True             # Boolean

print(f"Olá {nome_usuario}, você tem {idade} anos.")