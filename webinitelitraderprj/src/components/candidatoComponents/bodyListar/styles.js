//Libs
import styled from 'styled-components';
  
//Icons
import { BriefcaseAlt } from '@styled-icons/boxicons-regular/BriefcaseAlt'
import { TargetArrow } from '@styled-icons/fluentui-system-regular/TargetArrow'
import { BookmarkCheck } from '@styled-icons/bootstrap/BookmarkCheck'

export const Container = styled.div`
  display: flex;
  background-color: #292929;
`;

export const ContentAside = styled.div`
  background-color: #333333;
  color: #FFF;
  width: 25vw; 
  height: 100vh;
  display: flex;
  flex-direction: column;
  align-items: center;
`;

export const ImgUser = styled.img`
  width: 8rem;
  border-radius: 50%;
  margin-top: 2rem;
`;

export const NameUser = styled.p`
    font-size: 1.6rem;
    margin: 0.5rem;
    color: #FB7A1D;
`;

export const TypeUser = styled(NameUser)`
  margin-top: 0.5rem;
  font-size: 0.8rem;
  color: #FFF;
`;

export const Exit = styled(TypeUser)`
  color: red;
  font-size: 1rem;
  margin-bottom: 3rem;
  cursor: pointer;
  :hover{
      color: #FF4444;
  }
`;

export const WrapperNav = styled.div`
  display: flex;
  align-items: center;
  margin: 1rem 0;
  /* background-color: red; */
  width: 80%;
  display: flex;
  align-self: flex-end;
  /* justify-content: center; */
  /* align-items: center; */
  :hover{

    color: #FB7A1D;
    cursor: pointer;

  }
`;

export const IconAllJob = styled(BriefcaseAlt)`
  width: 2.5rem;
  margin-right: 1rem;
`;

export const IconMyJobs = styled(TargetArrow)`
  width: 2.5rem;
  margin-right: 1rem;
`;

export const IconStatusJob = styled(BookmarkCheck)`
  width: 2.5rem;
  margin-right: 1rem;
`;

export const TittleNav = styled.p`
  font-size: 1rem;
  font-weight: normal;
  text-transform: capitalize;
  user-select: none;
`;

export const Line = styled.div`
  width: 15rem;
  border: 0.5px solid #FFF; 
`;

export const WrapperContent = styled.div`
  width: 75vw;
  display: flex;
  /* background-color: red; */
  flex-direction: column;
  align-items: center;
  overflow: auto;
`;

export const Logo = styled.img`
    width: 20rem;
    margin: 2.5rem 0;
`;

export const ListJob = styled.div`
  width: 55rem;
  height: 30rem;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  overflow: auto;
`;

export const CardJob = styled.div`
  position: relative;
  margin: 2rem 0;
`;

export const SectionStatus = styled.div`
  background-color: #333333;
  height: 13rem;
`;

export const BackgroundCard = styled.img`
  height: 11.25rem;
  position: absolute;
`;

export const WrapperTittle = styled.div`
  position: relative;
  width: 24.25rem;
  height: 4rem;
  display: flex;
  background: #FB7A1D9f;
  top: 4.5rem;
`;

export const TittleJob = styled.h2`
  padding-left: 1rem;
  display: flex;
  align-items: center;
`;

export const TabAction = styled.div`
  background-color: #333333;
  height: 3rem;
  position: relative;
  bottom: -3rem;

`;