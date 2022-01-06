# Projeto Final

## Instanciar o Elevador

Para instanciar o elevador entre com a capacidade máxima do elevador
e a quantidade total de andares.

O elevador possui quatro métodos: Subir, Descer, Entrar e Sair.

Ao Subir a variável `andar_atual` aumenta um inteiro. Caso o elevador esteja no
último andar e o método Subir seja acionado uma mensagem avisa que o elevador
está no último andar.

Ao Descer a variável `andar_atual` diminui um inteiro. Caso o elevador esteja no
térreo e o método Descer seja acionado uma mensagem avisa que o elevador
está no térreo.

Quando o método Entrar é acionado, um inteiro é adicionado à variável `qtde_passageiros`.
Caso o método Entrar seja acionado com a capacidade máxima, uma mensagem avisa que o elevador
está com capacidade máxima.

Quando o método Sair é acionado, um inteiro é subtraído à variável `qtde_passageiros`.
Caso o método Sair seja acionado com o elevador vazio, uma mensagem avisa que o elevador
está vazio.