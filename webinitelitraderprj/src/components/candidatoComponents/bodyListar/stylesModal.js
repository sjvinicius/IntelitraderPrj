import styled from 'styled-components';

import {Close} from '@styled-icons/evil/Close'
import {LogoGitlab} from '@styled-icons/ionicons-solid/LogoGitlab'
import {Eagle} from '@styled-icons/simple-icons/Eagle'
import {Grooveshark} from '@styled-icons/entypo-social/Grooveshark'
import {Wolframlanguage} from '@styled-icons/simple-icons/Wolframlanguage'

export const ContainerModal = styled.div`
  position: absolute;
  width: 100vw;
  height: 100vh;
  display: none;
  background: #00000099;
  position: absolute;
  margin: 0;
  align-items: center;
  justify-content: center;
  transition: all 2s ease-in-out;
`;

export const WrapperModal = styled.div`
  position: relative;
  background-color: #292929;
  width: 60vw;
  height: 55vh;
`;

export const Top = styled.div`
  height: 1rem;
  padding: 0.5rem;
`;

export const IconClose = styled(Close)`
  width: 2rem;
  cursor: pointer;
  color: red;
  :hover{
    color: #FF4444;

  }
`;

export const WrapperSection = styled.div`
  display: flex;
`;

export const SectionInfo = styled.div`
  /* background-color: gray; */
  width: 60%;
  height: 17.45rem;;
  padding: 2rem;
`;

export const TittleJobModal = styled.h2`
  color: #FFF;
  margin: 0;
  padding: 0;
  font-size: 1.8rem;
`;

export const SubTittleJob = styled.h4`
  /* background-color: #000; */
  width: auto;
  margin:0;
  font-size: 0.9rem;
  color: #FFF;
  text-align: end;
  margin: 0 2rem;
`;

export const SubTittleJobModal = styled.h3`
  /* background-color: #000; */
  width: auto;
  margin:0;
  font-size: 0.9rem;
  color: #FFF;
`;

export const WrapperDesc = styled.div`
  /* background-color: lightblue; */
  width: 28rem;
  height: 11rem;
  border: 1px solid #FFF;
  border-right: transparent;
  border-radius: 5px;
  overflow: none;
  margin: 1rem 0;
  color: #FFF;
`;

export const TextDesc = styled.textarea`
  width: 26rem;
  height: 9rem;
  color: #FFF;
  background-color: transparent;
  font-family: 'Roboto', sans-serif;
  border: none;
  resize: none;
  outline: none;
  padding: 1rem;
`;

export const Text = styled.p`
  color: #FFF;
  font-family: 'Roboto', sans-serif;
`;

export const Section = styled.div`
  /* background-color: #666; */
  width: 40%;
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
  text-align: center;
`;

export const WrapperPerfis = styled.div`
  position: relative;
  width: 100%;
  display:flex;
  justify-content: space-around;
  margin: 2rem 0;
`;

export const CatIcon = styled(LogoGitlab)`
  width: 3.6rem;
  color: #FFF;
  height: 3.6rem;
  border: 3px solid #FFF;
  border-radius: 50%;
  transition: width 2s, height 2s, border-color 2s, color 2s;
  :hover{
    width: 4.2rem;
    height: 4rem;
    color: #FB7A1D;
    border: 3px solid;
    border-color: #FB7A1D;
  }
`;
export const WolfIcon = styled(Wolframlanguage)`
  width: 4rem;
  color: #FFF;
  border-radius: 50%;
  transition: width 2s, height 2s, color 1s;
  :hover{
    width: 4.5rem;
    color: #FB7A1D;
  }
`;
export const SharkIcon = styled(Grooveshark)`
  width: 4.6rem;
  color: #FFF;
  border-radius: 50%;
  transition: width 2s, height 2s, border-color 2s, color 2s;
  :hover{
    width: 5rem;
    color: #FB7A1D;
  }
`;
export const EagleIcon = styled(Eagle)`
  width: 4rem;
  color: #FFF;
  border-radius: 50%;
  transition: width 2s, height 2s, color 1s, border 2s;
  :hover{
    width: 4.5rem;
    color: #FB7A1D;
  }
`;

export const TextTooltip = styled(Text)`
  width: 20rem;

`