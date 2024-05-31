# Saque-Banco

**Documentação do Código de Saque Bancário Simples**

**Objetivo:**
Este programa foi desenvolvido para simular um caixa eletrônico básico, permitindo que o usuário faça saques de uma conta bancária.

**Funcionamento:**
1. O programa começa definindo o saldo total da conta bancária como R$1500,00.
2. Exibe na tela o saldo atual.
3. Solicita ao usuário que insira o valor que deseja sacar.
4. Calcula o novo saldo subtraindo o valor do saque do saldo total.
5. Simula um breve período de espera de 2 segundos.
6. Verifica se o valor do saque é menor ou igual ao saldo total:
   - Se for, realiza o saque com sucesso e exibe o novo saldo.
   - Se não for, informa que o saldo é insuficiente e o saque não é realizado.

**Funcionalidades:**
- Exibir saldo atual.
- Permitir ao usuário inserir o valor do saque.
- Verificar se o saldo é suficiente para o saque desejado.
- Atualizar o saldo e informar o usuário sobre o resultado do saque.

**Bibliotecas Utilizadas:**
- `System`: Utilizada para acessar funcionalidades do sistema, como entrada e saída de dados.
- `System.Threading`: Utilizada para simular um período de espera antes de exibir o resultado do saque.

**Instruções de Uso:**
1. Execute o programa.
2. Insira o valor que deseja sacar quando solicitado.
3. Aguarde a confirmação de sucesso ou a mensagem de saldo insuficiente.

**Observações:**
- Este é um exemplo básico e simplificado de um sistema de caixa eletrônico. Em um ambiente real, várias outras funcionalidades e verificações seriam necessárias, como autenticação do usuário, validação de saldo disponível, limite de saque diário, entre outras.
