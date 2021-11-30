//Libs
import styled from 'styled-components';

//Imgs
import bgCadastro from '../../../img/bgCadastro.png'

//Icons
import {Person} from '@styled-icons/fluentui-system-regular/Person'
import {PersonAccounts} from '@styled-icons/fluentui-system-regular/PersonAccounts'
import {PersonTag} from '@styled-icons/fluentui-system-regular/PersonTag'

//Styles
import {Button} from '../../generic/button/styles'

export const Container = styled.div`
  background-image: url(${bgCadastro});
  /* background-color: #444; */
  width: 100vw;
  height: 100vh;
  display: flex;
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

export const SectionSubPerson = styled.div`
  /* background-color: lightblue; */
  margin: 0 auto;
`;

export const TopPerson = styled.div`
  /* background-color: yellow; */
  display: flex;
  justify-content: space-between;
  color: #FFF;
`;

export const TittleSub = styled.h1`
  font-size: 3rem;
  color: #FB7A1D;
`;

export const IconSubPerson = styled(Person)`
  width: 3rem;
  transition: color 2s;
  :hover{
    color: #FB7A1D;
    transition: color 2s;
  }
`;

export const IconSubProf = styled(PersonAccounts)`
  width: 3rem;
  transition: color 2s;
  :hover{
    color: #FB7A1D;
    transition: color 2s;
  }

`;

export const IconSubLearn = styled(PersonTag)`
  width: 3rem;
  transition: color 2s;
  :hover{
    color: #FB7A1D;
    transition: color 2s;
  }
`;

export const SectionInformation = styled.div`
  /* background-color: lightgrey; */
  display: flex;
`;

export const DataCand = styled.div`
  /* background-color: red; */
  padding: 1rem ;
`;

// export const WrapperInputs = styled.div`
//   background-color: lightgreen;
// `;

export const SubTittleSub = styled.h2`
  color: #FFF;
  font-size: 2rem;
  margin: 0;
`;

export const DataXp = styled.div`
  display: flex;
`;

export const WrapperForm = styled.div`
  display:flex;
  flex-direction: column;

`;

export const InputDataXp = styled.form`
  /* background-color: lightgreen; */
  width: 15rem;
  display:flex;
  flex-direction: column;
  flex-wrap: wrap;
  border: 1px groove #FB7A1D;
  border-right: none;
  border-bottom: none;
  border-top: none;
  padding: 1.3rem 3rem;
`;

export const TittleInput = styled.p`
  margin: 1rem 0 0 0;
  color: #FFF;
`;

export const ButtonSub = styled(Button)`
  margin: 2rem auto;
`;

export const FooterSub = styled.div`
  margin-bottom: 2rem;
`;