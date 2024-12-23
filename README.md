# CodeSmellBloatersBuilderPattern

## Code Smells - Bloaters

Os *code smells* do tipo *bloaters* referem-se a problemas causados pelo crescimento desordenado da estrutura do código, como métodos e classes, o que compromete a manipulação e manutenção do código. Esses problemas geralmente surgem ao longo do tempo, especialmente quando débitos técnicos não são sanados. Os principais exemplos dessa categoria incluem:

- **Long method**: Métodos com muitas linhas de código.
- **Large class**: Classes com muitos campos, métodos e linhas de código.
- **Primitive obsession**: Uso excessivo de tipos primitivos em vez de objetos pequenos.
- **Long parameter list**: Métodos com muitos parâmetros na assinatura.
- **Data clumps**: Agrupamento repetido de variáveis ou atributos em diferentes partes do código.

Esses *code smells* estão relacionados ao crescimento descontrolado do código e tendem a surgir à medida que o sistema evolui, frequentemente como resultado de falta de boas práticas de desenvolvimento ou conhecimento inadequado sobre o software.

## Padrão Builder

O padrão de criação *Builder* é utilizado para simplificar a criação de objetos complexos, onde a construção envolve múltiplas etapas, como inicialização de atributos, construção de objetos dependentes e obtenção de recursos compartilhados. Esse padrão permite a criação de diferentes representações de objetos por meio do mesmo construtor, tornando o processo mais flexível e organizado. Ele viabiliza a criação de objetos complexos de forma progressiva, facilitando a compreensão das etapas envolvidas.

Entre os pontos positivos, destaca-se a flexibilidade na construção de objetos e a possibilidade de reutilizar etapas de criação, permitindo a materialização de diferentes tipos de objetos conforme o contexto. Além disso, o padrão contribui para a coesão das classes, alinhando-se aos princípios de responsabilidade única, ao separar a criação de um objeto de sua funcionalidade.

Porém, o uso do padrão *Builder* pode aumentar a complexidade do projeto e das classes, tornando a implementação mais difícil de gerenciar, especialmente quando as etapas de construção se tornam recursivas ou exigem a criação de tipos concretos diferentes. Apesar disso, o padrão oferece uma abordagem consistente para a criação de objetos complexos.


