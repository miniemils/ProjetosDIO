import Input from './components/Input';
import Button from './components/Button';

import {Container, Content, Row} from './styles';
import {useState} from 'react';

const App = () => {
  const [currentNumber, setCurrentNumber] = useState("0");
  const [firstNumber, setFirstNumber] = useState('0');
  const [operation, setOperation] = useState('');

  const handleOnClear = () => {
    setCurrentNumber('0')
    setFirstNumber('0')
    setOperation('')
  }

  const handleBackspace = () => {
    setCurrentNumber(prev => prev.length > 1 ? prev.slice(0, -1) : '0');
  }

  const handleAddNumber = (num) => {
      setCurrentNumber(prev => `${prev === '0' ? '' : prev}${num}`)
  }

  const handleSumNumbers = () => {
    if (firstNumber === '0') {
        setFirstNumber(String(currentNumber));
        setCurrentNumber('0')
        setOperation('+')
    }
    else{
      const sum = Number(firstNumber) + Number(currentNumber);
      setCurrentNumber(String(sum))
      setOperation('')
    }
  }

  const handleMinusNumbers = () => {
    if (firstNumber === '0') {
        setFirstNumber(String(currentNumber));
        setCurrentNumber('0')
        setOperation('-')
    }
    else{
      const sum = Number(firstNumber) - Number(currentNumber);
      setCurrentNumber(String(sum))
      setOperation('')
    }
  }

  const handleMultiplyNumbers = () => {
    if (firstNumber === '0') {
        setFirstNumber(String(currentNumber));
        setCurrentNumber('0')
        setOperation('×')
    }
    else{
      const sum = Number(firstNumber) * Number(currentNumber);
      setCurrentNumber(String(sum))
      setOperation('')
    }
  }

  const handleDivideNumbers = () => {
    if (firstNumber === '0') {
        setFirstNumber(String(currentNumber));
        setCurrentNumber('0')
        setOperation('/')
    }
    else{
      const sum = Number(firstNumber) / Number(currentNumber);
      setCurrentNumber(String(sum))
      setOperation('')
    }
  }

  const handleEquals = () => {
    if (operation === '+') {
      const sum = Number(firstNumber) + Number(currentNumber);
      setCurrentNumber(String(sum));
      setFirstNumber('0');
      setOperation('');
    } else if (operation === '-') {
      const difference = Number(firstNumber) - Number(currentNumber);
      setCurrentNumber(String(difference));
      setFirstNumber('0');
      setOperation('');
    } else if (operation === '×') {
    const product = Number(firstNumber) * Number(currentNumber);
    setCurrentNumber(String(product));
    setFirstNumber('0');
    setOperation('');
  } else if (operation === '/') {
    const quotient = Number(firstNumber) / Number(currentNumber);
    setCurrentNumber(String(quotient));
    setFirstNumber('0');
    setOperation('');
  }
}

  return (
    <Container>
      <Content>
        <Input value={currentNumber}/>
        <Row>
          <Button label="X" onClick={handleBackspace}/>
          <Button label="C" onClick={handleOnClear}/>
          <Button label="/" onClick={handleDivideNumbers}/>
          <Button label="×" onClick={handleMultiplyNumbers}/>
        </Row>
        <Row>
          <Button label="9" onClick={() => handleAddNumber('9')}/>
          <Button label="8" onClick={() => handleAddNumber('8')}/>
          <Button label="7" onClick={() => handleAddNumber('7')}/>
          <Button label="-" onClick={handleMinusNumbers}/>
        </Row>
        <Row>
          <Button label="6" onClick={() => handleAddNumber('6')}/>
          <Button label="5" onClick={() => handleAddNumber('5')}/>
          <Button label="4" onClick={() => handleAddNumber('4')}/>
          <Button label="+" onClick={handleSumNumbers}/>
        </Row>
        <Row>
          <Button label="3" onClick={() => handleAddNumber('3')}/>
          <Button label="2" onClick={() => handleAddNumber('2')}/>
          <Button label="1" onClick={() => handleAddNumber('1')}/>
          <Button label="=" onClick={handleEquals}/>
        </Row>
      </Content>
    </Container>
  );
}

export default App;
