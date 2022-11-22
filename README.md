# **Patterns**
É um repositório para estudo de **Padrões de Projetos**. Baseado nos 23 padrões catalogados pela *Gang of Four* (GoF), irei apresentar os padrões *Comportamenstais, Estruturais e de Criação* utilizando a linguagem C#.

**Creational Patterns**
- [x] [Factory Method](https://github.com/jlfjunior/patterns#factorymethod)
- [x] [Builder](https://github.com/jlfjunior/patterns#builder)
- [ ] Prototype
- [ ] Abstract Factory
- [x] [Singleton](https://github.com/jlfjunior/patterns#singleton)

**Structural Patterns**
- [x] [Adapter](https://github.com/jlfjunior/design-patterns#adapter)
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

### Adapter
O *Adapter* pode ser utilizado quando precisamos compatibilizar uma interface não suportada por um serviço em uma que é suportada pelo serviço sem que o mesmo seja alterado.

    Pontos Positivos
    - Preserva o cenceito de Single Responsible Principle (SRP) sugerido pelo S.O.L.I.D
    - Preserva o conceito de Open/Closed principle OCP, pois o serviço consumidor não sofre alteração

    Pontos Negativos
    - Sua base de código aumenta porque é necessario adicionar uma interface e sua implementação para torna as interfaces compativeis com o a que é esperada pelo serviço consumidor.

### Bridge
O *Bridge* é um padrão que permite que você faça uma ponte entre dois conjuntos de classes intimamente ligados através da composição de uma interface comum. Dessa forma você pode desenvolver cada extremidade independentemente sem afetar a ligação entre elas.
    
    Pontos Positivos
    - Você cria classes e abstrações independentes.
    - O código cliente trabalha com abstrações de alto nível sem se preocupar com detalhes da plataforma.
    - Princípio de responsabilidade única. Foco na lógica de alto nível na abstração e detalhes específicos na implementação.
    
    Pontos Negativos
    - Você torna o código mais complexo de entender ao aplicar o padrão em uma classe altamente coesa.

### Singleton
O *Singleton* é um padrão que pode ser utilizado quando o desenvolvedor deseja ter um ponto de acesso único a uma instância de uma classe no projeto.

    Pontos Positivos
    - Um objeto singleton só é instanciado quando for requisitado pela primeira vez.
    - Você ganha um ponto único de acesso a uma instância.
    - O desenvolvedor tem certeza que uma classe tem uma única instância.

    Pontos Negativos
    - O Singleton resolve dois problemas, violando o princípio de responsabilidade única.
    - O Singleton requer tratamento especial em um ambiente multithreaded.
    - Aumento da complexidade de realizar testes unitários.

### Builder
O *Builder* é um padrão muito utilizado quando o desenvolvedor tem a necessidade de dividir em etapas a criação de objetos complexos da sua representação. O padrão ainda permite a construção de diferentes representações de um mesmo objeto.

    Pontos Positivos
    - Princípio de responsabilidade única. O desenvolvedor isola a complexidade de construção do objeto das regras de negócios.
    - Reaproveitamento de código, é possível usar os passos comuns a diferentes objetos.

    Pontos Negativos
    - Aumenta a complexidade de código devido a criação de novas classes.

# Reference
 - [DoFactory](https://www.dofactory.com/net/design-patterns)
 - [Factoring.Guru](https://refactoring.guru/design-patterns)