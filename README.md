# 📚 Estruturas de Dados e Algoritmos em C#

Este repositório é uma coleção de algoritmos clássicos e implementações de estruturas de dados desenvolvidos em **C#**, com foco em **boas práticas de programação**, princípios de **Clean Code**, **Test-Driven Development (TDD)** e utilização de **recursos modernos da linguagem**.

## ✅ Objetivos

- Consolidar conhecimentos da disciplina de Estruturas de Dados e Algoritmos.
- Aplicar boas práticas de design e organização de código.
- Utilizar o C# de forma moderna e idiomática.
- Desenvolver testes automatizados desde o início com TDD.
- Servir como referência e material de estudo para outros estudantes e profissionais.

## 📌 Conteúdo atual

Atualmente, o repositório contém implementações de **algoritmos de ordenação**, incluindo:

- Bubble Sort
- Insertion Sort
- Selection Sort
- Merge Sort (in-place e não in-place)
- Quick Sort (com particionamento de Hoare e Lomuto)
- Counting Sort
- Radix Sort
- Cocktail Sort
- Comb Sort (em breve)
- Heap Sort

Tipos Abstratos de Dados

- Stack
- Queue

Árvores Binárias

- Árvore Binária de Busca (ABB/BST)
- Heap Binária

Cada algoritmo está devidamente estruturado com:

- Métodos bem nomeados e responsabilidades únicas.
- Comentários e documentação no estilo XML para facilitar a leitura e integração.
- Separação clara entre lógica e testes.
- Utilização de interfaces e abstrações sempre que aplicável.

## 🧪 Testes

Os testes são escritos utilizando o framework **xUnit**, seguindo o modelo de **Test-Driven Development (TDD)**. Cada algoritmo possui uma suíte de testes cobrindo cenários normais, limites e casos extremos.

```bash
dotnet test
```

## 💡 Boas práticas adotadas

- 🧼 **Clean Code**: código legível, conciso e expressivo.
- 🧪 **TDD**: testes primeiro, implementação depois.
- 🧩 **SOLID**: princípios de design orientado a objetos.
- ♻️ **Reutilização de código** com uso de interfaces e abstrações.
- 🚀 **C# moderno**: uso de `Span<T>`, `records`, `pattern matching`, interpolação de strings, entre outros recursos da versão mais recente da linguagem.

## 📂 Organização do Projeto

```
/src
  └── Sorting         # Algoritmos de ordenação
/tests
  └── SortingTests    # Testes unitários com xUnit
```

## 🔮 Futuro

Este repositório será expandido com a implementação de:

- Pilhas e Filas (Stacks & Queues)
- Listas Ligadas (Linked Lists)
- Árvores Binárias e Balanceadas
- Grafos e Algoritmos de Caminho Mínimo
- Algoritmos de busca (DFS, BFS, etc.)
- Hash Tables
- Programação Dinâmica
- e muito mais...

## 🤝 Contribuições

Este repositório está em desenvolvimento pessoal, mas contribuições são bem-vindas! Fique à vontade para abrir **issues**, sugerir melhorias ou enviar **pull requests**.

## 📘 Requisitos

- [.NET 6 ou superior](https://dotnet.microsoft.com/)
- Editor recomendado: [Visual Studio](https://visualstudio.microsoft.com/) ou [Rider](https://www.jetbrains.com/rider/) / [VS Code](https://code.visualstudio.com/) com extensão C#

## 📄 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

---

**Desenvolvido com dedicação e foco em qualidade.**
