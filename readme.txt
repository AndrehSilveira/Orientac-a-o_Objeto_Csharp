Após criar uma pasta, no terminal digitar "dotnet new console" para que tudo seja exibido no terminal
    as alternativas são Web e Forms (pesquisar depois)

"dotnet run" executa

Executar no localhost é dotnet run --urls "http://localhost:8080"

- atributo public deixa todas as classes enxergarem
- atributo private não permite nenhuma outra classe enxergarem
- atributo protected somente a mesma classe e as herdadas podem enxergar

- Encapsulamento: Quando através de um método eu acesso atributos de privados
- Construtor: Quando cria-se métodos com o mesmo nome da classe com ou sem parâmetros
- get e set: Atributos que podem ser enviados (set) ou recebidos (get) pela classe
- this: traz o valor do atributo de dentro da classe
- Herança: Quando eu crio duas classes, sendo que a segunda poderá trazer os métodos e atributos da primeria
- Polimorfismo: Quando eu herdo classes com métodos virtuais e faço alteração desses métodos com override
- Método Estático: Quando eu acesso o método da classe sem precisar instanciar um objeto;
- Classe e Método Abstrato: Obrigatório chamar um método abstrato dentro de uma classe abstrata, o qual 
    posso sobreescrever (override) para fazer alterações das regras de negócio;
- Interface: implementação de classes que serão naturalmente abstratas para que sejam obrigatóriamente
    usadas como herança de outras classes; 
    Uma interface pode ser herdada multiplas vezes
    Não é possível trabalhar com regras dentro dos métodos. Métodos devem ser instanciados apenas.

MVC:
os dados chegam no controller, 
o controller manda pra camada de serviço que tem a lógica de negócio, 
e a camada de serviço fala com a camada de dados que consulta no banco

Controllers - estrutura do backend

Serviço - Regra de negócio, comunicando diretamente com Controller

Models - Classe para acessar o banco de dados com as colunas da tabela

Views - Interface, códigos frontend