# PokeRegistro :book::snake:

## Descrição

Aplicativo simples para criação, alteração, remoção e consulta de pokémons para ser rodado pelo console/terminal. Esse programa leva em consideração que cada pokémon tem apenas um tipo e pertence a apenas uma região. O objetivo desse projeto foi o de se entender melhor o conceito de se estruturar um aplicativo em diferentes camadas. Tudo aqui foi feito utilizando **C#** e **.NET**;

## Exemplo

* As entradas de dados estão indicadas por **#** ao lado direito;

Ao se iniciar o programa, que é feito ao se executar o comando ***dotnet run*** no diretório do progama, o seguinte menu irá aparecer:

```bash
PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair
```

Agora serão inseridos e listados 2 registros de pokémons:

```bash
2#

Inserir novo PokeRegistro
Digite o nome do Pokémon: 
Pikachu#
Opções de Tipos:
1 - INSETO
2 - NOTURNO
3 - VOADOR
4 - ELETRICO
5 - FADA
6 - LUTADOR
7 - FOGO
8 - FANTASMA
9 - GRAMA
10 - NORMAL
11 - VENENOSO
12 - PEDRA
13 - TERRESTRE
14 - AÇO
15 - AGUA
16 - PSIQUICO
17 - GELO
18 - DRAGAO
Digite o tipo do Pokémon entre as opções acima: 
4#
Opções de Regiões:
1 - KANTO
2 - JOHTO
3 - HOENN
4 - SINNOH
5 - UNOVA
6 - KALOS
7 - ALOLA
8 - GALAR
Digite a região do Pokémon entre as opções acima: 
1#
Digite a descrição sobre o Pokémon: 
Rato elétrico e amarelo. #
Pokemon Pikachu Adicionado! 

PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

2#

Inserir novo PokeRegistro
Digite o nome do Pokémon: 
Raichu#
Opções de Tipos:
1 - INSETO
2 - NOTURNO
3 - VOADOR
4 - ELETRICO
5 - FADA
6 - LUTADOR
7 - FOGO
8 - FANTASMA
9 - GRAMA
10 - NORMAL
11 - VENENOSO
12 - PEDRA
13 - TERRESTRE
14 - AÇO
15 - AGUA
16 - PSIQUICO
17 - GELO
18 - DRAGAO
Digite o tipo do Pokémon entre as opções acima: 
4#
Opções de Regiões:
1 - KANTO
2 - JOHTO
3 - HOENN
4 - SINNOH
5 - UNOVA
6 - KALOS
7 - ALOLA
8 - GALAR
Digite a região do Pokémon entre as opções acima: 
1 #
Digite a descrição sobre o Pokémon: 
Evolução do Pikachu, assim também é um rato amarelo e elétrico.
Pokemon Raichu Adicionado! #

PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

1 #

Listar PokeRegistros
#ID 0: - Pikachu
#ID 1: - Raichu

```

Agora o pokémon de **ID 0**, Pikachu, será alterado para outro pokémon e os registros novamente serão listados:

```bash
PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

3 #

Atualizar PokeRegistro
Digite o id da série: 
0 #
Digite o nome do Pokémon: 
Charmander #
Opções de Tipos:
1 - INSETO
2 - NOTURNO
3 - VOADOR
4 - ELETRICO
5 - FADA
6 - LUTADOR
7 - FOGO
8 - FANTASMA
9 - GRAMA
10 - NORMAL
11 - VENENOSO
12 - PEDRA
13 - TERRESTRE
14 - AÇO
15 - AGUA
16 - PSIQUICO
17 - GELO
18 - DRAGAO
Digite o tipo do Pokémon entre as opções acima: 
7 #
Opções de Regiões:
1 - KANTO
2 - JOHTO
3 - HOENN
4 - SINNOH
5 - UNOVA
6 - KALOS
7 - ALOLA
8 - GALAR
Digite a região do Pokémon entre as opções acima: 
1 #
Digite a descrição sobre o Pokémon: 
Dragão com foguinho na cauda. Se o foguinho se apagar, ele morre ): ):! #
Pokemon Charmander atualizado! 

PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

1 #

Listar PokeRegistros
#ID 0: - Charmander
#ID 1: - Raichu
```

Agora será visualizado o registro do pokémon de **ID 1**, o Raichu:

```bash
PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

5 #

Visualizar PokeRegistro
Digite o id da série: 
1 #
Nome: Raichu
Tipo: ELETRICO
Regiao: KANTO
Descrição: Evolução do Pikachu, assim também é um rato amarelo e elétrico.

```

Agora irá se deletar o pokémon de **ID 1**, então serão listados os registros dos pokémons novamente e por fim o programa será finalizado:

```bash
PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

4 #

Excluir PokeRegistro
Digite o id da série: 
1 #
Pokemon Raichu Excluido! 

PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

1 # 

Listar PokeRegistros
#ID 0: - Charmander

PokeRegistration, não acredito que não é uma PokeDex!!!
Informe a opção desejada:
1 - Listar Pokémons Registrados
2 - Inserir novo PokeRegistro
3 - Atualizar PokeRegistro
4 - Excluir PokeRegistro
5 - Visualizar PokeRegristro
C - Limpar Tela
X - Sair

x #

Volte sempre!
Temos que pegar!

```

