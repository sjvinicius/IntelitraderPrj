//Libs
import styled from 'styled-components';

//Imgs
import bgCadastro from '../../../img/bgCadastro.png'

//Icons
import {Person} from '@styled-icons/fluentui-system-regular/Person'
import {PersonAccounts} from '@styled-icons/fluentui-system-regular/PersonAccounts'
import {PersonTag} from '@styled-icons/fluentui-system-regular/PersonTag'
import {ArrowBack} from '@styled-icons/boxicons-regular/ArrowBack'

//Styles
import {Button} from '../../generic/button/styles'
import {Input} from '../../generic/input/styles'

export const ModalCont = styled.div`
  display: none;
  margin: 0 auto; 
`;

export const ModalCad = styled.div`
  margin: 0 auto; 
`;

export const ACContent = styled.div`
  margin: 0 auto; 
`;

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
  width: 90vw;
  height: 90vh;
  position: absolute;
  border-radius: 15px;
  display: flex;
`;

export const SectionSubPerson = styled.div`
  /* background-color: lightblue; */
  position: relative;
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

export const IconSubPersonA = styled(Person)`
  width: 3rem;
  color: #FB7A1D;
`;

export const IconSubProf = styled(PersonAccounts)`
  width: 3rem;
  transition: color 2s;
  :hover{
    color: #FB7A1D;
    transition: color 2s;
  }

`;

export const IconSubProfA = styled(PersonAccounts)`
  width: 3rem;
  color: #FB7A1D;

`;

export const IconSubLearn = styled(PersonTag)`
  width: 3rem;
  transition: color 2s;
  :hover{
    color: #FB7A1D;
    transition: color 2s;
  }
`;

export const IconSubLearnA = styled(PersonTag)`
  width: 3rem;
  color: #FB7A1D;
`;

export const SectionInformation = styled.form`
  /* background-color: lightgrey; */
  display: flex;
  width: 100%;
  height: 70%;
`;

export const DataCand = styled.div`
  /* background-color: red; */
  width: 35rem;
  justify-content: space-between;
`;

export const DataCandCad = styled.div`
  /* background-color: red; */
  width: 20rem;
  justify-content: space-between;
`;

export const WrapperExp = styled.div`
  /* background-color:red; */
  width: 28rem;
  height: 6.1rem;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
`;

export const WrapperSectionInput = styled.div`
  /* background-color:red; */
  margin: 2.7rem 0;

`;

export const SubTittleSub = styled.h2`
  color: #FFF;
  font-size: 2rem;
  margin: 0;
`;

export const WrapperInput = styled.div`
  display: flex;
  flex-direction: column;
`;

export const DataXp = styled.div`
  display: flex;
`;

export const WrapperForm = styled.div`
  display:flex;
  flex-direction: column;

`;

export const InputDataXp = styled.div`
  /* background-color: lightgreen; */
  width: 17rem;
  height: 90%;
  display:flex;
  flex-direction: column;
  flex-wrap: wrap;
  border: 1px groove #FB7A1D;
  border-right: none;
  border-bottom: none;
  border-top: none;
  padding: 1.3rem 3rem;
`;

export const PreTittleInput = styled.p`
  margin: 1rem 0 0 0;
  color: #FFF;
`;

export const TittleInput = styled.p`
  margin: 1rem 0 0 0;
  color: #FB7A1D;
  margin-top: 1rem;
`;

export const ButtonSub = styled(Button)`
margin-top: 2rem;
margin-left: 5.3rem;
/* margin: 2rem auto; */
  /* transform: rotate(90deg); */
`;

export const ButtonSubCont = styled(Button)`

  margin-top: 5rem;
`;

export const InputSub = styled(Input)`
  width: 10rem;
`;

export const IconBack = styled(ArrowBack)`
  width: 3rem;
  margin: 3rem 2rem;
  color: #FFF;
  cursor: pointer;
  :hover{
    color: #FB7A1D;

  }
`;

// export const ACContent = styled.div`


// `;  

// export const WrapperPerfis = styled.div`

// `;