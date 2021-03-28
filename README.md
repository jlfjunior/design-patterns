# **Patterns**
É um repositório para estudo de **Padrões de Projetos**. Baseado nos 23 padrões catalogados pela *Gang of Four* (GoF), irei apresentar os padrões *Comportamenstais, Estruturais e de Criação* utilizando a linguagem C#.

**Creational Patterns**
- [x] [Factory Method](https://github.com/jlfjunior/patterns#factorymethod)
- [ ] Builder
- [ ] Prototype
- [ ] Abstract Factory
- [ ] Singleton

**Structural Patterns**
- [ ] Adapter
- [ ] Decorator
- [ ] Composite
- [x] [Bridge](https://github.com/jlfjunior/patterns#bridge)
- [ ] Facade
- [ ] Proxy
- [ ] Flyweight

**Behavioral Patterns**
- [x] [Template Method](https://github.com/jlfjunior/patterns#templatemethod)
- [x] [Strategy](https://github.com/jlfjunior/patterns#strategy)
- [ ] Observer
- [ ] Command
- [ ] Mediator
- [ ] Iterator
- [ ] Chain of Responsibility
- [ ] Memento
- [ ] State
- [ ] Visitor

### Strategy
O *Strategy* é um padrão que pode ser utilizado quando uma classe principal possuir diversos algoritmos que podem ser alterados para contemplar um comportamento específico.

    Pontos Positivos
    - Alterar o algoritmo sem alterar a classe principal.
    - Redução de lógicas complexas dentro da classe principal.
    - A implementação pode ser alterada em tempo de execução.
    - Fortalece Open/Closed Principle presente no S.O.L.I.D. Você pode implementar novas estrategia sem alterar a classe principal

    Pontos Negativos
    - Aumento da complexidade da criação de objetos.
    - Aumento do número de classes para a solução.

### TemplateMethod
O *Template Method* define um modelo/esqueleto para uma classe base, deixando que suas sub classes implementem partes do seu algoritmo ou reescrevam determinadas etapas do seu algoritmo sem alterar o modelo/esqueleto pré definido.

    Pontos Positivos
    - Permite que os clientes subscrevam partes do algoritmo, incluindo/removendo regras.
    - Concentração do código comum na superclasse. 

    Pontos Negativos
    - Usa herança, ferindo o Liskov Substitution Principle (LSP) presente no S.O.L.I.D

### FactoryMethod
O *Factory Method* é um padrão que consiste em definir uma interface para criar objetos em um superclasse, porém esse padrão permite que as subclasses alterem o tipo do objeto quando necessário.

    Pontos Positivos
    - Evita acoplamento forte dentro do sistema.
    - Princípio de responsabilidade única. Você concentra o código de criação de objetos em um único método.
    - Princípio aberto/fechado. Você pode introduzir novos tipos do mesmo objeto no programa sem quebrar o código cliente existente.

    Pontos Negativos
    - Aumento do número de subclasses para a solução.

### Bridge
O *Bridge* é um padrão que permite que você faça uma ponte entre dois conjuntos de classes intimamente ligados através da composição de uma interface comum. Dessa forma você pode desenvolver cada extremidade independentemente sem afetar a ligação entre elas.
    
    Pontos Positivos
    - Você cria classes e abstrações independentes.
    - O código cliente trabalha com abstrações de alto nível sem se preocupar com detalhes da plataforma.
    - Princípio de responsabilidade única. Foco na lógica de alto nível na abstração e detalhes específicos na implementação.
    
    Pontos Negativos
    - Você torna o código mais complexo de entender ao aplicar o padrão em uma classe altamente coesa.

# Reference
 - [DoFactory](https://www.dofactory.com/net/design-patterns)
 - [Factoring.Guru](https://refactoring.guru/design-patterns)