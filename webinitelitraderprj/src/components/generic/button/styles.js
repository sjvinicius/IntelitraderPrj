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
  transition: background-color 3s ease-in-out, color 2s ease-in-out;
  :hover {
    transition: background-color 3s , color 2s;
    background-color: #FFF;
    color: #FB7A1D;

  }
`;

export const ButtonCad = styled(Button)`
  margin: 2rem 0;

`;

export const ButtonAside = styled.input`
  background-color: #FB7A1D;
  width: 9rem;
  height: 2.5rem;
  color: #FFF;
  margin: 1rem auto;
  margin-right: 6rem; 
  /* margin: auto; */
  /* margin-top: 3rem; */
  font-Weight: bold;
  font-size: 1rem;
  border: none;
  border-radius: 10px;
  cursor: pointer;
  outline: none;
  text-align: center;
  transition: background-color 3s ease-in-out, color 2s ease-in-out;
  :hover {
    transition: background-color 3s , color 2s;
    background-color: #FFF;
    color: #FB7A1D;

  }
`;

export const ButtonModal = styled.input`
  background-color: #269200;
  width: 8rem;
  height: 1.8rem;
  color: #FFF;
  margin: 0.7rem 1rem;
  font-Weight: bold;
  font-size: 1rem;
  border: none;
  border-radius: 10px;
  cursor: pointer;
  outline: none;
  text-align: center;
  transition: background-color 3s ease-in-out, color 2s ease-in-out;
  :hover{
    transition: background-color 3s, color 2s;
    background-color: #FFF;
    color: #269200;

  }
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
  transition: background-color 3s ease-in-out, color 2s ease-in-out;
  :hover{
    transition: background-color 3s, color 2s;
    background-color: #FFFFFF;
    color: #FB7A1D;

  }
`;

export const ButtonCancel = styled.input`
  background-color: transparent;
  color: #FFF;
  font-size: 1.2rem;
  text-decoration: underline;
  text-transform: capitalize;
  border: none;
  outline: none;
  cursor: pointer;
  margin: 6rem 0;
  transition: color 2s;
  :hover{
    transition: color 2s;
    color: #FB7A1D;

  }
`;
