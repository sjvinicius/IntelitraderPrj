//Libs
import styled from 'styled-components';

//Icons
import { Person } from '@styled-icons/fluentui-system-regular/Person'
import { Lock } from '@styled-icons/boxicons-regular/Lock'
import { PersonMoney } from '@styled-icons/fluentui-system-regular/PersonMoney'
import { SearchDollar } from '@styled-icons/fa-solid/SearchDollar'
import { MoneyDollarCircle } from '@styled-icons/remix-fill/MoneyDollarCircle'
import { TransferAlt } from '@styled-icons/boxicons-regular/TransferAlt'


//Imgs
import bgLogin from '../../../img/bgLogin.png'

export const Container = styled.div`
  width: 100vw;
  height: 100vh;
  background-image: url(${bgLogin}); //Cinza 1
  display:flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

`;

export const ContentLogin = styled.div`
  background: #333333D9;
  width: 80vw;
  height: 80vh;
  border-radius: 15px;
  display: flex;
`;

export const SectionBanner = styled.div`
  width: 75%;

`;

export const TittleBanner = styled.h1`
  color: #FB7A1D;
  font-size: 4rem;
  letter-spacing: 5px;
  text-transform: capitalize;
  text-transform: uppercase;
  margin: 2rem 2rem;

`;

export const TextBanner = styled.p`
  color: #FFF;
  text-align: start;
  :hover{
    color: #FFF

  }
`;

export const SectionLogin = styled.div`
  width: 10rem;

`;

export const Logo = styled.img`
  width: 15rem;
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
