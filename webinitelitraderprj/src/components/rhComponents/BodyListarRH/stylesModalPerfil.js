//Libs
import styled from 'styled-components';

//Styles
import { WrapperModal } from './stylesModal';
import { WolfIcon } from '../../candidatoComponents/bodyListar/stylesModal';
import { EagleIcon } from '../../candidatoComponents/bodyListar/stylesModal';
import { Text } from '../../candidatoComponents/bodyListar/stylesModal'

export const WrapperModalPerfil = styled(WrapperModal)`
  position: relative;
  width: 70vw;
  height: 90vh;
  align-items: center;  
`;

export const SectionModalPerfil = styled.div`
  display: flex;
`;

export const WrapperProfile = styled.div`
  width: 40rem;
  display: flex;
  flex-direction: column;
  align-items: center;  

`;


export const WrapperComp = styled.div`
  display: flex;
  width: 100%;
  height: 5rem;
  justify-content: space-around;
  margin: 3rem 0 ;
  padding: 0 1rem;
`;

export const IconWolfModal = styled(WolfIcon)`
  width: 3rem;  
  
`;

export const IconEagleModal = styled(EagleIcon)`
  width: 3rem;
  
`;

export const WrapperInfosProfile = styled.div`
    overflow: auto;

`;

export const TextName = styled(Text)`
  font-size: 2rem;
  font-weight: bold;
  margin: 0;

`;

export const SubModalProfile = styled(Text)`
  margin: 0;

`;

export const TextModalProfile = styled(Text)`
  margin: 0;
  text-align: center;
  :nth-child(2){
    margin-top: 2rem;
  }
  
`;

