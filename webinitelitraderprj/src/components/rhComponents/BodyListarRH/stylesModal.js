//Libs
import styled from 'styled-components';

//Icons
import {Cancel} from '@styled-icons/material-outlined/Cancel'

export const WrapperModal = styled.div`
  position: absolute;
  background-color: #292929;
  width: 60vw;
  height: 70vh;
`;

export const WrapperSubs = styled.div`
  height: 3.6rem;
  display: flex;
`;

export const SubImg = styled.img`
  border-radius: 50%;
  width: 3rem;
  height: 3rem;
  margin-right: 1rem;
  cursor: pointer;

`;

export const IconCancel = styled(Cancel)`
  width: 3rem;
  color: red;
  cursor: pointer;
  padding-bottom: 0.3rem;
  :hover{
    color: #FF4444;

  }

`;