# Atividades C#

## 🧠 **Atividade 1 – Sistema de Veículos**

🎯 **Objetivo:**

Compreender como diferentes tipos de veículos podem compartilhar atributos e comportamentos, usando **herança e abstração**.

🚗 **Contexto:**

Uma oficina precisa calcular o custo de revisão de veículos. Cada tipo tem um cálculo diferente.

🏗️ **Classes sugeridas:**

1. **Classe abstrata `Veiculo`**
    - Atributos: `Modelo`, `Ano`.
    - Método abstrato: `CalcularRevisao()`.
    - Método comum: `ExibirResumo()`.
2. **Classe `Carro` (herda de Veiculo)**
    - Retorna custo fixo de revisão = R$ 500.
3. **Classe `Moto` (herda de Veiculo)**
    - Retorna custo fixo de revisão = R$ 300.
4. **No `Program`**, crie um carro e uma moto, e exiba o resumo de cada um.

---

## 💻 **Atividade 2 – Sistema de Funcionários**

🎯 **Objetivo:**

Aplicar herança e sobrescrita de métodos com foco em diferentes funções de trabalho.

🏢 **Contexto:**

Uma empresa quer calcular o salário de seus funcionários de acordo com o tipo de cargo.

🏗️ **Classes sugeridas:**

1. **Classe abstrata `Funcionario`**
    - Atributos: `Nome`, `SalarioBase`.
    - Método abstrato: `CalcularSalario()`.
    - Método comum: `ExibirResumo()`.
2. **Classe `Gerente` (herda de Funcionario)**
    - Ganha 50% de bônus sobre o salário base.
3. **Classe `Vendedor` (herda de Funcionario)**
    - Ganha 20% de bônus sobre o salário base.
4. **No `Program`**, crie um gerente e um vendedor e exiba o resumo de cada um.

---

## 🎮 **Atividade 3 – Sistema de Personagens de Jogo**

🎯 **Objetivo:**

Treinar a ideia de polimorfismo e herança com um tema mais divertido.

⚔️ **Contexto:**

Um jogo precisa calcular o poder total de ataque dos personagens.

🏗️ **Classes sugeridas:**

1. **Classe abstrata `Personagem`**
    - Atributos: `Nome`, `Nivel`.
    - Método abstrato: `CalcularPoder()`.
    - Método comum: `ExibirStatus()`.
2. **Classe `Guerreiro` (herda de Personagem)**
    - Poder = `Nivel * 10`.
3. **Classe `Mago` (herda de Personagem)**
    - Poder = `Nivel * 8 + 20`.
4. **No `Program`**, crie um guerreiro e um mago e mostre o status de cada um.

---

## 🐾 **Atividade 4 – Sistema de Animais**

🎯 **Objetivo:**

Treinar a criação de hierarquias simples com abstração.

🌿 **Contexto:**

Um zoológico quer registrar o som e o tipo de alimentação de alguns animais.

🏗️ **Classes sugeridas:**

1. **Classe abstrata `Animal`**
    - Atributo: `Nome`.
    - Métodos abstratos: `EmitirSom()` e `TipoAlimentacao()`.
2. **Classe `Leao` (herda de Animal)**
    - Som: "Rugido"
    - Alimentação: "Carnívoro"
3. **Classe `Elefante` (herda de Animal)**
    - Som: "Barrito"
    - Alimentação: "Herbívoro"
4. **No `Program`**, crie um leão e um elefante e chame os métodos.

---

## 📚 **Atividade 5 – Sistema de Cursos**

🎯 **Objetivo:**

Praticar herança com valores diferentes e uso de métodos abstratos.

🏫 **Contexto:**

Uma escola oferece diferentes tipos de cursos, e cada um tem um valor diferente por hora.

🏗️ **Classes sugeridas:**

1. **Classe abstrata `Curso`**
    - Atributos: `Nome`, `Horas`.
    - Método abstrato: `CalcularPreco()`.
    - Método comum: `ExibirResumo()`.
2. **Classe `CursoTecnico` (herda de Curso)**
    - Valor = `Horas * 20`.
3. **Classe `CursoSuperior` (herda de Curso)**
    - Valor = `Horas * 40`.
4. **No `Program`**, crie um curso técnico e um superior e exiba o resumo.