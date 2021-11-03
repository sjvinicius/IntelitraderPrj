import styled from 'styled-components';

import { Person } from '@styled-icons/fluentui-system-regular/Person'
import { Lock } from '@styled-icons/boxicons-regular/Lock'

export const Container = styled.div`
  width: 100vw;
  height: 100vh;
  background-color: #292929; //Cinza 1
  display:flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

`;

export const Logo = styled.img`
  
`;

export const Error = styled.p`
  color: #FB7A1D; // Laranja
  margin: auto;
  
`;

export const FormLogin = styled.form`
  
`;

export const TittleInput = styled.h5`
  color: #FB7A1D; // Laranja
  margin: 0;
  margin-top: 2.8rem;
  margin-left: 2.8rem;
`;

export const WrapperAlign = styled.div`
  display: flex;
  align-items: center;
  :hover{

    color: #FB7A1D

  }
`;

export const IconUser = styled(Person)`
  width: 2.3rem;
  padding-right: 0.5rem;
  color: #FFF;
`;

export const IconPwd = styled(Lock)`
  width: 2rem;
  padding-right: 0.5rem;
  color: #FFF;
`;

export const SignUp = styled.p`
  color: #FB7A1D;
  margin-top: 2rem; 
`;
