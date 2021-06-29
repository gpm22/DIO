# PokeBank :money_mouth_face::money_mouth_face::money_mouth_face::money_mouth_face::money_mouth_face:

## Descrição

Programa simples de transferência bancária para treinadores pokémon para ser rodado pelo console/terminal, onde é possível criar uma PokeConta bancária dos tipos física ou jurídica, listar todas as PokeContas, realizar depósitos, transferências e saques. Esse programa foi feito com o objetivo de se entender melhor os conceitos do paradigma de orientação a objetos com a linguagem **C#** e o framework **.NET**.

## Exemplo

* As entradas de dados estão indicadas por **#** ao lado direito;

Ao se iniciar o programa, que é feito ao se executar o comando ***dotnet run*** no diretório do programa, o seguinte menu irá aparecer:

```bash
Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair
```

Agora serão criadas 2 contas:

```bash
2 #

Inserir nova PokeConta
Digite 1 para PokeConta Física ou 2 para PokeConta Jurídica: 
1 #
Digite o Nome do Treinador
Red #
Digite o saldo inicial: 
1000 #
Digite o cŕedito:  
500 #

Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair

2 #

Inserir nova PokeConta
Digite 1 para PokeConta Física ou 2 para PokeConta Jurídica: 
2 #
Digite o Nome do Treinador
PokeCenter Vila Nova#
Digite o saldo inicial: 
10000 #
Digite o cŕedito: 
3591 #

```

Agora serão listadas as contas criadas:

```bash
Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair

1 #

Listar PokeContas
#0--- Tipo da conta: PessoaFisica
  --- Nome do Cliente: Red
  --- Saldo: 1000
  --- Crédtio: 500

#1--- Tipo da conta: PessoaJuridica
  --- Nome do Cliente: PokeCenter Vila Nova
  --- Saldo: 10000
  --- Crédtio: 3591

```

Agora será feito o depósito para a conta **\#0**, do treinador Red:

```bash
Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair

5 #

Digite o número da PokeConta: 
0 #
Digite o valor a ser depositado: 
12091 #
Saldo atual da conta de Red é 13091
```

Agora será feito o saque para conta **#1**, do PokeCenter Vila Nova:

```bash
4 #

Digite o número da PokeConta: 
1 #
Digite o valor a ser sacado: 
21937 #
Saldo insuficiente!

Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair

4 #

Digite o número da PokeConta: 
1 #
Digite o valor a ser sacado: 
5000 #
Saldo atual da conta de PokeCenter Vila Nova é 5000

Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair

4

Digite o número da PokeConta: 
1 #
Digite o valor a ser sacado: 
6000 #
Saldo atual da conta de PokeCenter Vila Nova é -1000 #Está usando o crédito

```

 Agora será feita uma transferência da conta **#0** para **#1** e o programa será finalizado:

```bash
3 #

Digite o número da PokeConta de origem: 
0 #
Digite o número da PokeConta de destino: 
1 #
Digite o valor a ser transferido: 
7787  #
Saldo atual da conta de Red é 5304
Saldo atual da conta de PokeCenter Vila Nova é 6787

Pikachu's Bank, um banco para treinadores pokémon.
Informe a opção desejada:
1 - Listar PokeContas
2 - Inserir nova PokeConta
3 - Transferir
4 - Sacar
5 - Depositar
C - Limpar Tela
X - Sair

x #

Obrigado por utilizar nossos PokeServiços!
Pika pi!
```

