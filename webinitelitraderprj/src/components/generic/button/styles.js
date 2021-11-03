import styled from 'styled-components';

export const Button = styled.input`
  background-color: #FB7A1D;
  width: 9rem;
  height: 2.5rem;
  color: #FFF;
  margin: auto;
  margin-top: 3rem;
  font-Weight: bold;
  font-size: 1rem;
  border: none;
  border-radius: 10px;
  cursor: pointer;
  outline: none;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
`;

export const ButtonSmall = styled.input`
  background-color: #FB7A1D;
  width: 4rem;
  height: 1rem;
  color: #FFF;
  margin: auto;
  margin-top: 3rem;
  font-Weight: bold;
  font-size: 0.6rem;
  border: none;
  border-radius: 10px;
  cursor: pointer;
  outline: none;
  display: flex;
  text-align: center;
  position: relative;
  top: 1rem;
  left: 8rem;
  :hover{

    background-color: #FFFFFF;
    color: #FB7A1D;

  }
`;
