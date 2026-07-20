# 📘 Nível 2 — Estruturas Condicionais

Este nível introduz a capacidade de tomada de decisão nos algoritmos. Os programas deixam de ser puramente lineares e passam a executar blocos de código diferentes dependendo de condições específicas.

O foco está no uso correto de operadores lógicos, estruturas de desvio condicional (`if`, `else if`, `else`) e estruturas de escolha múltipla (`switch`).

---

## 🎯 Objetivos

Ao concluir este nível, espera-se que o estudante seja capaz de:
- Utilizar estruturas condicionais simples e compostas (`if` e `else`).
- Criar menus e validações elegantes utilizando o comando `switch`.
- Aplicar operadores lógicos (`&&` para E, `||` para OU, `!` para NÃO) em expressões complexas.
- Validar dados de entrada antes de realizar processamentos.
- Compreender conceitos matemáticos e geométricos básicos (módulos, ordenação e existência de triângulos) aplicados ao código.

---

## 📚 Conteúdos abordados

- Estruturas de decisão (`if`, `else if`, `else`)
- Seleção múltipla (`switch` / `case`)
- Operadores de igualdade e relacionais
- Operadores lógicos (`&&`, `||`, `!`)
- Lógica de inversão de valores (Swapping)
- Validação e consistência de dados

---

## 📝 Exercícios

### Exercício 11 — Troca de Valores (Inversão)
Ler dois valores inteiros para as variáveis `A` e `B`. Efetue a troca dos valores de modo que a variável `A` passe a possuir o valor da variável `B`, e a variável `B` passe a possuir o valor da variável `A`. Apresente os valores trocados.

### Exercício 12 — Módulo de um Número
Escreva um programa que leia um número inteiro e exiba o seu módulo (valor absoluto).
O módulo de um número $x$ é:
- $x$ se $x$ é maior ou igual a zero
- $x \times (-1)$ se $x$ é menor que zero

### Exercício 13 — Ordem Decrescente
Escreva um programa que leia 3 números inteiros e imprima na tela os valores ordenados em ordem decrescente (do maior para o menor).

### Exercício 14 — Diferença entre Maior e Menor
Escreva um programa que leia dois números e apresente a diferença (subtração) do maior para o menor.

### Exercício 15 — Média Escolar com Recuperação
Escreva um programa que leia quatro notas escolares de um aluno e apresente uma mensagem informando que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. 
Se a média for menor que 7, solicite a nota de recuperação, some com o valor da média e obtenha a nova média:
- Se a nova média for maior ou igual a 7, apresente a mensagem: "Aprovado na recuperação".
- Se o aluno não atingir a nota, apresente: "Reprovado".
- Apresente junto com as mensagens o valor da média final do aluno.

### Exercício 16 — Maior, Menor ou Iguais
Escreva um programa que leia dois números e exiba uma mensagem informando o valor do maior número e o valor do menor número. Se os dois números forem iguais, o programa deve exibir uma mensagem informando este fato.

### Exercício 17 — Validação de Faixa Numérica
Escreva um programa que leia um número inteiro. Verifique por meio de uma condição se o valor fornecido está na faixa entre 0 (zero) e 9 (nove) inclusive. 
- Caso esteja dentro da faixa, apresentar a mensagem: "Valor válido".
- Caso contrário, apresentar a mensagem: "Valor inválido".

### Exercício 18 — Código por Extenso (Switch Case)
Escreva um programa que leia um número inteiro (variável `CODIGO`). Verifique se o código é igual a 1, 2 ou 3. Caso não seja, apresente a mensagem "Código inválido". 
Ao constatar que é um valor válido, o programa deve determinar seu valor por extenso, apresentando a mensagem "Um", "Dois" ou "Três". *(Obrigatório utilizar o comando Switch)*.

### Exercício 19 — Validação de Triângulos
Escreva um programa que leia três valores para os lados de um triângulo (variáveis `A`, `B` e `C`). O programa deve verificar primeiro se os lados formam um triângulo válido (cada lado deve ser menor que a soma dos outros dos dois). Se for válido, classifique-o:
- **Equilátero:** Se `A == B` e `B == C`.
- **Isósceles:** Se `A == B` ou `A == C` ou `B == C`.
- **Escaleno:** Se todos os lados forem diferentes.
- Caso os lados não caracterizem um triângulo, exiba uma mensagem de alerta.

### Exercício 20 — Operações com Maior e Menor (Validação com Loop)
Escrever um programa declarando três variáveis do tipo inteiro (`a`, `b` e `c`). Ler um valor maior que zero para cada variável (se o valor digitado for menor ou igual a zero, mostrar uma mensagem de erro e ler o valor novamente). Ao final, exiba:
- O menor valor lido multiplicado pelo maior valor lido.
- O maior valor lido dividido pelo menor valor lido.

### Exercício 21 — Positivo ou Negativo com Parada
Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é positivo ou negativo. O programa deve continuar executando e pedindo novos números até que o usuário marque que deseja parar.

### Exercício 22 — Separador de Positivos e Negativos
Faça um programa que leia um número. Se ele for positivo, armazene-o em uma variável `A`. Se for negativo, armazene-o em uma variável `B`. No final do programa, mostre o resultado das variáveis.