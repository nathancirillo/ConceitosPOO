namespace Payments
{
    class Program
    {
        static void Main(string[]args)
        {
            // Um objeto sempre será composto por: propriedades, métodos e eventos; 
            // Propriedades: características que um objeto possui; 
            // Métodos: ações que um objeto pode executar (função);
            // Um objeto sempre será do tipo de referência (armazena endereço de memória);
            // Tipo de valor fica na memória Stack e Tipo de referência na Heap; 
            // A difereça entre class e struct é a forma que são armazenados; 
            // Class é um tipo por referência e Struct por valor; 
            // Uma classe pode ser entendida como um molde para criar novos objetos;
            // A ideia por de trás da POO é dividir a aplicação em pedaços (quebrar em pequenos objetos);
            // Ao pegar as informações que um pagamento pode ter e trazer para dentro de uma classe é o conceito de encapsulamento; 
            // 1º Paradigma da POO -> Encapsulamento: agrupar o que faz sentido estar junto. 
            // 2º Paradigma da POO -> Abstração: esconder os detalhes, ou seja, o que não é necessário saber sobre o objeto.
            // No caso da abstração pense em um interruptor ao acender a lâmpada ou em um carro ao acelerar; 
            // Para isso usamos modificadores de acesso.
            // private: evita que classes de fora façam uso e veja o membro da classe;
            // public: permite que classes de fora façam uso e veja o membro da classe; 
            // 3º Paradigma da POO -> Herança: permite herdar propriedade, métodos e eventos de outro objeto; 
            // Exemplo: existem vários tipos de pagamento então criamos uma classe mais genérica e outra mais específica; 
            // A classe genérica passa a ter o que ambos tem em comum e a específica só as especificidades; 
            // Uma coisa que não é possível na linguagem C# é herança múltipla;
            // 4º Paradigma da POO -> Polimorfismo: várias formas de realizar uma mesma tarefa;
            // Exemplo: a forma de pagar é diferente para cada tipo de pagamento, então o método pode ser sobrescrito; 
            // Toda classe pode executar um override no método ToString;  
            // Outro conceito importante são os modificadores de acesso para classes, propriedades e métodos; 
            // Os modificadores existentes são: private, protected, internal e public
            // private -> visível somente de dentro da própria classe (preso ao escopo da classe); 
            // protected -> torna os membros vísiveis para os filhos de nossa classe (escopo da classe + classe filhas); 
            // internal (padrão) -> disponível dentro do namespace (assembly); 
            // public -> visível em qualquer lugar podendo ser alterada por qualquer pessoa de fora;
            // Uma classe ou struct são tipos complexos. Um exemplo é o DataTime (struct); 
            // Evite usar somente tipos primitivos. Classes com propriedades com somente tipos primitivos; 
            // Atalhos para gerar propriedades: prop, propfull e propg (set privado);
            // Uma propriedade possui acessores (get e set) que dão a opção de interagir com o valor antes de ser atribuido ou lido. 
            // Dica do balta: se precisar manipular o valor antes da leitura/escrita usar propfull; 
            // Caso não seja necessária essa manipulação e precise de algo mais prático use o prop; 
            // E em casos mais rebuscados o propg (domain driven design, domínios ricos, etc);
            // Sobrecarga de métodos: métodos com nomes iguais na mesma classe, porém assinaturas diferentes (parâmetros e seus tipos);
            // Sobrescrita de métodos: usar virtual em um método da classe pai para que em uma classe filha ele seja sobrescrito (override);
            // Construtor: método especial que possui o mesmo nome da classe e permite iniciar valores na instanciação; 
            // O construtor da classe pai sempre será executado antes do construtor da classe filha;
            // Existe o método destrutor. Para isso a classe precisa implementar a inteface IDisposable; 
            // Uma vez implementada ao invés do objeto chamar o método Dispose() que pode ser esquecido, poderá ser usado o using; 
            // O using já inicia e finaliza o recurso, porém a classe precisa assinar IDisposable;                 
            // A ideia por de trás de uma classe estática é não ser instanciada, pois está disponível na memória na aplicação; 
            // Atenção: classe estática, membros devem ser estáticos e os métodos também;
            // Uma classe estática traz sempre a mesma informação. Exemplo: uma classe de configuração para sua API. As informações são poucas e as mesmas; 
            // Uma classe selada ou sealed classe inibe a possibilidade de herança: public sealed class Payment{}; 
            // Classes parciais: permite separar classes dentro do mesmo namespace, usando o mesmo nome para elas (segmentação); 
            // Usando uma classe parcial consigo dividir uma classe em classes menores; 

            var payment = new Payment();               

        }
    }
    
}