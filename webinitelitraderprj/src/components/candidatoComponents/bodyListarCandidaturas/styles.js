//Libs
import styled from 'styled-components';

//Icons
import { SendClock } from '@styled-icons/fluentui-system-regular/SendClock'
import { RemoveDone } from '@styled-icons/material/RemoveDone'
import { AlertTriangle } from '@styled-icons/feather/AlertTriangle'
import { CheckmarkDone } from '@styled-icons/ionicons-outline/CheckmarkDone'
// import { PersonDelete } from '@styled-icons/fluentui-system-regular/PersonDelete'
import { PeopleSearch } from '@styled-icons/fluentui-system-regular/PeopleSearch'
import { PersonAvailable } from '@styled-icons/fluentui-system-regular/PersonAvailable'
import { TelephoneOutbound } from '@styled-icons/bootstrap/TelephoneOutbound'
// import { TelephoneX } from '@styled-icons/bootstrap/TelephoneX'

export const Container = styled.div`
  
`;

export const CardJobStatus = styled.div`
  display:flex;
  position: relative;
  margin: 1rem 0;
`;

export const SectionJob = styled.div`
  

`;

export const SectionStatus = styled.div`
  background-color: #333333;
  height: 13rem;
  border-radius: 0px 10px 10px 0;
`;

export const WrapperStatus = styled.div`
  width: 30rem;
  height: 100%;
  color: #FFF;
  margin: auto 0;
  position: relative;
  display: flex;
  align-items: center;
  justify-content: space-around;
`;

export const IconSubscribe = styled(SendClock)`
  width: 3rem;

  :hover{

  color: #FB7A1D;

  }
`;

export const IconTechTestAprove = styled(CheckmarkDone)`
  width: 3rem;

  :hover{

color: #FB7A1D;

}
`;

export const IconTechTest = styled(AlertTriangle)`
  width: 3rem;

  :hover{

color: #FB7A1D;

}
`;

export const IconTechTestReprove = styled(RemoveDone)`
  width: 3rem;

  :hover{

color: #FB7A1D;

}
`;

export const IconRhAnalyAprove = styled(PersonAvailable)`
  width: 3rem;

  :hover{

color: #FB7A1D;

}
`;

// export const IconRhAnalyReprove = styled(PersonDelete)`
//   width: 3rem;

// `;

export const IconRhAnaly = styled(PeopleSearch)`
  width: 3rem;

  :hover{

    color: #FB7A1D;

  } 
`;

export const IconPhoneCall = styled(TelephoneOutbound)`
  width: 2.5rem;

  :hover{

    color: #FB7A1D;

  } 
`;

// export const IconPhoneX = styled(TelephoneX)`
//   width: 3rem;

//   :hover{

//     color: #FB7A1D;

//   }
// `;
