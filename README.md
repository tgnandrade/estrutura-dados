# Estruturas de Dados em .NET – Fila e Pilha

**Fila**

Uma fila implementa uma ordenação de tipo FIFO (First-In, First-Out), onde o primeiro valor adicionado será o primeiro a ser removido. Basicamente, é a mesma coisa que no mundo real! Os primeiros que chegam para serem atendidos, serão atendidos primeiro, por exemplo. Em .NET, a classe que implementa essa estrutura de dados é a Queue e *Queue << T >>*.

As principais operações de uma fila são:

* Enqueue: realiza a inserção de um valor.
* Peek: retorna o próximo valor, mas não remove.
* Dequeue: retorna o próximo valor, e remove.

**Pilha**

Uma pilha implementa uma ordenação de tipo LIFO (Last-In, First-Out), onde o último valor adicionado será o primeiro a ser removido. Um exemplo do mundo real é o de pilha de pratos para lavar, onde o que estiver no topo (último empilhado) será o primeiro a ser lavado. Em .NET, a classe que implementa essa estrutura de dados é a Stack e *Stack << T >>*.

As principais operações de uma pilha são:

* Push: realiza a inserção de um valor.
* Peek: retorna o próximo valor, mas não o remove da pilha.
* Pop: retorna o próximo valor e remove da pilha.
