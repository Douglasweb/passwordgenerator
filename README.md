# Password Generator

Este é um projeto de estudo usando C# Console Application, onde gero uma senha baseado no pedido de número de caracteres(tamanho da senha), escolhendo se nela conterá números, caracteres maiusculos e/ou minusculos e caracteres especiais.


### `Idéia`

O estudo se baseava em gerar a senha conforme o pedido. Porém ao fazer isso, todos os caracteres tinham que ser misturados para não ficar uniforme.


### `Como foi feito`

Primeiramente todos os caracteres permitidos/possíveis eram colocados em variavéis, após isso o sistema percorria o loop até o numero de caractere pedido fosse atingido, pegando um caractere aleatório na seguinte ordem:
- Caractere minusculo
- Numero
- Caractere Especial
- Caractere maiusculo

Caso o tipo acima fosse pedido, ele irá inserir numa varáivel até atingir o tamanho máximo.
Obs:  O Caractere Especial foi reduzido para ficar mais "normal" a senha gerada.

Após gerar a senha, é hora de misturá-la.

Aqui pecorro todos os caracteres da senha gerada baseado no tamanho da senha, no qual é armazenada em uma variável(tamanho). 

- Pego um caractere em uma posição aleatória e armazeno numa variável(NumeroRandomico).
- Pego a posição do caractere aleatório acima e adiciono nele o valor que existe na última posição.
- Agora inverto, insiro na última posição o valor que ficou na variável(NumeroRandomico).
- No final, diminuo o tamanho do da senha armazenada na variável(tamanho).

Após isso a senha é mostrada.




<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/Douglasweb/passwordgenerator">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/Douglasweb/passwordgenerator">
  
  <a href="https://github.com/Douglasweb/ApiCore/passwordgenerator/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/Douglasweb/passwordgenerator">
  </a>

  <a href="https://github.com/Douglasweb/passwordgenerator/issues">
    <img alt="Repository issues" src="https://img.shields.io/github/issues/Douglasweb/passwordgenerator">
  </a>
</p>
