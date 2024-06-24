document.addEventListener('DOMContentLoaded', function() {
  const firstNumber = document.querySelector('.first-number');
  const secondNumber = document.querySelector('.second-number');
  const result = document.querySelector('.result');
  const operatortext = document.querySelector('.operatortext');
  const operators = document.querySelectorAll('.operator');
  const clearButton = document.querySelector('.clear');
  const errorMessage = document.getElementById('error');
  const errorMessagezero = document.getElementById('errorzero');

  function calculate() {
      const firstNum = parseFloat(firstNumber.value);
      const secondNum = parseFloat(secondNumber.value);
      const operator = document.querySelector('.operator.active').innerHTML;
      operatortext.value = operator;
      let resultValue;

        if (isNaN(firstNum) || isNaN(secondNum)) {
            errorMessage.style.display = 'block';
            errorMessagezero.style.display = 'none';
            result.value = '';
            return;
        } else {
            errorMessage.style.display = 'none';
            if (secondNum == 0) {
                errorMessagezero.style.display = 'block';
                result.value = '';
                return;
            } 
            errorMessagezero.style.display = 'none';
        }
      switch (operator) {
          case '+':
              resultValue = firstNum + secondNum;
              break;
          case '-':
              resultValue = firstNum - secondNum;
              break;
          case '*':
              resultValue = firstNum * secondNum;
              break;
              case '/':
                resultValue = firstNum / secondNum;
                break;
      }
      result.value = resultValue;
  }

  operators.forEach(operator => {
      operator.addEventListener('click', () => {
          operators.forEach(op => op.classList.remove('active'));
          operator.classList.add('active');
          calculate();
      });
  });

  clearButton.addEventListener('click', () => {
      firstNumber.value = '';
      secondNumber.value = '';
      operatortext.value = '';
      result.value = '';
      errorMessage.style.display = 'none';
      errorMessagezero.style.display = 'none';
  });

  calculate();
});