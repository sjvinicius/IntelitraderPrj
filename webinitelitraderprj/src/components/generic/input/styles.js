import styled from 'styled-components';

export const Input = styled.input`
  width: 13rem;
  height: 1.6rem;
  color: #FFF;
  font-size: 1rem;
  outline: none;
  background-color: transparent;
  border: none;
  border-bottom: 1px solid #FB7A1D;
  font-weight: lighter;
  text-align: center;
  margin: 0 1rem;
`;

export const InputCad = styled(Input)`
  text-align: initial;
  position: relative;
  ::-webkit-inner-spin-button{

    -webkit-appearance: none;

  }
`;

export const InputDesc = styled.textarea`
  background-color: transparent;
  width: 15rem;
  height: 4rem;
  color: #FFF;
  padding: 0.5rem;
  border-radius: 5px;
  border: 1px solid #FB7A1D;
  border-right: none;
  outline: none;
  resize: none;
  font-size: 0.9rem;
  font-family: 'Roboto', sans-serif;
`;

export const SelectCad = styled.select`
  width: 13rem;
  height: 1.6rem;
  color: #FFF;
  font-size: 1rem;
  outline: none;
  background-color: transparent;
  border: none;
  border-bottom: 1px solid #FB7A1D;
  font-weight: lighter;
  text-align: center;
`;

export const OptionCad = styled.option`
  color: #FFF;
  font-size: 1rem;
  outline: none;
  margin: 0.5rem;
  background-color: #292929;
  border-bottom: 1px solid #FB7A1D;
  font-weight: lighter;
  text-align: center;
  border: #FB7A1D;
  :checked{
    color: #FB7A1D;
  }
`;

export const InputBoxCad = styled.input`
  margin-left: 0;
`;