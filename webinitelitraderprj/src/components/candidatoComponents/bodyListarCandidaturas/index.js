//Libs
import React, { useEffect, useState } from 'react'
import {useHistory } from 'react-router-dom'

//Styles
import { CardJobStatus, SectionJob, SectionStatus, WrapperStatus,  IconSubscribe, IconTechTest, /*IconTechTestReprove,*/ /*IconRhAnalyAprove,*/ IconRhAnaly, /*IconRhAnalyReprove,*/ IconPhoneCall, /*IconPhoneX*/ } from './styles'

import { ContainerModal, WrapperModal, Top, IconClose, WrapperSection, SectionInfo, TittleJobModal, SubTittleJobModal, SubTittleJob, WrapperDesc, TextDesc, Text, Section, WrapperPerfis, CatIcon, WolfIcon, SharkIcon, EagleIcon } from '../bodyListar/stylesModal'

import { TittleNavNow } from '../bodyListarMinhas/styles'

import { ContentAside, ImgUser, NameUser, TypeUser, Exit, WrapperNav, IconAllJob, IconMyJobs, IconStatusJob, TittleNav, Line, /* Fim Aside */ Container, WrapperContent, Logo, WrapperTittle, ListJob, TabAction, BackgroundCard, TittleJob } from '../bodyListar/styles'

//Img
import foto from '../../../img/Foto.jpg'
import logo from '../../../img/IntelitraderLogo.svg'
import bec from '../../../img/backendcard.png'

// Components
import { ButtonSmall, Button } from '../../generic/button/styles'

function CloseModal() {
    
    document.getElementById('Modal').style.display = 'none';
    
}

function OpenModal() {

    document.getElementById('Modal').style.display = 'flex';

}

export function Modal() {
    
    const [a, setTittle] = useState(``)
    const [b, setSubTittle] = useState(``)
    const [descricao] = useState(`Esta destinada a voce candidato(a) que está procurando pela primeira oportunidade de emprego acompanhe os requisitos

    Requisitos

    Conhecimentos em C# 
    Cursando Técnico ou Superior em Desenvolvimento
    Programação Orientada a Objetos
    Visual Studio Community
    GitHub
    Azure Devops
    Esta vaga esta destinada a voce candidato que está procurando pela primeira oportunidade de emprego acompanhe os requisitos`)
    
    function BuscarVaga() {
        
        setTittle('ASDASDASDASD')
        setSubTittle('ASDASDASDASD')
    
    }

    useEffect( () => {
        
        BuscarVaga()
        
    },[])
    

    return(

        <ContainerModal id='Modal'>
            <WrapperModal>
                <Top>
                    <IconClose onClick={CloseModal}/>
                </Top>
                <WrapperSection>
                    <SectionInfo>
                        <TittleJobModal>{a}</TittleJobModal>
                        <SubTittleJobModal>{b}</SubTittleJobModal>
                        <WrapperDesc>
                            <TextDesc
                                value={descricao}
                                readOnly
                                disable
                            />
                        </WrapperDesc>
                        <Text>R$a Salario</Text>
                    </SectionInfo>
                    <Section>
                        <WrapperPerfis>
                            <CatIcon />
                            <WolfIcon />
                            <SharkIcon />
                            <EagleIcon />
                        </WrapperPerfis>
                        <SubTittleJob> $Contrato </SubTittleJob>
                        <SubTittleJob> $Nível </SubTittleJob>
                        <SubTittleJob> $Area </SubTittleJob>
                        <SubTittleJob> $Local</SubTittleJob>
                        <Button value='Candidatar' readOnly/>
                    </Section>
                </WrapperSection>
            </WrapperModal>
        </ContainerModal>

    )
    
}

function AsideMenu() {

    const history = useHistory()

    function LogOff(){

        localStorage.setItem('tkUserUp', '')

        history.push('/Login')

    }
    
    return (
        <ContentAside>
            
            <ImgUser src={foto} />
            <NameUser>Vinicius</NameUser>
            <TypeUser>Candidato</TypeUser>
            <Exit onClick={LogOff}>Sair</Exit>

            <WrapperNav onClick ={ () => {history.push('/Listar')} } >
                <IconAllJob/>
                <TittleNav>Todas as Vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav onClick ={ () => {history.push('/ListarMinhas')} }>
                <IconMyJobs/>
                <TittleNav>Minhas vagas</TittleNav>
            </WrapperNav>
            <Line/>
            <WrapperNav>
                <IconStatusJob />
                <TittleNavNow>Candidaturas</TittleNavNow>
            </WrapperNav>
            <Line/>

        </ContentAside>
    )

}


export default function BodyListarCandidaturas() {
    
    return(

        <Container>
            <AsideMenu/>
            <WrapperContent>
                <Logo src={logo}/>

                <ListJob>
                    
                  <CardJobStatus>
                    <BackgroundCard src={bec}/>
                    <SectionJob>
                      <WrapperTittle>
                          <TittleJob>Desenvolvedor BackEnd</TittleJob>
                      </WrapperTittle>
                      <TabAction>
                          <ButtonSmall onClick={OpenModal} value='Ver Mais' readOnly />
                      </TabAction>
                    </SectionJob>
                    <SectionStatus>
                      <WrapperStatus>
                          <IconSubscribe/>
                          {/* <IconTechAprove/> */}
                          <IconTechTest/>
                          {/* <IconTechTestReprove/> */}
                          {/* <IconOnAnalyAprove/> */}
                          <IconRhAnaly/>
                          {/* <IconOnAnalyReprove/> */}
                          {/* <IconRhAnlyAprove/> */}
                          {/* <IconRhAnalyAprove/> */}
                          <IconPhoneCall/>
                          {/* <IconPhoneX/> */}
                      </WrapperStatus>
                    </SectionStatus>
                  </CardJobStatus>
                    

                </ListJob>

            </WrapperContent>
            <Modal/>

        </Container>

    )

}