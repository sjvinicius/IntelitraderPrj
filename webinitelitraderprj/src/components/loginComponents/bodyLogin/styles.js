//Libs
import styled from 'styled-components';

//Icons
import { Person } from '@styled-icons/fluentui-system-regular/Person'
import { Lock } from '@styled-icons/boxicons-regular/Lock'
import { PersonMoney } from '@styled-icons/fluentui-system-regular/PersonMoney'
import { SearchDollar } from '@styled-icons/fa-solid/SearchDollar'
import { MoneyDollarCircle } from '@styled-icons/remix-fill/MoneyDollarCircle'
import { TransferAlt } from '@styled-icons/boxicons-regular/TransferAlt'
// import { Person } from '@styled-icons/fluentui-system-regular/Person'

//Imgs
import bgLogin from '../../../img/bgLogin.png'


export const Container = styled.div`
  background-image: url(${bgLogin});
  background-size: cover;
  width: 100vw;
  height: 100vh;
  display:flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  background-repeat: no-repeat;

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
  display: flex;
  flex-direction: column;
  align-items: center;
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
  font-size: 1.2rem;
  text-align: start;
  transition: color 1s;
  :hover{
    color: #FB7A1D;
    transition: color 1s;

  }
`;

export const SectionLogin = styled.div`
  /* background-color: #FFF; */

`;

export const Logo = styled.img`
  width: 15rem;
  margin: 2.5rem 2rem;
`;

export const Error = styled.p`
  color: #FB7A1D; // Laranja
  margin: auto;
  
`;

export const FormLogin = styled.form`
  /* background-color: #bbbbbb; */
  height: 60%;
  display: flex;
  flex-direction: column;
  align-items: center;
  margin: 2.5rem 0;
`;

export const TittleInput = styled.h5`
  color: #FB7A1D; // Laranja
  margin: 0;
  padding-right:50%;
`;

export const WrapperBanner = styled.div`
  /* background-color: #ddd; */
  width: 23rem;
  display: flex;
  flex-direction: column;
`;

export const WrapperAlign = styled.div`
  display: flex;
  align-items: center;
  margin: 0.3rem 0;
`;

export const WrapperAlignForm = styled.div`
  display: flex;
  margin: 1rem;

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
  cursor: pointer;
  transition: color 2s;
  :hover{
    color: #FFF;
    transition: color 2s;

  }
`;

export const IconCoin = styled(MoneyDollarCircle)`
  width: 2.6rem;
  margin: 0 2rem;
  color: #FFF;

`;

export const IconSearchMoney = styled(SearchDollar)`
  width: 2.6rem;
  margin: 0 2rem;
  color: #FFF;

`;

export const IconTransact = styled(TransferAlt)`
  width: 2.6rem;
  margin: 0 2rem;
  color: #FFF;

`;

export const IconPersonMoney = styled(PersonMoney)`
  width: 2.6rem;
  margin: 0 2rem;
  color: #FFF;

`;

export const IconPerson = styled(Person)`
  color: #FFF;
  width: 2rem;
  margin-right: 0.3rem;

`;

export const IconLock = styled(Lock)`
  color: #FFF;
  width: 2rem;
  margin-right: 0.3rem;

`;