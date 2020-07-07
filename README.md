# Desafio-C-Fatorial
Desafio C# Soma dos digitos do Fatorial


->No arquivo Program.cs:
  -Class Main: 
    Solicita um numero para calcular o fatorial.
    Cria a instancia de [SomaDigitosFatorial] e chama a função Calcula onde realiza o calculo fatorial e depois a soma dos digitos do fatorial referente ao numero escolhido.

  -Class SomaDigitosFatorial: Primeiro passo é realizado o calculo do fatorial, o calculo será guardado na variavel. No Segundo Passo é convertido o resultado do fatorial em texto(String), para ao percorrer cada digito do texto ser convertido de char para String e depois para Inteiro e depois somado.


 ->No arquivo teste SomaDigitosFatorialTests.cs: instancia a classe [SomaDigitosFatorial]. Informado o resultadoEsperado pelo método [Calcula] e chamando o método e guarda o valor em outra variavel para ser validado em seguida.
    Foi realizado com alguns numeros, como fatorial de 3,4,2000. Resultando no tempo médio em torno de 110 ms


	
